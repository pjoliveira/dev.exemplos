using System.Threading.Tasks;
using ViacepAPI.Respostas;

namespace ViacepAPI.ServicoInterfaces
{
    /// <summary>
    /// Interface 
    /// </summary>
    public interface IViacepServico
    {

        Task<string> GetCEPjson(string cCEP);

        Task<ViacepResposta> GetCEPmodel(string cCEP);



    }
}
