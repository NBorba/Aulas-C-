using ListaMercado.Lista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaMercado
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroLista formCadastroLista = new FormCadastroLista();
            formCadastroLista.MdiParent = this;
            formCadastroLista.Show();
        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListagemListas formListagemListas = new FormListagemListas();
            formListagemListas.MdiParent = this;
            formListagemListas.Show();
        }
    }
}
