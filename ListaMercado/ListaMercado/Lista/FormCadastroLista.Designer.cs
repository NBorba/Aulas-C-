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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.comboBoxCategoriaProdutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAdicionados = new System.Windows.Forms.DataGridView();
            this.Remover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNomeLista = new System.Windows.Forms.TextBox();
            this.lblDivider = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionados)).BeginInit();
            this.SuspendLayout();
            // 
            // listProdutos
            // 
            this.listProdutos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.Location = new System.Drawing.Point(92, 111);
            this.listProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(170, 433);
            this.listProdutos.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(335, 310);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(97, 20);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar item ";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Location = new System.Drawing.Point(962, 558);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(130, 25);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // comboBoxCategoriaProdutos
            // 
            this.comboBoxCategoriaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoriaProdutos.FormattingEnabled = true;
            this.comboBoxCategoriaProdutos.Location = new System.Drawing.Point(77, 82);
            this.comboBoxCategoriaProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategoriaProdutos.Name = "comboBoxCategoriaProdutos";
            this.comboBoxCategoriaProdutos.Size = new System.Drawing.Size(185, 21);
            this.comboBoxCategoriaProdutos.TabIndex = 12;
            this.comboBoxCategoriaProdutos.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoriaProdutos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Categoria";
            // 
            // dgvAdicionados
            // 
            this.dgvAdicionados.AllowUserToAddRows = false;
            this.dgvAdicionados.AllowUserToDeleteRows = false;
            this.dgvAdicionados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAdicionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdicionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remover});
            this.dgvAdicionados.Location = new System.Drawing.Point(504, 111);
            this.dgvAdicionados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAdicionados.Name = "dgvAdicionados";
            this.dgvAdicionados.RowTemplate.Height = 28;
            this.dgvAdicionados.Size = new System.Drawing.Size(342, 437);
            this.dgvAdicionados.TabIndex = 17;
            this.dgvAdicionados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdicionados_CellContentClick);
            // 
            // Remover
            // 
            this.Remover.HeaderText = "Remover";
            this.Remover.Name = "Remover";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 20);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "De um nome a sua lista:";
            // 
            // txtNomeLista
            // 
            this.txtNomeLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLista.Location = new System.Drawing.Point(194, 11);
            this.txtNomeLista.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeLista.Name = "txtNomeLista";
            this.txtNomeLista.Size = new System.Drawing.Size(343, 26);
            this.txtNomeLista.TabIndex = 19;
            // 
            // lblDivider
            // 
            this.lblDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDivider.Location = new System.Drawing.Point(-3, 46);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(1106, 2);
            this.lblDivider.TabIndex = 20;
            // 
            // FormCadastroLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 594);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.txtNomeLista);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvAdicionados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategoriaProdutos);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listProdutos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroLista";
            this.Text = "Cadastro de Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox comboBoxCategoriaProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAdicionados;
        private System.Windows.Forms.DataGridViewButtonColumn Remover;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNomeLista;
        private System.Windows.Forms.Label lblDivider;
    }
}