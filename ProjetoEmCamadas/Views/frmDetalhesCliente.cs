using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class frmDetalhesCliente : Form
    {
        ClientesController clienteController = new ClientesController();
        int id;
        int? idCli;

        public frmDetalhesCliente(int clienteID)
        {
            InitializeComponent();

            id = clienteID;
            idCli = 5;
            idCli = null;

            Cliente cliente = clienteController.Detalhes(clienteID);

            if (cliente != null)
            {
                lblID.Text = cliente.ClienteID.ToString();
                lblNome.Text = cliente.Nome;
                lblCPF.Text = cliente.Cpf;

                txtNome.Text = cliente.Nome;
                txtCPF.Text = cliente.Cpf;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado", "Erro");
                this.Close();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bool editou;
            
            editou = clienteController.Editar(id, txtNome.Text,txtCPF.Text);

            if (editou) {
                MessageBox.Show("Cliente editado com sucesso!", "Sucesso");
                this.Close();
            }
        }


    }
}
