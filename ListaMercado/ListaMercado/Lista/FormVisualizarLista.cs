using Controller;
using System.ComponentModel;
using System.Windows.Forms;

namespace ListaMercado.Lista
{
    public partial class FormVisualizarLista : Form
    {
        private int IdLista;
        private ListaController listaController = new ListaController();
        private EnumAcao AcaoUsuario;
        private BackgroundWorker bw = new BackgroundWorker();

        public FormVisualizarLista(int Id, EnumAcao Acao)
        {
            InitializeComponent();

            AcaoUsuario = Acao;
            IdLista = Id;

            // Libera componentes específicos para cada ação
            ControleDeComponentes();

            lblTitulo.Text = listaController.RetornaListaEspecifica(IdLista).ListaCompraNome.ToString();
            dgvProdutos.DataSource = listaController.RetornaProdutosListaBanco(IdLista);
        }

        private void ControleDeComponentes()
        {
            switch (AcaoUsuario)
            {
                case EnumAcao.Visualizar:
                    break;

                case EnumAcao.CompararPreco:
                    bw.WorkerReportsProgress = true;
                    bw.WorkerSupportsCancellation = true;
                    bw.DoWork += new DoWorkEventHandler(HandleDoWork);
                    bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(HandleWorkerCompleted);
                    bw.RunWorkerAsync();

                    // Mostra a label de loading enquanto processa
                    lblCarregando.Show();
                    lblDivider.Visible = false;
                    lblTitulo.Visible = false;
                    lblTituloProdutos.Visible = false;
                    dgvProdutos.Visible = false;
                    break;
            }
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
                BuscaProdutosMercados();
            }
        }

        private void HandleWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblCarregando.Hide();
            lblDivider.Visible = true;
            lblTitulo.Visible = true;
            lblTituloProdutos.Visible = true;
            dgvProdutos.Visible = true;
        }

        delegate void SetTextCallback(string text);

        private void TituloLabelCarregamento(string texto)
        {
            // InvokeRequired compara o ID da thread chamadora
            // com o ID thread criadora
            // Se as threads são diferentes retorna true
            if (this.lblCarregando.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(TituloLabelCarregamento);
                this.Invoke(d, new object[] { texto });
            }
            else
            {
                this.lblCarregando.Text = texto;
            }
        }

        private void BuscaProdutosMercados()
        {
            // Seta o texto da label de carregamento
            TituloLabelCarregamento("Buscando preços... Por favor aguarde");

            // TODO: Verificar conexao de internet antes de buscar dados da API

            // Limpa base de preços para poder atualizar os produtos
            MercadoController.LimpaBaseDePrecos();

            // String de busca na API de preços e id do produto que está sendo cadastrado
            MercadoController.BuscaECadastraProduto("Picanha", 1);
            MercadoController.BuscaECadastraProduto("Frango", 2);
            MercadoController.BuscaECadastraProduto("Peixe", 3);
            MercadoController.BuscaECadastraProduto("Hamburguer", 4);
            MercadoController.BuscaECadastraProduto("Arroz", 5);
            MercadoController.BuscaECadastraProduto("Feijao", 6);
            MercadoController.BuscaECadastraProduto("Sal", 7);
            MercadoController.BuscaECadastraProduto("Sabao", 8);
            MercadoController.BuscaECadastraProduto("Pasta%de%dente", 9);
            MercadoController.BuscaECadastraProduto("Papel%higienico", 10);
            MercadoController.BuscaECadastraProduto("Sabonete", 11);
            MercadoController.BuscaECadastraProduto("Escova%de%dente", 12);
            MercadoController.BuscaECadastraProduto("Detergente", 13);
            MercadoController.BuscaECadastraProduto("Lixivia", 14); // Água sanitária
            MercadoController.BuscaECadastraProduto("Shampoo", 15);
            MercadoController.BuscaECadastraProduto("Dezodorizante", 16); // Desodorante
            MercadoController.BuscaECadastraProduto("Leite%Condensado", 17);
            MercadoController.BuscaECadastraProduto("Margarina", 18);

            // Atualização de carregamento
            TituloLabelCarregamento("Quase lá! Aguarde enquanto buscamos os preços pra você!");

            MercadoController.BuscaECadastraProduto("Requeijao", 19);
            MercadoController.BuscaECadastraProduto("Leite", 20);
            MercadoController.BuscaECadastraProduto("Pão", 21);
            MercadoController.BuscaECadastraProduto("Creme%de%leite", 22);
            MercadoController.BuscaECadastraProduto("Oleo", 23);
            MercadoController.BuscaECadastraProduto("Azeite", 24);
            MercadoController.BuscaECadastraProduto("Macarrao", 25);
            MercadoController.BuscaECadastraProduto("Massa%lasanha", 26);
            MercadoController.BuscaECadastraProduto("Molho%de%tomate", 27);
            MercadoController.BuscaECadastraProduto("Chocolate%em%po", 28);
            MercadoController.BuscaECadastraProduto("Barra%de%chocolate", 29);
            MercadoController.BuscaECadastraProduto("Farinha%de%trigo", 30);
            MercadoController.BuscaECadastraProduto("Acucar", 31);
            MercadoController.BuscaECadastraProduto("Adocante", 32);
            MercadoController.BuscaECadastraProduto("Refrigerante", 33);

            // Atualização de carregamento
            TituloLabelCarregamento("Finalizando busca...");

            MercadoController.BuscaECadastraProduto("Sumo", 34);
            MercadoController.BuscaECadastraProduto("Agua", 35);
            MercadoController.BuscaECadastraProduto("Cerveja", 36);
        }
    }
}
