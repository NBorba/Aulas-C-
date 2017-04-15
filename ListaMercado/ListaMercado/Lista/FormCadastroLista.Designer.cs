namespace ListaMercado.Lista
{
    partial class FormCadastroLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listAdicionados = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProdutos
            // 
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.ItemHeight = 20;
            this.listProdutos.Location = new System.Drawing.Point(21, 129);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(253, 584);
            this.listProdutos.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(331, 373);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(145, 31);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar item ";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remover item";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listAdicionados
            // 
            this.listAdicionados.FormattingEnabled = true;
            this.listAdicionados.ItemHeight = 20;
            this.listAdicionados.Location = new System.Drawing.Point(527, 129);
            this.listAdicionados.Name = "listAdicionados";
            this.listAdicionados.Size = new System.Drawing.Size(253, 584);
            this.listAdicionados.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(374, 52);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Escolher produtos";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(12, 746);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(750, 20);
            this.lblObservacao.TabIndex = 5;
            this.lblObservacao.Text = "Observacao:  Para aumentar a quantidade do mesmo item na lista clique em \"Adicion" +
    "ar item\"";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(590, 791);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cadastrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormCadastroLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 854);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.listAdicionados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listProdutos);
            this.Name = "FormCadastroLista";
            this.Text = "Cadastro de Lista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listAdicionados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button button3;
    }
}