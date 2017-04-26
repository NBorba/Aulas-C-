namespace ListaMercado.Lista
{
    partial class FormVisualizarLista
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mercadoesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dadosGeraisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosGerais = new ListaMercado.Relatorios.DataSet.DadosGerais();
            this.MercadoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblTituloProdutos = new System.Windows.Forms.Label();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.reportGerais = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportTotal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mercadoesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dadosTotaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosTotais = new ListaMercado.Relatorios.DataSet.DadosTotais();
            this.mercadoesTableAdapter = new ListaMercado.Relatorios.DataSet.DadosGeraisTableAdapters.MercadoesTableAdapter();
            this.mercadoesTableAdapter1 = new ListaMercado.Relatorios.DataSet.DadosTotaisTableAdapters.MercadoesTableAdapter();
            this.lblTituloReportTotal = new System.Windows.Forms.Label();
            this.lblTituloReportGeral = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGeraisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGerais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MercadoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosTotaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosTotais)).BeginInit();
            this.SuspendLayout();
            // 
            // mercadoesBindingSource1
            // 
            this.mercadoesBindingSource1.DataMember = "Mercadoes";
            this.mercadoesBindingSource1.DataSource = this.dadosGeraisBindingSource;
            // 
            // dadosGeraisBindingSource
            // 
            this.dadosGeraisBindingSource.DataSource = this.dadosGerais;
            this.dadosGeraisBindingSource.Position = 0;
            // 
            // dadosGerais
            // 
            this.dadosGerais.DataSetName = "DadosGerais";
            this.dadosGerais.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MercadoesBindingSource
            // 
            this.MercadoesBindingSource.DataMember = "Mercadoes";
            this.MercadoesBindingSource.DataSource = this.dadosGerais;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(11, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(105, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nome da lista";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(11, 75);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowTemplate.Height = 28;
            this.dgvProdutos.Size = new System.Drawing.Size(246, 398);
            this.dgvProdutos.TabIndex = 1;
            // 
            // lblTituloProdutos
            // 
            this.lblTituloProdutos.AutoSize = true;
            this.lblTituloProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProdutos.Location = new System.Drawing.Point(8, 54);
            this.lblTituloProdutos.Name = "lblTituloProdutos";
            this.lblTituloProdutos.Size = new System.Drawing.Size(292, 15);
            this.lblTituloProdutos.TabIndex = 2;
            this.lblTituloProdutos.Text = "Sua lista de compras contém os seguintes produtos:";
            // 
            // lblDivider
            // 
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Location = new System.Drawing.Point(-19, 37);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(1500, 1);
            this.lblDivider.TabIndex = 3;
            // 
            // lblCarregando
            // 
            this.lblCarregando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarregando.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.Location = new System.Drawing.Point(0, 0);
            this.lblCarregando.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(1300, 715);
            this.lblCarregando.TabIndex = 4;
            this.lblCarregando.Text = "Por favor aguarde...";
            this.lblCarregando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCarregando.Visible = false;
            // 
            // reportGerais
            // 
            reportDataSource3.Name = "DadosGerais";
            reportDataSource3.Value = this.mercadoesBindingSource1;
            this.reportGerais.LocalReport.DataSources.Add(reportDataSource3);
            this.reportGerais.LocalReport.ReportEmbeddedResource = "ListaMercado.Relatorios.ReportGerais.rdlc";
            this.reportGerais.Location = new System.Drawing.Point(445, 75);
            this.reportGerais.Name = "reportGerais";
            this.reportGerais.Size = new System.Drawing.Size(631, 281);
            this.reportGerais.TabIndex = 5;
            this.reportGerais.Visible = false;
            // 
            // reportTotal
            // 
            reportDataSource4.Name = "DadosTotais";
            reportDataSource4.Value = this.MercadoesBindingSource;
            this.reportTotal.LocalReport.DataSources.Add(reportDataSource4);
            this.reportTotal.LocalReport.ReportEmbeddedResource = "ListaMercado.Relatorios.ReportTotal.rdlc";
            this.reportTotal.Location = new System.Drawing.Point(445, 402);
            this.reportTotal.Name = "reportTotal";
            this.reportTotal.Size = new System.Drawing.Size(631, 265);
            this.reportTotal.TabIndex = 6;
            this.reportTotal.Visible = false;
            // 
            // mercadoesBindingSource2
            // 
            this.mercadoesBindingSource2.DataMember = "Mercadoes";
            this.mercadoesBindingSource2.DataSource = this.dadosTotaisBindingSource;
            // 
            // dadosTotaisBindingSource
            // 
            this.dadosTotaisBindingSource.DataSource = this.dadosTotais;
            this.dadosTotaisBindingSource.Position = 0;
            // 
            // dadosTotais
            // 
            this.dadosTotais.DataSetName = "DadosTotais";
            this.dadosTotais.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mercadoesTableAdapter
            // 
            this.mercadoesTableAdapter.ClearBeforeFill = true;
            // 
            // mercadoesTableAdapter1
            // 
            this.mercadoesTableAdapter1.ClearBeforeFill = true;
            // 
            // lblTituloReportTotal
            // 
            this.lblTituloReportTotal.AutoSize = true;
            this.lblTituloReportTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReportTotal.Location = new System.Drawing.Point(441, 375);
            this.lblTituloReportTotal.Name = "lblTituloReportTotal";
            this.lblTituloReportTotal.Size = new System.Drawing.Size(186, 24);
            this.lblTituloReportTotal.TabIndex = 7;
            this.lblTituloReportTotal.Text = "Mercado mais barato";
            this.lblTituloReportTotal.Visible = false;
            // 
            // lblTituloReportGeral
            // 
            this.lblTituloReportGeral.AutoSize = true;
            this.lblTituloReportGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReportGeral.Location = new System.Drawing.Point(441, 45);
            this.lblTituloReportGeral.Name = "lblTituloReportGeral";
            this.lblTituloReportGeral.Size = new System.Drawing.Size(297, 24);
            this.lblTituloReportGeral.TabIndex = 8;
            this.lblTituloReportGeral.Text = "Preços dos produtos por mercado";
            this.lblTituloReportGeral.Visible = false;
            // 
            // FormVisualizarLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 715);
            this.Controls.Add(this.lblTituloReportGeral);
            this.Controls.Add(this.lblTituloReportTotal);
            this.Controls.Add(this.reportTotal);
            this.Controls.Add(this.reportGerais);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.lblTituloProdutos);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVisualizarLista";
            this.Text = "FormVisualizarLista";
            this.Load += new System.EventHandler(this.FormVisualizarLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mercadoesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGeraisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGerais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MercadoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosTotaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosTotais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblTituloProdutos;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblCarregando;
        private Microsoft.Reporting.WinForms.ReportViewer reportGerais;
        private Microsoft.Reporting.WinForms.ReportViewer reportTotal;
        private System.Windows.Forms.BindingSource MercadoesBindingSource;
        private Relatorios.DataSet.DadosGerais dadosGerais;
        private System.Windows.Forms.BindingSource dadosGeraisBindingSource;
        private Relatorios.DataSet.DadosTotais dadosTotais;
        private System.Windows.Forms.BindingSource dadosTotaisBindingSource;
        private System.Windows.Forms.BindingSource mercadoesBindingSource1;
        private Relatorios.DataSet.DadosGeraisTableAdapters.MercadoesTableAdapter mercadoesTableAdapter;
        private System.Windows.Forms.BindingSource mercadoesBindingSource2;
        private Relatorios.DataSet.DadosTotaisTableAdapters.MercadoesTableAdapter mercadoesTableAdapter1;
        private System.Windows.Forms.Label lblTituloReportTotal;
        private System.Windows.Forms.Label lblTituloReportGeral;
    }
}