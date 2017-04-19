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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblTituloProdutos = new System.Windows.Forms.Label();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblCarregando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nome da lista";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(16, 115);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowTemplate.Height = 28;
            this.dgvProdutos.Size = new System.Drawing.Size(369, 612);
            this.dgvProdutos.TabIndex = 1;
            // 
            // lblTituloProdutos
            // 
            this.lblTituloProdutos.AutoSize = true;
            this.lblTituloProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProdutos.Location = new System.Drawing.Point(12, 83);
            this.lblTituloProdutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloProdutos.Name = "lblTituloProdutos";
            this.lblTituloProdutos.Size = new System.Drawing.Size(426, 22);
            this.lblTituloProdutos.TabIndex = 2;
            this.lblTituloProdutos.Text = "Sua lista de compras contém os seguintes produtos:";
            // 
            // lblDivider
            // 
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Location = new System.Drawing.Point(-28, 57);
            this.lblDivider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(2250, 2);
            this.lblDivider.TabIndex = 3;
            // 
            // lblCarregando
            // 
            this.lblCarregando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarregando.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.Location = new System.Drawing.Point(0, 0);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(556, 768);
            this.lblCarregando.TabIndex = 4;
            this.lblCarregando.Text = "Por favor aguarde...";
            this.lblCarregando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCarregando.Visible = false;
            // 
            // FormVisualizarLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(556, 768);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.lblTituloProdutos);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVisualizarLista";
            this.Text = "FormVisualizarLista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblTituloProdutos;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblCarregando;
    }
}