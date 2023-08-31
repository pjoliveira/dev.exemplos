using BancosAPI.Servico.Respostas;
using BancosAPI.Servico.Resultado;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancosAPI.Servico.Interfaces
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
        Task<IEnumerable<BancoResposta>> GetLista();    

        /// <summary>
        /// Metodo para verificar se existe o ID
        /// </summary>
        /// <returns>True ou False</returns>
        Task<bool> ExistID(string codigo);

        /// <summary>
        /// Metodo para buscar por ID
        /// </summary>
        /// <returns>Dados da ID correpondente</returns>
        Task<BancoResposta> GetID(string codigo);

        /// <summary>
        /// Metodo adcionar registros
        /// </summary>
        /// <returns>inteiro </returns>
        Task<int> Add(BancoResposta item);

        /// <summary>
        /// Metodo de update de registros
        /// </summary>
        /// <returns>inteiro </returns>
        Task<int> Update(BancoResposta item);

        /// <summary>
        /// Metodo para deletar registros
        /// </summary>
        /// <returns>inteiro </returns>
        Task<int> Delete(string codigo);

    }
}
