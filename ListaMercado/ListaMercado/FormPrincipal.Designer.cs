namespace ListaMercado
{
    partial class FormPrincipal
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.listaDeMercadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTipTitulo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipoHoraAtualizacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTituloEuro = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPrecoEuro = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTituloCotacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripHoraCotacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeMercadoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menu.Size = new System.Drawing.Size(932, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // listaDeMercadoToolStripMenuItem
            // 
            this.listaDeMercadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.verTodasToolStripMenuItem});
            this.listaDeMercadoToolStripMenuItem.Name = "listaDeMercadoToolStripMenuItem";
            this.listaDeMercadoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.listaDeMercadoToolStripMenuItem.Text = "Lista de Mercado";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // verTodasToolStripMenuItem
            // 
            this.verTodasToolStripMenuItem.Name = "verTodasToolStripMenuItem";
            this.verTodasToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.verTodasToolStripMenuItem.Text = "Ver todas";
            this.verTodasToolStripMenuItem.Click += new System.EventHandler(this.verTodasToolStripMenuItem_Click);
            // 
            // lblCarregando
            // 
            this.lblCarregando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarregando.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.Location = new System.Drawing.Point(0, 24);
            this.lblCarregando.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(932, 234);
            this.lblCarregando.TabIndex = 2;
            this.lblCarregando.Text = "Por favor aguarde...";
            this.lblCarregando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTipTitulo,
            this.toolTipoHoraAtualizacao,
            this.toolStripTituloEuro,
            this.toolStripPrecoEuro,
            this.toolStripTituloCotacao,
            this.toolStripHoraCotacao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 236);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(932, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolTipTitulo
            // 
            this.toolTipTitulo.Name = "toolTipTitulo";
            this.toolTipTitulo.Size = new System.Drawing.Size(164, 17);
            this.toolTipTitulo.Text = "Base de preços atualizada em:";
            // 
            // toolTipoHoraAtualizacao
            // 
            this.toolTipoHoraAtualizacao.Name = "toolTipoHoraAtualizacao";
            this.toolTipoHoraAtualizacao.Size = new System.Drawing.Size(159, 17);
            this.toolTipoHoraAtualizacao.Text = "base ainda não foi atualizada";
            // 
            // toolStripTituloEuro
            // 
            this.toolStripTituloEuro.Name = "toolStripTituloEuro";
            this.toolStripTituloEuro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripTituloEuro.Size = new System.Drawing.Size(81, 17);
            this.toolStripTituloEuro.Text = "Preço do Euro";
            // 
            // toolStripPrecoEuro
            // 
            this.toolStripPrecoEuro.Name = "toolStripPrecoEuro";
            this.toolStripPrecoEuro.Size = new System.Drawing.Size(37, 17);
            this.toolStripPrecoEuro.Text = "preco";
            // 
            // toolStripTituloCotacao
            // 
            this.toolStripTituloCotacao.Name = "toolStripTituloCotacao";
            this.toolStripTituloCotacao.Size = new System.Drawing.Size(92, 17);
            this.toolStripTituloCotacao.Text = "Data da cotação";
            // 
            // toolStripHoraCotacao
            // 
            this.toolStripHoraCotacao.Name = "toolStripHoraCotacao";
            this.toolStripHoraCotacao.Size = new System.Drawing.Size(31, 17);
            this.toolStripHoraCotacao.Text = "hora";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 258);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem listaDeMercadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasToolStripMenuItem;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolTipTitulo;
        private System.Windows.Forms.ToolStripStatusLabel toolTipoHoraAtualizacao;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTituloEuro;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPrecoEuro;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTituloCotacao;
        private System.Windows.Forms.ToolStripStatusLabel toolStripHoraCotacao;
    }
}

