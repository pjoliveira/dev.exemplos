using Dapper;
using SistemaCore;
using System;
using System.Collections.Generic;
using System.Linq;
using SistemaConexao; 

namespace BusinessParametros
{
    public class PaisRepository : ConexaoSqlite, IPaisRepository<PaisModel>
    {

        public PaisRepository(string conString)
        {
            // recebe a string de conexão que esta no  
            // conexaoString é da classe IDBConnect
            //************************************************
            conexaoString = conString;

        }


        public IEnumerable<PaisModel> Lista()
        {
            // obter todos os registros da tabela.
            //************************************************
            try
            {
                using var db = GetConexao();
                return db.Query<PaisModel>(@"SELECT * FROM tgpais ORDER BY nome");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

        }


        public IEnumerable<PaisModel> FiltrarLista(int idFiltro, string Valor)
        {
            try
            {
                string cQryBase = @"SELECT * FROM tgpais ";
                DynamicParameters parameter = new DynamicParameters();

                switch ((FiltroPaisEnum)idFiltro)
                {
                    case FiltroPaisEnum.ID:
                        cQryBase += "WHERE ID = @pId ORDER BY ID ";
                        cQryBase += "ORDER BY ID ";
                        parameter.Add("@pId", Valor.ToInt32());
                        break;

                    case FiltroPaisEnum.Nome:
                        cQryBase += "WHERE NOME ilike @pNome ";
                        cQryBase += "ORDER BY NOME ";
                        parameter.Add("@pNome", "%" + Valor + "%");
                        break;
                }

                using var db = GetConexao();
                return db.Query<PaisModel>(cQryBase, parameter);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

        }

        public PaisModel NewModel()
        {

            return new PaisModel();

        }

        public PaisModel BuscarID(int id)
        {
            try
            {
                using var db = GetConexao();

                return db.Query<PaisModel>(@"SELECT * FROM tgpais WHERE Id = @pId ORDER BY nome", new { pId = id }).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }

        public int Salvar(OperacaoEnum operacao, PaisModel item)
        {
            try
            {
                using var db = GetConexao();
                if (operacao == OperacaoEnum.SalvarInclusao) //if (item.ID == 0)
                {
                    
                    return db.Execute(@"INSERT INTO tgpais(id, nome, sigla) 
                                            VALUES (@id, @Nome, @Sigla);", item);

                }
                else
                {
                    return db.Execute(@"UPDATE tgpais SET Nome = @Nome, Sigla = @Sigla
                                                   WHERE ID = @ID", item);
                    
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

                return db.Execute(@"DELETE FROM tgpais WHERE ID = @pId", new { pId = id });
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }

    }
}
