using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CarroController
    {
        public static BindingList<Carro> listaCarros = new BindingList<Carro>();

        public BindingList<Carro> retornaLista() {
            return listaCarros;
        }

        public void Cadastrar(string modelo, int ano)
        {
            Carro c = new Carro();
            c.CarroID = listaCarros.Count + 1;
            c.Modelo = modelo;
            c.Ano = ano;

            listaCarros.Add(c);
        }

        public void Editar(int id, string novoModelo, int novoAno)
        {
            Carro carro = buscaPorId(id);

            if (carro != null)
            {
                carro.Modelo = novoModelo;
                carro.Ano = novoAno;
            }
        }

        public void Excluir(int id)
        {
            foreach (Carro carro in listaCarros)
            {
                if (carro.CarroID == id)
                {
                    listaCarros.Remove(carro);
                    break;
                }
            }
        }

        public void detalhesCarro(int id)
        {
            buscaPorId(id);
        }

        private Carro buscaPorId(int id) 
        {
            foreach (Carro carro in listaCarros)
            {
                if (carro.CarroID == id)
                {
                    return carro;
                }
            }
            return null;
        }
    }
}
