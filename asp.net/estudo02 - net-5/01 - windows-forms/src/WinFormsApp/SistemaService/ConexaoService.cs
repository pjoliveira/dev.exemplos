using System.Configuration;

namespace SistemaServices
{
    public static class ConexaoService
    {
        //public static IConfigurationRoot Configuration { get; set; }

        private static string ConnectionString;

        // guarda string de conexão.
        //************************************************
        public static string GetConnectionString()
        {
            // recebe a string de conexão que esta no 
            // arquivo appsettings.json no .net Core
            // arquivo App.config no .net framework
            // ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=sa;Database=emanager_dev;";  
            //************************************************         
            ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.Trim(); 

            return ConnectionString;
            //return "Server=localhost;Port=5432;User Id=postgres;Password=sa;Database=emanager_dev;";  // connectionStrings.Value.ConnectionString1;

        }


    }
}
