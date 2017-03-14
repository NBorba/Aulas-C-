namespace Calculadora100317
{
    partial class formCalc
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnMem = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(12, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(288, 49);
            this.txtOutput.TabIndex = 0;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(12, 181);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(36, 30);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(54, 181);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(36, 30);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(96, 181);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(36, 30);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(12, 145);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(36, 30);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(54, 145);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(36, 30);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(96, 145);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(36, 30);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(12, 109);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(36, 30);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(54, 109);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(36, 30);
            this.btnEight.TabIndex = 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(96, 109);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(36, 30);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(138, 109);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(36, 30);
            this.btnDivide.TabIndex = 10;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnOperationClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(138, 73);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(36, 30);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnOperationClick);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(138, 145);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(36, 30);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnOperationClick);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(138, 181);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(36, 30);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnOperationClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 73);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClearOutput);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Location = new System.Drawing.Point(180, 73);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(120, 30);
            this.btnSquareRoot.TabIndex = 15;
            this.btnSquareRoot.Text = "Square Root";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(180, 109);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(120, 30);
            this.btnPower.TabIndex = 16;
            this.btnPower.Text = "Power";
            this.btnPower.UseVisualStyleBackColor = true;
            // 
            // btnMem
            // 
            this.btnMem.Location = new System.Drawing.Point(180, 145);
            this.btnMem.Name = "btnMem";
            this.btnMem.Size = new System.Drawing.Size(120, 30);
            this.btnMem.TabIndex = 17;
            this.btnMem.Text = "Mem";
            this.btnMem.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(12, 217);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(120, 30);
            this.btnZero.TabIndex = 18;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(138, 217);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(36, 30);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnEqualsClick);
            // 
            // formCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 251);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMem);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.txtOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formCalc";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnMem;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnCalculate;
    }
}

