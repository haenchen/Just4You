namespace Just4You.Modules.MathematicalFunctions
{
    partial class MathematicalFunctionChoosingForm
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
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnExponentiation = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnPrimes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFactorial
            // 
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnFactorial.Location = new System.Drawing.Point(12, 12);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(161, 67);
            this.btnFactorial.TabIndex = 0;
            this.btnFactorial.Text = "Fakultät";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnExponentiation
            // 
            this.btnExponentiation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExponentiation.Location = new System.Drawing.Point(12, 85);
            this.btnExponentiation.Name = "btnExponentiation";
            this.btnExponentiation.Size = new System.Drawing.Size(161, 67);
            this.btnExponentiation.TabIndex = 1;
            this.btnExponentiation.Text = "Potenz";
            this.btnExponentiation.UseVisualStyleBackColor = true;
            this.btnExponentiation.Click += new System.EventHandler(this.btnExponentiation_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRoot.Location = new System.Drawing.Point(179, 12);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(161, 67);
            this.btnRoot.TabIndex = 2;
            this.btnRoot.Text = "Wurzel";
            this.btnRoot.UseVisualStyleBackColor = true;
            // 
            // btnPrimes
            // 
            this.btnPrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPrimes.Location = new System.Drawing.Point(179, 85);
            this.btnPrimes.Name = "btnPrimes";
            this.btnPrimes.Size = new System.Drawing.Size(161, 67);
            this.btnPrimes.TabIndex = 3;
            this.btnPrimes.Text = "Primzahlen";
            this.btnPrimes.UseVisualStyleBackColor = true;
            // 
            // MathematicalFunctionChoosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 162);
            this.Controls.Add(this.btnPrimes);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnExponentiation);
            this.Controls.Add(this.btnFactorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MathematicalFunctionChoosingForm";
            this.Text = "Mathematische Funktionen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnExponentiation;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnPrimes;
    }
}