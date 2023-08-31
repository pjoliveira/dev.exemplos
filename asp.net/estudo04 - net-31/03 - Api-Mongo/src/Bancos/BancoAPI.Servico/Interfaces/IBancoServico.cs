using BancoAPI.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancoAPI.Servico.Interfaces
{
    /// <summary>
    /// Interface para os SERVICES do APPLICATION
    /// </summary>
    public interface IBancoServico
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
        /// Metodo para buscar por ID
        /// </summary>
        /// <returns>Dados da ID correpondente</returns>
        Task<BancoEntidade> GetCodigo(string codigo);

        /// <summary>
        /// Metodo para buscar por nome
        /// </summary>
        /// <returns>Dados da ID correpondente</returns>
        Task<BancoEntidade> GetNome(string nome);
        
        /// <summary>
        /// Metodo para verificar se existe o ID
        /// </summary>
        /// <returns>True ou False</returns>
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
        Task<long> Delete(string codigo);
        
    }
}
