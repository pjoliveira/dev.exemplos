using Dapper;
using SistemaCore;
using SistemaConexao; 
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessParametros
{
    public class EstadoRepository : ConexaoSqlite, IEstadoRepository<EstadoModel>
    {

        public EstadoRepository(string conString)
        {
            // recebe a string de conexão que esta no  
            // conexaoString é da classe IDBConnect
            //************************************************
            conexaoString = conString;

        }


        public IEnumerable<EstadoModel> Lista()
        {
            // obter todos os registros da tabela.
            //************************************************
            try
            {

                using var db = GetConexao();

                return db.Query<EstadoModel, PaisModel, EstadoModel>(@"SELECT es.*, pa.*  
                                                            FROM tguf AS es 
                                                            INNER JOIN tgpais AS pa ON pa.id = es.paisid 
                                                            ORDER BY es.nome",
                                                                map: (EstadoModel, PaisModel) =>
                                                                {
                                                                    EstadoModel.Pais = PaisModel;
                                                                    return EstadoModel;
                                                                },
                                                                splitOn: "PaisId");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

        }


        public IEnumerable<EstadoModel> FiltrarLista(int idFiltro, string Valor)
        {
            try
            {
                DynamicParameters parameter = new DynamicParameters();
                string cQryBase = @"SELECT es.*, pa.*  
                                    FROM tguf AS es 
                                    INNER JOIN tgpais AS pa ON pa.id = es.paisid ";

                switch ((FiltroEstadoEnum)idFiltro)
                {
                    case FiltroEstadoEnum.ID:
                        cQryBase += "WHERE es.ID = @pId ";
                        cQryBase += "ORDER BY es.ID ";
                        parameter.Add("@pId", Valor.ToInt32());
                        break;

                    case FiltroEstadoEnum.Nome:
                        cQryBase += "WHERE es.nome ilike @pNome ";
                        cQryBase += "ORDER BY es.nome ";
                        parameter.Add("@pNome", "%" + Valor + "%");
                        break;
                }


                using var db = GetConexao();
                return db.Query<EstadoModel, PaisModel, EstadoModel>(cQryBase,
                                                                map: (EstadoModel, PaisModel) =>
                                                                {
                                                                    EstadoModel.Pais = PaisModel;
                                                                    return EstadoModel;
                                                                },
                                                                parameter,
                                                                splitOn: "PaisId");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

        }

        public EstadoModel NewModel()
        {

            return new EstadoModel();

        }

        public EstadoModel BuscarID(int id)
        {
            try
            {
                using var db = GetConexao();

                //return db.Query<EstadoModel>(@"SELECT * FROM tguf WHERE Id = @pId ORDER BY nome", new { pId = id }).SingleOrDefault();
                return db.Query<EstadoModel, PaisModel, EstadoModel>(@"SELECT es.*, pa.* 
                                                            FROM tguf AS es
                                                            INNER JOIN tgpais AS pa ON pa.id = es.paisid 
                                                            WHERE es.Id = @pId 
                                                            ORDER BY es.nome",
                                                            map: (EstadoModel, PaisModel) =>
                                                            {
                                                                EstadoModel.Pais = PaisModel;
                                                                return EstadoModel;
                                                            },
                                                            new
                                                            {
                                                                pId = id
                                                            },
                                                            splitOn: "PaisId"
                                                            ).SingleOrDefault();
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

                return db.Execute(@"DELETE FROM tguf WHERE ID = @pId", new { pId = id });
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }

        public int Salvar(OperacaoEnum operacao, EstadoModel item)
        {
            try
            {
                using var db = GetConexao();
                if (operacao == OperacaoEnum.SalvarInclusao) //if (item.ID == 0)
                {

                    return db.Execute(@"INSERT INTO tguf(id, nome, sigla, paisid) 
                                            VALUES (@id, @Nome, @Sigla, @PaisId);",
                                             new
                                             {
                                                 item.ID,
                                                 item.Nome,
                                                 item.Sigla,
                                                 PaisId = item.Pais.ID
                                             });

                }
                else
                {
                    return db.Execute(@"UPDATE tguf SET Nome = @Nome, Sigla = @Sigla, PaisId = @PaisId
                                                   WHERE ID = @ID",
                                                   new
                                                   {
                                                       //item.ID,
                                                       item.Nome,
                                                       item.Sigla,
                                                       PaisId = item.Pais.ID
                                                   });
                    //return item.ID;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }

    }
}
