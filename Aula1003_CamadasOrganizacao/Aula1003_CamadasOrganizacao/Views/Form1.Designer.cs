namespace Aula1003_CamadasOrganizacao
{
    partial class Form1
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
            this.btnCadastrarCarro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.Size = new System.Drawing.Size(231, 23);
            this.btnCadastrarCarro.TabIndex = 0;
            this.btnCadastrarCarro.Text = "Cadastrar carro";
            this.btnCadastrarCarro.UseVisualStyleBackColor = true;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 47);
            this.Controls.Add(this.btnCadastrarCarro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCarro;
    }
}

