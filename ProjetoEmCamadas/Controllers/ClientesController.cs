﻿using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class ClientesController
    {
        private static List<Cliente> listaClientes = new List<Cliente>();

        public void Adicionar(string nome, string cpf)
        {
            Cliente cli = new Cliente();
            cli.ClienteID = listaClientes.Count + 1;
            cli.Nome = nome;
            cli.Cpf = cpf;

            listaClientes.Add(cli);
        }

        private Cliente BuscaPorID(int id) {
            foreach (Cliente cli in listaClientes)
            {
                if (cli.ClienteID == id)
                {
                    return cli;
                }
            }
            return null;
        }

        public Cliente Detalhes(int id)
        {
            return BuscaPorID(id); 
        }

        public bool Editar(int id, string novoNome, string novoCPF)
        {
            Cliente c = BuscaPorID(id);

            if (c != null) {
                c.Nome = novoNome;
                c.Cpf = novoCPF;
                return true;
            }
            return false;

        }

        public void Excluir(int id)
        {
            foreach (Cliente cli in listaClientes)
            {
                if (cli.ClienteID == id)
                {
                    listaClientes.Remove(cli);
                }
            }
        }

        public List<Cliente> Listar()
        {
            return listaClientes;
        }
    }
}
