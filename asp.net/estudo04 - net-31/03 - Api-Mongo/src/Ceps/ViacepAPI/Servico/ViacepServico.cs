using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using ViacepAPI.Respostas;
using ViacepAPI.ServicoInterfaces;

namespace ViacepAPI.Servico
{
    /// <summary>
    /// BancosAPI.Servico
    /// </summary>
    public class ViacepServico : IViacepServico
    {

        /// <summary>
        /// contrutor da classe BancoService
        /// </summary>
        public ViacepServico()
        {


        }

        public async Task<string> GetCEPjson(string cCEP)
        {
            //
            RestClient client = new RestClient
            {
                EndPoint = "http://viacep.com.br/ws/"
            };

            client.Request(cCEP);

            var RetResponse = await client.ResponseAsync();

            return RetResponse;

        }

        public async Task<ViacepResposta> GetCEPmodel(string cCEP)
        {
            //
            RestClient client = new RestClient
            {
                EndPoint = "http://viacep.com.br/ws/"
            };

            client.Request(cCEP);

            var RetResponse = await client.ResponseAsync();

            ViacepResposta cep = JsonSerializer.Deserialize<ViacepResposta>(RetResponse);

            return cep;

        }


    }
}
