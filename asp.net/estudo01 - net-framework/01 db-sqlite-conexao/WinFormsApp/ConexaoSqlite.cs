using Microsoft.Data.Sqlite;

namespace WinFormsApp
{
    /// <summary>
    /// Classe para conexão com o SQLite
    /// </summary>
    public class ConexaoSqlite
    {
        /* 
         * //conexão com SQLite
         * //************************************************
         *    para usar o SQLite
         *    tem que instalar o packege no projeto Install-Package Microsoft.Data.SQLite
         *    declarar o using Microsoft.Data.Sqlite
         *    Para usar o dapper
         *    tem quem instalar o package no projeto Install-Package dapper
         *    
         */

        /// <summary>
        ///   string de conexão com o SQLite
        /// </summary>
        public string ConexaoString
        {
            get
            {
                /*
                 * // string de conexão com o SQLite 
                 * // ************************************************
                 * // return Environment.CurrentDirectory + "\\emanager_dev.sqlite3";
                 * 
                 */
                
                return "..\\..\\..\\..\\..\\db-sqlite\\public-exemplos_dev.sqlite3";

            }
        }

        /// <summary>
        ///    Ultimo ID
        /// </summary>
        public string ConexaoLastID
        {
            get
            {
                // string SELECT LAST_INSERT_ID; 
                //************************************************
                string cUltimoID = "select last_insert_rowid()";

                // retorna o ultimo ID
                //************************************************
                return cUltimoID;

            }
        }

        /// <summary>
        ///    Cria conexão com o SQLite
        /// </summary>
        public SqliteConnection ConexaoDB
        {
            get
            {
                // cria conexão com o Sqlite 
                //************************************************
                return new SqliteConnection("Data Source = " + ConexaoString);
            }
        }
    }
}
