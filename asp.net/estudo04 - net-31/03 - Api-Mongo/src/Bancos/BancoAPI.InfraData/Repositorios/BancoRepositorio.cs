using BancoAPI.Dominio.Entidades;
using BancoAPI.Dominio.RepositorioInterfaces;
using BancoAPI.InfraData.Contexto;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace BancoAPI.InfraData.Repositorios
{
    /// <summary>
    /// Classe dos Repositorios de dados
    /// </summary>
    public class BancoRepositorio : IBancoRepositorio
    {
        private readonly ISistemaContexto _contexto;
        
        public BancoRepositorio(ISistemaContexto contexto)
        {

            _contexto = contexto;
            
        }

        public async Task<IEnumerable<BancoEntidade>> GetLista()
        {
            var list = await _contexto.BancoColecao.Find(_ => true).ToListAsync(); 

            return list;
        }

        public async Task<BancoEntidade> GetId(string id)
        {

            return await _contexto.BancoColecao.Find(b => b.Id == id).FirstOrDefaultAsync();

        }

        public async Task<BancoEntidade> GetCodigo(string codigo)
        {

            return await _contexto.BancoColecao.Find(b => b.Codigo == codigo).FirstOrDefaultAsync();

        }

        public async Task<BancoEntidade> GetNome(string nome)
        {

            FilterDefinition<BancoEntidade> filter = Builders<BancoEntidade>.Filter.Eq(p => p.Nome, nome);
            return await _contexto.BancoColecao.Find(filter).FirstOrDefaultAsync();

        }

        public async Task<bool> ExisteCodigo(string codigo)
        {

            return await _contexto.BancoColecao.Find(b => b.Codigo == codigo).AnyAsync();

        }

        public async Task Add(BancoEntidade item)
        {
            
            await _contexto.BancoColecao.InsertOneAsync(item);


        }
        public async Task<long> Update(BancoEntidade item)
        {

            ReplaceOneResult updateResult = await _contexto.BancoColecao.ReplaceOneAsync(filter: g => g.Id == item.Id, replacement: item);           
            return updateResult.ModifiedCount;

        }

        public async Task<long> Delete(string id)
        {
            
            FilterDefinition<BancoEntidade> filter = Builders<BancoEntidade>.Filter.Eq(p => p.Id, id);
            DeleteResult deleteResult = await _contexto.BancoColecao.DeleteOneAsync(filter);
            
            return deleteResult.DeletedCount;

        }

       
        
    }

}
