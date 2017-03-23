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
            if (cliController.Listar().Count > 0) 
            { 
                int idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value);

                frmDetalhesCliente frmDetCli = new frmDetalhesCliente(idSelecionado);
                frmDetCli.ShowDialog();

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = cliController.Listar();
            }
        }
    }
}
