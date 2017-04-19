using Model;
using Model.DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace Controller
{
    public class MercadoController
    {
        private static Contexto contexto = new Contexto();

        public void CadastrarMercadoBanco(string Nome)
        {
            Mercado mercado = new Mercado();
            mercado.MercadoNome = Nome;

            contexto.Mercados.Add(mercado);
            contexto.SaveChanges();
        }

        public ICollection<Mercado> RetornaMercadosCadastradosBanco()
        {
            return contexto.Mercados.ToList();
        }

        private static dynamic BuscarDadosProduto(string Produto)
        {
            string resultadoString = "";

            // TODO: Verificar conexao de internet antes de se conectar a internet

            // Retorna resposta de API de Mercados
            using (var clienteWeb = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                clienteWeb.BaseAddress = new Uri("https://maiscarrinho.com/api/");
                HttpResponseMessage resposta = clienteWeb.GetAsync("search?q=" + Produto).Result;
                resposta.EnsureSuccessStatusCode();
                resultadoString = resposta.Content.ReadAsStringAsync().Result;
            }

            // Realiza o Parse
            Api resultadoObjeto = JsonConvert.DeserializeObject<Api>(resultadoString);

            // Retorna os resultados da busca na api
            return resultadoObjeto.results;
        }

        // Cadastra os produtos achados na API no Banco de Dados
        public static void BuscaECadastraProduto(string Produto, int ProdutoId)
        {
            using (Contexto ctx = new Contexto()) { 
                var DadosProduto = BuscarDadosProduto(Produto);

                // Busca o ultimo valor do EURO em relação ao REAL
                // TODO: Verificar conexao de internet antes de se conectar a internet
                float ValorEuro = Util.BuscaValorEuro();

                // Pra cada produto existente no resultado, cadastra o seu valor para o respectivo mercado
                foreach (dynamic d in DadosProduto)
                {
                    // Caso o valor de venda do produto seja zero, é inútil pra nós, não cadastra
                    if (!d.ProductUpdates[0].SalePrice.Equals(0)) { 
                        float PrecoReais = d.ProductUpdates[0].SalePrice * ValorEuro;
                        string Mercado = d.ProductUpdates[0].Provider.Name;

                        MercadoProduto mercadoProduto = new MercadoProduto();
                        mercadoProduto.Preco = PrecoReais;
                        mercadoProduto.ProdutoId = ProdutoId;
                        mercadoProduto.DataAtualizacao = Util.BuscarDataHoraAtual();

                        // Achar chave estrangeira do mercado
                        switch (Mercado)
                        {
                            case "Jumbo":
                                mercadoProduto.MercadoId = 1;
                                break;
                            case "Continente":
                                mercadoProduto.MercadoId = 2;
                                break;
                            case "Intermarche":
                                mercadoProduto.MercadoId = 3;
                                break;
                            case "Pingo":
                                mercadoProduto.MercadoId = 4;
                                break;
                        }
                        contexto.MercadoProduto.Add(mercadoProduto);
                    }
                }
                // Salva dados no banco depois de achar todos os produtos com valor
                contexto.SaveChanges();
            }
        }

        public static void LimpaBaseDePrecos()
        {
            contexto.Database.ExecuteSqlCommand("Delete From MercadoProdutoes");
        }

        // Busca data de atualização do último registro
        public static string RetornaHoraUltimaAtualizacao()
        {
            MercadoProduto MercadoProduto = contexto.MercadoProduto.OrderByDescending(hr => hr.DataAtualizacao).FirstOrDefault();
            
            if (MercadoProduto != null)
            {
                return MercadoProduto.DataAtualizacao;
            }

            return null;
        }
    }
}
