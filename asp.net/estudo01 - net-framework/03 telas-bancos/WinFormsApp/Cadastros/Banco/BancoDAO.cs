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
        /// listar os dados da tabela
        /// </summary>
        public IEnumerable<Banco> Listar()
        {
            using var db = ConexaoDB;

            return db.Query<Banco>(@"SELECT * FROM fnbanco "); 
        }

    }

}