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
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeMercadoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(470, 33);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // listaDeMercadoToolStripMenuItem
            // 
            this.listaDeMercadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.verTodasToolStripMenuItem});
            this.listaDeMercadoToolStripMenuItem.Name = "listaDeMercadoToolStripMenuItem";
            this.listaDeMercadoToolStripMenuItem.Size = new System.Drawing.Size(159, 29);
            this.listaDeMercadoToolStripMenuItem.Text = "Lista de Mercado";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // verTodasToolStripMenuItem
            // 
            this.verTodasToolStripMenuItem.Name = "verTodasToolStripMenuItem";
            this.verTodasToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.verTodasToolStripMenuItem.Text = "Ver todas";
            this.verTodasToolStripMenuItem.Click += new System.EventHandler(this.verTodasToolStripMenuItem_Click);
            // 
            // lblCarregando
            // 
            this.lblCarregando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarregando.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.Location = new System.Drawing.Point(0, 33);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(470, 364);
            this.lblCarregando.TabIndex = 2;
            this.lblCarregando.Text = "Por favor aguarde...";
            this.lblCarregando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 397);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "FormPrincipal";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem listaDeMercadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasToolStripMenuItem;
        private System.Windows.Forms.Label lblCarregando;
    }
}

