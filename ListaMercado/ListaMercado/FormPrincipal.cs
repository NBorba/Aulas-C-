using Controller;
using ListaMercado.Lista;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Model;

namespace ListaMercado
{
    public partial class FormPrincipal : Form
    {
        private MoedaController moedaController = new MoedaController();
        private BackgroundWorker bw = new BackgroundWorker();

        public FormPrincipal()
        {
            InitializeComponent();

            // Busca o preço do euro
            moedaController.AtualizaPrecoMoeda("Euro");

            // Mostra no toolStrip as datas de atualização do texto
            DefineTextoHoraAtualizacao();
        }

        protected override void OnLoad(EventArgs e) {
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(HandleDoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(HandleWorkCompleted);
            bw.RunWorkerAsync();
             
            // Mostra a label de loading enquanto processa
            lblCarregando.Show();

            // Desabilita o uso do menu enquanto carrega
            menu.Enabled = false; 
        }

        private void HandleWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblCarregando.Hide();
            menu.Enabled = true;
        }

        private void HandleDoWork(object sender, DoWorkEventArgs e)
        {
            // DO Any work to instantiate the form
            System.Threading.Thread.Sleep(100);

            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                CategoriaController.RetornaCategoriasBanco();
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroLista formCadastroLista = new FormCadastroLista();
            formCadastroLista.MdiParent = this;
            formCadastroLista.Show();
            formCadastroLista.WindowState = FormWindowState.Maximized;
        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListagemListas formListagemListas = new FormListagemListas(this);
            formListagemListas.MdiParent = this;
            formListagemListas.Show();
            formListagemListas.WindowState = FormWindowState.Maximized;
        }

        public void DefineTextoHoraAtualizacao()
        {
            string HoraAtualizacaoPrecos = MercadoController.RetornaHoraUltimaAtualizacao();

            if(HoraAtualizacaoPrecos != null) {
                toolTipoHoraAtualizacao.Text = HoraAtualizacaoPrecos;
            }

            Moeda moeda = moedaController.BuscarMoedaPorId(1);

            if (moeda != null) { 
                float PrecoMoeda = moeda.Valor;
                string HoraAtualizacaoMoeda = moeda.DataAtualizacao;
                toolStripPrecoEuro.Text = PrecoMoeda.ToString();
                toolStripHoraCotacao.Text = HoraAtualizacaoMoeda;
            }
        }
    }
}
