using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ViacepAPI.Servico
{
    /// <summary>
    ///    Classe RestClient, pra buscar o CEP
    /// </summary>
    class RestClient
    {
        public string EndPoint { get; set; }
        public httpVerb HttpMethod { get; set; }

        private HttpWebRequest request;

        public RestClient()
        {
            EndPoint = string.Empty;
            HttpMethod = httpVerb.GET;
        }

        /// <summary>
        ///    metodo que executa o Request
        /// </summary>
        public void Request(string cCEP)
        {

            request = WebRequest.Create(EndPoint + cCEP + "/json") as HttpWebRequest;

            request.Method = HttpMethod.ToString();

        }

        /// <summary>
        ///    metodo para obetar o GetResponse
        /// </summary>
        public async Task<string> ResponseAsync()
        {
            string ResponseValue = string.Empty;

            using (HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse)
            {

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode);
                }

                using Stream responseStream = response.GetResponseStream();
                if (responseStream != null)
                {
                    using StreamReader reader = new StreamReader(responseStream);
                    ResponseValue = reader.ReadToEnd();

                }

            }

            return ResponseValue;

        }
    }
}
