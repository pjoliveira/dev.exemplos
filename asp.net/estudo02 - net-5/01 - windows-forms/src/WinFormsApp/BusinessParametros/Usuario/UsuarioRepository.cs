using SistemaConexao;
using Dapper;
using SistemaCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessParametros
{
    public class UsuarioRepository : ConexaoSqlite, IUsuarioRepository<UsuarioModel>
    {

        public UsuarioRepository(string con)
        {
            // recebe a string de conexão que esta no 
            // arquivo appsettings.json
            // e passar para propriedade conexaoString
            // hedada da classe ConnectRepository()
            //************************************************
            conexaoString = con;

        }

        public IEnumerable<UsuarioModel> Lista()
        {
            // obter todos os registros da tabela.
            //************************************************
            try
            {
                using var db = GetConexao();
                return db.Query<UsuarioModel>(@"SELECT * FROM tgusuario ORDER BY EMail ");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

        }


        public IEnumerable<UsuarioModel> FiltrarLista(int idFiltro, string Valor)
        {
            try
            {
                string cQryBase = @"SELECT * FROM tgpais ";
                DynamicParameters parameter = new DynamicParameters();

                switch ((FiltroUsarioEnum)idFiltro)
                {
                    case FiltroUsarioEnum.ID:
                        cQryBase += "WHERE ID = @pId ORDER BY ID ";
                        cQryBase += "ORDER BY id ";
                        parameter.Add("@pId", Valor.ToInt32());
                        break;

                    case FiltroUsarioEnum.Nome:
                        cQryBase += "WHERE NOME ilike @pNome ";
                        cQryBase += "ORDER BY nome ";
                        parameter.Add("@pNome", "%" + Valor + "%");
                        break;

                    case FiltroUsarioEnum.Email:
                        cQryBase += "WHERE NOME ilike @pEmail ";
                        cQryBase += "ORDER BY email ";
                        parameter.Add("@pEmail", "%" + Valor + "%");
                        break;
                }

                using var db = GetConexao();
                return db.Query<UsuarioModel>(cQryBase, parameter);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

        }

        public UsuarioModel BuscarLogin(string email, string senha)
        {
            try
            {
                using var db = GetConexao();
                //importante não retornar o objeto com a senha do cara
                return db.Query<UsuarioModel>(@"SELECT * FROM tgusuario 
                                                    WHERE email = @pEmail and senha = @pSenha",
                                                new
                                                {
                                                    pEmail = email,
                                                    pSenha = senha
                                                }).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }


        public UsuarioModel BuscarID(int id)
        {
            // obter todos os registros da tabela.
            //************************************************
            try
            {
                using var db = GetConexao();
                return db.Query<UsuarioModel>(@"SELECT * FROM tgusuario WHERE Id = @pId",
                                         new { pId = id }).SingleOrDefault();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }


        }

        public int Salvar(OperacaoEnum operacao, UsuarioModel item)
        {
            try
            {
                string qryBase;

                if (operacao == OperacaoEnum.SalvarInclusao) //if (item.ID == 0)
                {
                    qryBase = "INSERT INTO tgusuario(Email, Senha, Nome, Tipo, Ativo, DataCadastro, DataValidade, ExpiraDias, DataSenha) " +
                                            "VALUES (@Email, @Senha, @Nome, @Tipo, @Ativo, @DataCadastro, @DataValidade, @ExpiraDias, @DataSenha) ";

                }
                else
                {
                    qryBase = "UPDATE tgusuario SET Email = @Email, " +
                                                      "Senha = @Senha, " +
                                                      "Nome = @Nome, " +
                                                      "Tipo = @Tipo, " +
                                                      "Ativo = @Ativo, " +
                                                      "DataCadastro = @DataCadastro, " +
                                                      "DataValidade = @DataValidade, " +
                                                      "ExpiraDias = @ExpiraDias, " +
                                                      "DataSenha = @DataSenha " +
                                  "WHERE ID = @ID ";
                    //return item.ID;
                }

                using var db = GetConexao();
                return db.Execute(qryBase, item);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }

        public int Excluir(int Id)
        {
            try
            {
                // Deletar o registro na tabela.
                //************************************************
                using var db = GetConexao();
                return db.Execute(@"DELETE FROM tgusuario WHERE ID = @pId", new { pId = Id });

                //return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }

    }
}
