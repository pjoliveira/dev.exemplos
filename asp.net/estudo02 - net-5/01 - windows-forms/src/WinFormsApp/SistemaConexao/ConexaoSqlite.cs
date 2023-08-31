using System.Data.SQLite;

namespace SistemaConexao
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

        // recebe a string de conexão com o banco.
        //************************************************
        protected static string conexaoString = null;

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
        public SQLiteConnection GetConexao()
        {
             
            return new SQLiteConnection("Data Source = " + conexaoString);

        }

    }
}
