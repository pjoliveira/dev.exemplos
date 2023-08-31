using Dapper;
using SistemaCore;
using System;
using System.Collections.Generic;
using System.Linq;
using SistemaConexao; 

namespace BusinessParametros
{
    public class MunicipioRepository : ConexaoSqlite, IMunicipioRepository<MunicipioModel>
    {

        public MunicipioRepository(string conString)
        {
            // recebe a string de conexão que esta no             
            //************************************************
            conexaoString = conString;

        }


        public IEnumerable<MunicipioModel> Lista()
        {
            // obter todos os registros da tabela.
            //************************************************
            try
            {
                using var db = GetConexao();
                //return db.Query<MunicipioModel>(@"SELECT * FROM tgmunicipio ORDER BY nome");
                return db.Query<MunicipioModel, EstadoModel, MunicipioModel>(@"SELECT mu.*, uf.*  
                                                            FROM tgmunicipio AS mu 
                                                            INNER JOIN tguf AS uf ON uf.id = mu.ufid 
                                                            ORDER BY mu.nome",
                                                         map: (MunicipioModel, EstadoModel) =>
                                                         {
                                                             MunicipioModel.Estado = EstadoModel;
                                                             return MunicipioModel;
                                                         },
                                                         splitOn: "ufId");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

        }


        public IEnumerable<MunicipioModel> FiltrarLista(int idFiltro, string Valor)
        {

            try
            {
                DynamicParameters parameter = new DynamicParameters();
                string cQryBase = @"SELECT mu.*, uf.* 
                                      FROM tgmunicipio AS mu 
                                      INNER JOIN tguf AS uf ON uf.id = mu.ufid ";

                switch ((FiltroMunicipioEnum)idFiltro)
                {
                    case FiltroMunicipioEnum.ID:
                        cQryBase += "WHERE mu.ID = @pId ";
                        cQryBase += "ORDER BY mu.ID ";
                        parameter.Add("@pId", Valor.ToInt32());
                        break;

                    case FiltroMunicipioEnum.Nome:
                        cQryBase += "WHERE mu.nome ilike @pNome ";
                        cQryBase += "ORDER BY mu.nome ";
                        parameter.Add("@pNome", "%" + Valor + "%");
                        break;
                }

                using var db = GetConexao();
                return db.Query<MunicipioModel, EstadoModel, MunicipioModel>(cQryBase,
                                                         map: (MunicipioModel, EstadoModel) =>
                                                         {
                                                             MunicipioModel.Estado = EstadoModel;
                                                             return MunicipioModel;
                                                         },
                                                         parameter,
                                                         splitOn: "ufId");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

        }

        public MunicipioModel NewModel()
        {
            return new MunicipioModel();
        }

        public MunicipioModel BuscarID(int id)
        {
            try
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@pId", id);

                string cQryBase = "SELECT mu.*, uf.* " +
                                    "FROM tgmunicipio AS mu " +
                                    "INNER JOIN tguf AS uf ON uf.id = mu.ufid " +
                                    "WHERE mu.Id = @pId";


                using var db = GetConexao();

                return db.Query<MunicipioModel, EstadoModel, MunicipioModel>(cQryBase,
                                                         map: (MunicipioModel, EstadoModel) =>
                                                         {
                                                             MunicipioModel.Estado = EstadoModel;
                                                             return MunicipioModel;
                                                         },
                                                         parameter,
                                                         splitOn: "ufId").SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }

        public int Salvar(OperacaoEnum operacao, MunicipioModel item)
        {
            try
            {
                using var db = GetConexao();
                if (operacao == OperacaoEnum.SalvarInclusao) //if (item.ID == 0)
                {
                    //zero é inclusão
                    return db.Execute(@"INSERT INTO tgmunicipio(id, nome, ufId) 
                                            VALUES (@id, @Nome, @Ufid);",
                                            new
                                            {
                                                item.ID,
                                                item.Nome,
                                                Ufid = item.Estado.ID
                                            }
                                            );

                }
                else
                {
                    return db.Execute(@"UPDATE tgmunicipio SET Nome = @Nome, UfId = @UfId
                                                   WHERE ID = @ID",
                                                    new
                                                    {
                                                        item.ID,
                                                        item.Nome,
                                                        Ufid = item.Estado.ID
                                                    }
                                                    );
                    //return item.ID;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }


        public int Excluir(int id)
        {
            try
            {
                using var db = GetConexao();

                return db.Execute(@"DELETE FROM tgmunicipio WHERE ID = @pId", new { pId = id });
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }


    }
}
