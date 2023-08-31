using BancoAPI.Dominio.Entidades;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace BancoAPI.InfraData.Contexto
{
    public class SistemaContexto : ISistemaContexto
    {
        //Definir propriedades 
        //****************************************************************************        
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public IMongoCollection<BancoEntidade> BancoColecao { get; }

        public SistemaContexto(IConfiguration configuration)
        {

            ConnectionString = configuration.GetSection("DatabaseSettings:ConnectionString").Value;
            DatabaseName = configuration.GetSection("DatabaseSettings:DatabaseName").Value;
            CollectionName = configuration.GetSection("DatabaseSettings:CollectionName").Value;

            //MongoClient: estabelecer a conexão com o servidor MongoDB, através da string de coenxão.
            var client = new MongoClient(ConnectionString);

            //MongoClient.GetDatabase: obter o banco de dados no MongoDB.
            var database = client.GetDatabase(DatabaseName);

            //IMongoDatabase.GetCollection<T>: obter a coleção de dados do tipo T
            BancoColecao = database.GetCollection<BancoEntidade>(CollectionName);

            //BancoColecao.Find(p => true).ToListAsync(); 
            //CatalogContextSeed.SeedData(Bancos);// alimentar coleção
        }







    }
}

