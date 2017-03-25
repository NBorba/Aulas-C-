using Controllers;
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
    public partial class frmListagemCarro : Form
    {
        CarroController carroController = new CarroController();

        public frmListagemCarro()
        {
            InitializeComponent();
        }

        private void dgvCarros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value);

            if (e.ColumnIndex == 0) {

            }
        }

        private void frmListagemCarro_Load(object sender, EventArgs e)
        {
            dgvCarros.DataSource = carroController.retornaLista();
        }
    }
}
