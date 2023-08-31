using System.Collections.Generic;
using System.Threading.Tasks;
using BancosAPI.Dominio.Entidades;

namespace BancosAPI.Dominio.Interfaces
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
        /// Metodo para Lista dos dados com opção de filtrar
        /// </summary>
        /// <returns>Lista com os dados</returns>
        Task<IEnumerable<BancoEntidade>> GetLista(string CampoParaFiltro, string ValorParaFiltro);

        /// <summary>
        /// Metodo para buscar por ID
        /// </summary>
        /// <returns>Dados da ID correpondente</returns>
        Task<BancoEntidade> GetID(string id);

        /// <summary>
        /// Metodo para verificar se ja exsite o ID
        /// </summary>
        /// <returns>Dados da ID correpondente</returns>
        Task<bool> ExistID(string id);

        /// <summary>
        /// Metodo adcionar registros
        /// </summary>
        /// <returns>inteiro </returns>
        Task<int> Add(BancoEntidade item);

        /// <summary>
        /// Metodo de update de registros
        /// </summary>
        /// <returns>inteiro </returns>
        Task<int> Update(BancoEntidade item);

        /// <summary>
        /// Metodo para deletar registros
        /// </summary>
        /// <returns>inteiro </returns>
        Task<int> Delete(BancoEntidade item);

    }
}
