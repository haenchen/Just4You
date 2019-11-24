namespace Just4You.Modules.Informatics
{
    partial class InformaticsFunctionChoosingForm
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
            this.btnImage = new System.Windows.Forms.Button();
            this.btnUnits = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnImage.Location = new System.Drawing.Point(12, 12);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(161, 67);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "Bild";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnUnits
            // 
            this.btnUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUnits.Location = new System.Drawing.Point(12, 85);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Size = new System.Drawing.Size(161, 67);
            this.btnUnits.TabIndex = 1;
            this.btnUnits.Text = "Umrechnung";
            this.btnUnits.UseVisualStyleBackColor = true;
            this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnNumber.Location = new System.Drawing.Point(12, 158);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(161, 67);
            this.btnNumber.TabIndex = 2;
            this.btnNumber.Text = "Zahlensystem";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // InformaticsFunctionChoosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 233);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.btnUnits);
            this.Controls.Add(this.btnImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InformaticsFunctionChoosingForm";
            this.Text = "Informationstechnik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnUnits;
        private System.Windows.Forms.Button btnNumber;
    }
}