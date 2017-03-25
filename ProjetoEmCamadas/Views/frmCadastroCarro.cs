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
    public partial class frmCadastroCarro : Form
    {
        CarroController carroController = new CarroController();

        public frmCadastroCarro()
        {
            InitializeComponent();
        }

        private void frmCadastroCarro_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                carroController.Cadastrar(txtModelo.Text, Convert.ToInt32(txtAno.Text));
                MessageBox.Show("Cliente cadastrado com sucesso!");
                fechaTela();
            }
            else
            {
                MessageBox.Show("Os dois campos devem estar preenchidos!");
            }
        }

        private bool Validar()
        {
            return !string.IsNullOrEmpty(txtAno.Text.Trim()) && !string.IsNullOrEmpty(txtModelo.Text.Trim());
        }

        private void fechaTela()
        {
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fechaTela();
        }
    }
}
