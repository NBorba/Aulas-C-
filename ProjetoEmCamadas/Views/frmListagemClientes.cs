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
    public partial class frmListagemClientes : Form
    {
        ClientesController cliController = new ClientesController();
       
        public frmListagemClientes()
        {
            InitializeComponent();
        }

        private void frmListagemClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = cliController.Listar();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value);

            if (e.ColumnIndex == 0)
            {
                DialogResult result = MessageBox.Show("Você deseja excluir o cliente?","Excluir",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);

                if (result.Equals(DialogResult.OK))
                {                
                    cliController.Excluir(idSelecionado);
                    MessageBox.Show("Cliente excluido com sucesso!");
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = cliController.Listar();
                }
                
                
            }

            // Botão Editar
            if (e.ColumnIndex == 1)
            {
                if (cliController.Listar().Count > 0)
                {
                    frmDetalhesCliente frmDetCli = new frmDetalhesCliente(idSelecionado);
                    frmDetCli.ShowDialog();

                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = cliController.Listar();
                }
            }
        }
    }
}
