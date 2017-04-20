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
        private FormPrincipal formPrincipalReferencia;
        private MercadoController mercadoController = new MercadoController();

        public FormVisualizarLista(int Id, EnumAcao Acao, FormPrincipal formPrincipal)
        {
            InitializeComponent();

            AcaoUsuario = Acao;
            IdLista = Id;
            formPrincipalReferencia = formPrincipal;

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

            formPrincipalReferencia.DefineTextoHoraAtualizacao();
        }

        delegate void CallbackTexto(string text);

        private void TituloLabelCarregamento(string texto)
        {
            // InvokeRequired compara o ID da thread chamadora
            // com o ID thread criadora
            // Se as threads são diferentes retorna true
            if (this.lblCarregando.InvokeRequired)
            {
                CallbackTexto d = new CallbackTexto(TituloLabelCarregamento);
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
            mercadoController.BuscaECadastraProduto("Picanha", 1);
            mercadoController.BuscaECadastraProduto("Frango", 2);
            mercadoController.BuscaECadastraProduto("Peixe", 3);
            mercadoController.BuscaECadastraProduto("Hamburguer", 4);
            mercadoController.BuscaECadastraProduto("Arroz", 5);
            mercadoController.BuscaECadastraProduto("Feijao", 6);
            mercadoController.BuscaECadastraProduto("Sal", 7);
            mercadoController.BuscaECadastraProduto("Sabao", 8);
            mercadoController.BuscaECadastraProduto("Pasta%de%dente", 9);
            mercadoController.BuscaECadastraProduto("Papel%higienico", 10);
            mercadoController.BuscaECadastraProduto("Sabonete", 11);
            mercadoController.BuscaECadastraProduto("Escova%de%dente", 12);
            mercadoController.BuscaECadastraProduto("Detergente", 13);
            mercadoController.BuscaECadastraProduto("Lixivia", 14); // Água sanitária
            mercadoController.BuscaECadastraProduto("Shampoo", 15);
            mercadoController.BuscaECadastraProduto("Dezodorizante", 16); // Desodorante
            mercadoController.BuscaECadastraProduto("Leite%Condensado", 17);
            mercadoController.BuscaECadastraProduto("Margarina", 18);
        
            // Atualização de carregamento
            TituloLabelCarregamento("Quase lá! Aguarde enquanto buscamos os preços pra você!");

            mercadoController.BuscaECadastraProduto("Requeijao", 19);
            mercadoController.BuscaECadastraProduto("Leite", 20);
            mercadoController.BuscaECadastraProduto("Pão", 21);
            mercadoController.BuscaECadastraProduto("Creme%de%leite", 22);
            mercadoController.BuscaECadastraProduto("Oleo", 23);
            mercadoController.BuscaECadastraProduto("Azeite", 24);
            mercadoController.BuscaECadastraProduto("Macarrao", 25);
            mercadoController.BuscaECadastraProduto("Massa%lasanha", 26);
            mercadoController.BuscaECadastraProduto("Molho%de%tomate", 27);
            mercadoController.BuscaECadastraProduto("Chocolate%em%po", 28);
            
            mercadoController.BuscaECadastraProduto("Barra%de%chocolate", 29);
            mercadoController.BuscaECadastraProduto("Farinha%de%trigo", 30);
            mercadoController.BuscaECadastraProduto("Acucar", 31);
            mercadoController.BuscaECadastraProduto("Adocante", 32);
            mercadoController.BuscaECadastraProduto("Refrigerante", 33);
        
            // Atualização de carregamento
            TituloLabelCarregamento("Finalizando busca...");

            mercadoController.BuscaECadastraProduto("Sumo", 34);
            mercadoController.BuscaECadastraProduto("Agua", 35);
            mercadoController.BuscaECadastraProduto("Cerveja", 36);
        }
    }
}
