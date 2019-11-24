namespace Just4You
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModule3 = new System.Windows.Forms.Button();
            this.btnModuleTwo = new System.Windows.Forms.Button();
            this.btnModuleOne = new System.Windows.Forms.Button();
            this.btnBasicCalculator = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModule3);
            this.panel1.Controls.Add(this.btnModuleTwo);
            this.panel1.Controls.Add(this.btnModuleOne);
            this.panel1.Controls.Add(this.btnBasicCalculator);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(772, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 364);
            this.panel1.TabIndex = 2;
            // 
            // btnModule3
            // 
            this.btnModule3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModule3.Location = new System.Drawing.Point(8, 278);
            this.btnModule3.Name = "btnModule3";
            this.btnModule3.Size = new System.Drawing.Size(256, 80);
            this.btnModule3.TabIndex = 4;
            this.btnModule3.Text = "button3";
            this.btnModule3.UseVisualStyleBackColor = true;
            // 
            // btnModuleTwo
            // 
            this.btnModuleTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleTwo.Location = new System.Drawing.Point(8, 192);
            this.btnModuleTwo.Name = "btnModuleTwo";
            this.btnModuleTwo.Size = new System.Drawing.Size(256, 80);
            this.btnModuleTwo.TabIndex = 3;
            this.btnModuleTwo.Text = "button2";
            this.btnModuleTwo.UseVisualStyleBackColor = true;
            // 
            // btnModuleOne
            // 
            this.btnModuleOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleOne.Location = new System.Drawing.Point(8, 106);
            this.btnModuleOne.Name = "btnModuleOne";
            this.btnModuleOne.Size = new System.Drawing.Size(256, 80);
            this.btnModuleOne.TabIndex = 2;
            this.btnModuleOne.Text = "button1";
            this.btnModuleOne.UseVisualStyleBackColor = true;
            this.btnModuleOne.Click += new System.EventHandler(this.btnModuleOne_Click);
            // 
            // btnBasicCalculator
            // 
            this.btnBasicCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasicCalculator.Location = new System.Drawing.Point(8, 20);
            this.btnBasicCalculator.Name = "btnBasicCalculator";
            this.btnBasicCalculator.Size = new System.Drawing.Size(256, 80);
            this.btnBasicCalculator.TabIndex = 1;
            this.btnBasicCalculator.Text = "Grundrechner";
            this.btnBasicCalculator.UseVisualStyleBackColor = true;
            this.btnBasicCalculator.Click += new System.EventHandler(this.btnBasicCalculator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Funktionen";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtHistory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 364);
            this.panel2.TabIndex = 3;
            // 
            // txtHistory
            // 
            this.txtHistory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHistory.Location = new System.Drawing.Point(4, 21);
            this.txtHistory.Margin = new System.Windows.Forms.Padding(4);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.Size = new System.Drawing.Size(739, 339);
            this.txtHistory.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Verlauf";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 394);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModule3;
        private System.Windows.Forms.Button btnModuleTwo;
        private System.Windows.Forms.Button btnModuleOne;
        private System.Windows.Forms.Button btnBasicCalculator;
        private System.Windows.Forms.Label label2;
    }
}

