using System.Collections.Generic;
using System.Threading.Tasks;
using BancoAPI.Dominio.Entidades;

namespace BancoAPI.Dominio.RepositorioInterfaces
{
    /// <summary>
    /// Interface para os repositorios de dados
    /// </summary>
    public interface IBancoRepositorio
    {
        /// <summary>
        /// Metodo para Lista dos dados
        /// </summary>
        /// <returns>Lista com os dados</returns>
        Task<IEnumerable<BancoEntidade>> GetLista();
        
        /// <summary>
        /// Metodo para buscar por ID
        /// </summary>
        /// <returns>Dados da ID correpondente</returns>
        Task<BancoEntidade> GetId(string id);

        /// <summary>
        /// Metodo para buscar por codigo
        /// </summary>
        /// <returns>Dados da codigo correpondente</returns>
        Task<BancoEntidade> GetCodigo(string codigo);

        /// <summary>
        /// Metodo para buscar por codigo
        /// </summary>
        /// <returns>Dados da codigo correpondente</returns>
        Task<BancoEntidade> GetNome(string nome);

        /// <summary>
        /// Metodo para verificar se ja exsite o ID
        /// </summary>
        /// <returns>Dados da ID correpondente</returns>
        Task<bool> ExisteCodigo(string codigo);

        /// <summary>
        /// Metodo adcionar registros
        /// </summary>
        /// <returns>inteiro </returns>
        Task Add(BancoEntidade item);

        /// <summary>
        /// Metodo de update de registros
        /// </summary>
        /// <returns>inteiro </returns>
        Task<long> Update(BancoEntidade item);

        /// <summary>
        /// Metodo para deletar registros
        /// </summary>
        /// <returns>inteiro </returns>
        Task<long> Delete(string id); 


    }
}
