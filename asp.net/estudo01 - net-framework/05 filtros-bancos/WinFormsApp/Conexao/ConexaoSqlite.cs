using Microsoft.Data.Sqlite;
using System.Configuration; 

namespace WinFormsApp
{
    /// <summary>
    ///     conexão com SQLite
    ///     ************************************************
    ///      para usar o SQLite
    ///          tem que instalar o packege no projeto Install-Package Microsoft.Data.SQLite
    ///          colocar o using Microsoft.Data.Sqlite
    /// </summary>
    public class ConexaoSqlite
    {
        /// <summary>
        ///    Retorna a string de conexão com o banco de dados. 
        /// </summary>
        public string ConexaoString
        {
            get
            {
                /*
                 * Adicionar essa configuração no App.config
                 * 
                 * < connectionStrings >
                 * < add name = "connectionString" connectionString = "..\\..\\..\\..\\..\\db-sqlite\\public-exemplos_dev.sqlite3" />
                 * </ connectionStrings >
                 *
                 * instalar o pacote System.Configuration.ConfigurationManager no projeto
                 * 
                */
              
                return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.Trim(); 

            }
        }

        /// <summary>
        ///    Retorna o ID gerado pelo ultimo insert 
        ///    SQLite: select last_insert_rowid()
        ///    POSTGRES SELECT LAST_INSERT_ID;
        /// </summary>
        public string ConexaoLastID
        {
            get
            {
                // ultimo ID ; 
                //************************************************
                string cConLastID = "select last_insert_rowid()";

                // retorna a string 
                //************************************************
                return cConLastID;

            }
        }

        /// <summary>
        ///    conexão com o Sqlite 
        /// </summary>
        public SqliteConnection ConexaoDB
        {
            get
            {
               
                return new SqliteConnection("Data Source = " + ConexaoString);

            }
        }

    }
}
