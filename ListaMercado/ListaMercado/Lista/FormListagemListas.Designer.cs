namespace ListaMercado.Lista
{
    partial class FormListagemListas
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
            this.dgvListas = new System.Windows.Forms.DataGridView();
            this.VerLista = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListas
            // 
            this.dgvListas.AllowUserToAddRows = false;
            this.dgvListas.AllowUserToDeleteRows = false;
            this.dgvListas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VerLista});
            this.dgvListas.Location = new System.Drawing.Point(12, 101);
            this.dgvListas.Name = "dgvListas";
            this.dgvListas.ReadOnly = true;
            this.dgvListas.RowTemplate.Height = 28;
            this.dgvListas.Size = new System.Drawing.Size(589, 514);
            this.dgvListas.TabIndex = 0;
            this.dgvListas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListas_CellContentClick);
            // 
            // VerLista
            // 
            this.VerLista.HeaderText = "Ver Lista";
            this.VerLista.Name = "VerLista";
            this.VerLista.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(474, 52);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Suas listas de compras";
            // 
            // FormListagemListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 627);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvListas);
            this.Name = "FormListagemListas";
            this.Text = "FormListagemListas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvListas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListas;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewButtonColumn VerLista;
    }
}