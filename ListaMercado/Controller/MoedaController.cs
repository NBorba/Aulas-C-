using Model;
using Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MoedaController
    {
        // Busca valor da moeda e cadastra no banco
        public void AtualizaPrecoMoeda(string Nome) 
        {
            // Instancia nova moeda
            Moeda moeda = new Moeda();
            moeda.NomeMoeda = Nome;

            // Busca todas as moedas
            ICollection<Moeda> moedas = RetornaMoedasCadastradas();
           
            using (Contexto contexto = new Contexto()) 
            {
                switch(moeda.NomeMoeda)
                { 
                    case "Euro":
                        // Se achar alguma moeda
                        if (moedas.Count > 0)
                        {
                            foreach (Moeda m in moedas)
                            {
                                // Se achar alguma moeda "Euro" cadastrada no Banco
                                if (m.NomeMoeda == "Euro")
                                {
                                    // Atualiza o item já cadastrado
                                    m.Valor = Util.BuscaValorEuro();
                                    m.DataAtualizacao = Util.BuscarDataHoraAtual();
                                    contexto.Entry(m).State = System.Data.Entity.EntityState.Modified;
                                }
                            }   
                        }
                        // Se não achar, cadastra uma moeda nova
                        else
                        {
                            moeda.Valor = Util.BuscaValorEuro();
                            moeda.DataAtualizacao = Util.BuscarDataHoraAtual();
                            contexto.Moeda.Add(moeda);
                        }
                        break;
                }
                contexto.SaveChanges();
            }
        }

        public ICollection<Moeda> RetornaMoedasCadastradas() 
        {
            using (Contexto contexto = new Contexto())
            {
                ICollection<Moeda> moedas = contexto.Moeda.ToList();
                return moedas;
            } 
        }

        public Moeda BuscarMoedaPorId(int Id) 
        {
            using (Contexto contexto = new Contexto()) 
            {
                return contexto.Moeda.Find(Id); 
            }
        }
    }
}
