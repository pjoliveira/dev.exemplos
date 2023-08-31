using BancoAPI.Dominio.Entidades;
using MongoDB.Driver;

namespace BancoAPI.InfraData.Contexto
{
    public interface ISistemaContexto
    {
        
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        IMongoCollection<BancoEntidade> BancoColecao { get; }
        //IMongoCollection<TDocument> GetMongoColecao { get; }

    }
}
