using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp
{
    /// <summary>
    ///  Essa classe trata os dados diretamente com a banco de dados
    ///  Para funcionar deve instalar o ORM dapper    
    ///      tem quem instalar o package no projeto da dar um using no pacote.
    ///      Install-Package dapper  
    ///      using Dapper;
    /// </summary>
    public class BancoDAO : ConexaoSqlite
    {
        /// <summary>
        ///     listar os dados da tabela
        /// </summary>
        public IEnumerable<Banco> Listar()
        {
            using var db = ConexaoDB;

            return db.Query<Banco>(@"SELECT * FROM fnbanco "); 
        }

        /// <summary>
        ///     listar filtrando os dados da tabela 
        /// </summary>
        public IEnumerable<Banco> Listar(int idFiltro, string valor)
        {
            // obter todos os registros da tabela.
            //************************************************
            try
            {
                // select basico.
                //************************************************
                string cQryBase = "SELECT * FROM fnbanco ";

                // parametros da para select
                //************************************************
                DynamicParameters parameter = new DynamicParameters();

                // verificar qual o filtro foi selecionado
                // e preparar o select com base no filtro escolhido
                //************************************************
                switch ((FiltroBancoEnum)idFiltro)
                {

                    case FiltroBancoEnum.Codigo:
                        // montar o select 
                        //************************************************
                        cQryBase += "WHERE CODIGO like @pCODIGO ";
                        cQryBase += "ORDER BY CODIGO ";
                        
                        // adicionar o parametro 
                        //************************************************
                        parameter.Add("@pCODIGO", "%" + valor + "%");
                        break;

                    case FiltroBancoEnum.Nome:
                        // montar o select 
                        //************************************************
                        cQryBase += "WHERE NOME like @pNome ";
                        cQryBase += "ORDER BY NOME ";

                        // adicionar o parametro 
                        //************************************************
                        parameter.Add("@pNome", "%" + valor + "%");
                        break;
                }

                // executar o select na base de dados
                //************************************************
                using var db = ConexaoDB;
                return db.Query<Banco>(cQryBase, parameter);


            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }

        }

        /// <summary>
        ///     bucar os dados na tabela pelo ID/codigo
        /// </summary>
        public Banco BuscarID(string Codigo)
        {
            using var db = ConexaoDB;
            
            return db.Query<Banco>(@"SELECT * FROM fnbanco WHERE Codigo = @pCodigo", new { pCodigo = Codigo }).SingleOrDefault();

            
        }

        /// <summary>
        ///     excluir os dados na tabela pelo ID/codigo
        /// </summary>
        public int Excluir(string Codigo)
        {
            using var db = ConexaoDB;
            return db.Execute(@"DELETE FROM fnbanco WHERE Codigo = @pCodigo", new { pCodigo = Codigo });

            
        }

        /// <summary>
        ///     Salvar os dados na tabela
        /// </summary>
        public int Salvar(OperacaoEnum operacao, Banco banco)
        {
            try
            {
                using var db = ConexaoDB;
                if (operacao == OperacaoEnum.SalvarInclusao) 
                {
                        //zero é inclusão
                        return db.Execute(@"INSERT INTO fnbanco(codigo, nome, fantasia, idempresa) 
                                            VALUES (@Codigo, @Nome, @fantasia, @IdEmpresa);", banco);

                }
                else
                {
                       return  db.Execute(@"UPDATE fnbanco SET Nome = @Nome, Fantasia = @Fantasia, 
                                                            IdEmpresa = @IdEmpresa 
                                                            WHERE Codigo = @Codigo ", banco);
                        
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:\n" + ex.Message);
            }
        }

        
       

  
    }

}