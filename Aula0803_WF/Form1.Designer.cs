namespace Aula0803_WF
{
    partial class frmTelaInicial
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPerc = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(13, 13);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(302, 44);
            this.txtDisplay.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 182);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(52, 45);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(71, 182);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(52, 45);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumClick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(129, 182);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(52, 45);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumClick);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(129, 131);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(52, 45);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumClick);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(71, 131);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(52, 45);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumClick);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 131);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(52, 45);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumClick);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(129, 80);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(52, 45);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumClick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(71, 80);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 45);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumClick);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 80);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(52, 45);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(263, 80);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(52, 45);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnPerc
            // 
            this.btnPerc.Location = new System.Drawing.Point(263, 182);
            this.btnPerc.Name = "btnPerc";
            this.btnPerc.Size = new System.Drawing.Size(52, 45);
            this.btnPerc.TabIndex = 15;
            this.btnPerc.Text = "%";
            this.btnPerc.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(205, 80);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(52, 45);
            this.btnMult.TabIndex = 14;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(263, 233);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(52, 45);
            this.btnSub.TabIndex = 13;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(205, 182);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(52, 96);
            this.btnSoma.TabIndex = 17;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(263, 131);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(52, 45);
            this.btnRaiz.TabIndex = 19;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(205, 131);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(52, 45);
            this.btnDiv.TabIndex = 18;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(13, 235);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(52, 45);
            this.btnPoint.TabIndex = 20;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnNumClick);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(71, 235);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(52, 45);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumClick);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(129, 233);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(52, 45);
            this.btnResult.TabIndex = 22;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 292);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPerc);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "frmTelaInicial";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPerc;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnResult;

    }
}

