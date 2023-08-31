using Dapper;
using SistemaCore;
using SistemaConexao;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessCadastros
{
    public class ClasseRepository : ConexaoSqlite, IClasseRepository<ClasseModel>
    {

        public ClasseRepository(string con)
        {
            // recebe a string de conexão que esta no 
            // arquivo appsettings.json
            // e passar para propriedade conexaoString
            // hedada da classe ConnectRepository()
            //************************************************
            conexaoString = con;

        }

        /// <summary>
        /// Metodo para filtrar a os dados da Lista
        /// </summary>
        /// <returns>Lista com os dados </returns>
        public IEnumerable<ClasseModel> Lista()
        {
            // obter todos os registros da tabela.
            //************************************************
            try
            {
                using var db = GetConexao();

                string cQryBase = @"SELECT * FROM dcclasse ORDER BY nome";

                return db.Query<ClasseModel>(cQryBase);


            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }

        /// <summary>
        /// Metodo para filtrar a os dados da Lista
        /// </summary>
        /// <param name="idFiltro">string com o id do Filtro</param>
        /// <param name="Valor">string a ser utilizada para o filtro</param>
        /// <returns>Lista com os dados </returns>
        public IEnumerable<ClasseModel> FiltrarLista(int idFiltro, string Valor)
        {
            // obter todos os registros da tabela.
            //************************************************
            try
            {

                string cQryBase = "SELECT * FROM dcclasse ";
                DynamicParameters parameter = new DynamicParameters();

                switch ((ClasseEnums)idFiltro)
                {
                    case ClasseEnums.ID:
                        cQryBase += "WHERE ID = @pId ";
                        cQryBase += "ORDER BY ID ";
                        parameter.Add("@pId", Valor.ToInt32());
                        break;

                    case ClasseEnums.Nome:
                        cQryBase += "WHERE NOME ilike @pNome ";
                        cQryBase += "ORDER BY NOME ";
                        parameter.Add("@pNome", "%" + Valor + "%");
                        break;

                }

                using var db = GetConexao();
                return db.Query<ClasseModel>(cQryBase, parameter);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

        }

        public ClasseModel BuscarID(int id)
        {
            using var db = GetConexao();
            return db.Query<ClasseModel>(@"SELECT * FROM dcclasse WHERE Id = @pId",
                                         new { pId = id }).SingleOrDefault();

        }

        public int Salvar(OperacaoEnum operacao, ClasseModel item)
        {
            int ret = 0;

            try
            {
                using var db = GetConexao();
                if (operacao == OperacaoEnum.SalvarInclusao) //if (oDados.ID == 0)
                {
                    //zero é inclusão
                    ret = db.Query<int>(@"INSERT INTO dcclasse(Nome, EmpresaId) 
                                    VALUES (@Nome, @EmpresaId) " + ConexaoLastID, item).SingleOrDefault();

                }
                else
                {
                    ret = db.Execute(@"UPDATE dcclasse SET Nome = @Nome, 
                                                        EmpresaId = @EmpresaId 
                                                        WHERE ID = @ID ", item);
                    //return item.ID;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

            return ret;
        }


        public int Excluir(int id)
        {
            int Ret = 0;
            try
            {
                using var db = GetConexao();
                Ret = db.Execute(@"DELETE FROM dcclasse WHERE ID = @pId",
                                        new { pId = id });

            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

            return Ret;
        }

        public ClasseModel NewModel()
        {

            return new ClasseModel();

        }

    }
}