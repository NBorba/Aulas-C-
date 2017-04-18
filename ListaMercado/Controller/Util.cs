using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Util
    {

        public static float BuscaValorEuro()
        {
            string resultadoString = "";

            using (var clienteWeb = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                clienteWeb.BaseAddress = new Uri("http://api.fixer.io/");
                HttpResponseMessage resposta = clienteWeb.GetAsync("latest?symbols=BRL").Result;
                resposta.EnsureSuccessStatusCode();
                resultadoString = resposta.Content.ReadAsStringAsync().Result;
            }

            ApiMoeda resultadoObjeto = JsonConvert.DeserializeObject<ApiMoeda>(resultadoString);

            return resultadoObjeto.rates.BRL;
        }
    }
}
