using Controller.Interface;
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
    public class MercadoController : ICrud<Mercado>
    {
        private MoedaController moedaController = new MoedaController();
        public void AdicionarItem(Mercado mercado)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Mercados.Add(mercado);
                contexto.SaveChanges();
            } 
        }

        public void RemoverItem(Mercado mercado)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Entry(mercado).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public ICollection<Mercado> RetornarTodos()
        {
            using (Contexto contexto = new Contexto())
            {
                return contexto.Mercados.ToList();
            }
        }

        // Cadastra os produtos achados na API no Banco de Dados
        public void BuscaECadastraProduto(string Produto, int ProdutoId)
        {
            using (Contexto contexto = new Contexto())
            {
                var DadosProduto = BuscarDadosProduto(Produto);

                // TODO: Verificar conexao de internet antes de se conectar a internet

                // Busca o ultimo valor do EURO em relação ao REAL
                float ValorEuro = moedaController.BuscarMoedaPorId(1).Valor;

                // Pra cada produto existente no resultado, cadastra o seu valor para o respectivo mercado
                foreach (dynamic d in DadosProduto)
                {
                    // Caso o valor de venda do produto seja zero, é inútil pra nós, não cadastra
                    if (!d.ProductUpdates[0].SalePrice.Equals(0))
                    {
                        float PrecoReais = d.ProductUpdates[0].SalePrice * ValorEuro;
                        string Mercado = d.ProductUpdates[0].Provider.Name;

                        MercadoProduto mercadoProduto = new MercadoProduto();
                        mercadoProduto.Preco = PrecoReais;
                        mercadoProduto.ProdutoId = ProdutoId;
                        mercadoProduto.DataAtualizacao = Util.BuscarDataHoraAtual();

                        // Achar chave estrangeira do mercado baseada no nome
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
                    // Salva dados no banco depois de achar todos os produtos com valor
                    contexto.SaveChanges();
                }
            }
        }

        // Retorna lista com objetos encontrados na API de mercados 
        private static dynamic BuscarDadosProduto(string Produto)
        {
            using (Contexto contexto = new Contexto())
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
        }

        // Limpa a base de preços 
        public static void LimpaBaseDePrecos()
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Database.ExecuteSqlCommand("Delete From MercadoProdutoes");
            }  
        }

        // Busca data de atualização do último registro, para verificarmos qual foi a ultima data de atualização
        public static string RetornaHoraUltimaAtualizacao()
        {
            using (Contexto contexto = new Contexto())
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
}
