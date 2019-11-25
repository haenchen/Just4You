namespace Just4You.Modules.Percentage
{
    partial class PercentageFunctionChoosingForm
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
            this.btnSubPercent = new System.Windows.Forms.Button();
            this.btnAddPercent = new System.Windows.Forms.Button();
            this.btnPercentOf = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnGrossToNet = new System.Windows.Forms.Button();
            this.btnNetToGross = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubPercent
            // 
            this.btnSubPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubPercent.Location = new System.Drawing.Point(13, 13);
            this.btnSubPercent.Name = "btnSubPercent";
            this.btnSubPercent.Size = new System.Drawing.Size(161, 67);
            this.btnSubPercent.TabIndex = 0;
            this.btnSubPercent.Text = "Prozent abziehen";
            this.btnSubPercent.UseVisualStyleBackColor = true;
            this.btnSubPercent.Click += new System.EventHandler(this.btnSubPercent_Click);
            // 
            // btnAddPercent
            // 
            this.btnAddPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPercent.Location = new System.Drawing.Point(13, 86);
            this.btnAddPercent.Name = "btnAddPercent";
            this.btnAddPercent.Size = new System.Drawing.Size(161, 67);
            this.btnAddPercent.TabIndex = 1;
            this.btnAddPercent.Text = "Prozent hinzufügen";
            this.btnAddPercent.UseVisualStyleBackColor = true;
            this.btnAddPercent.Click += new System.EventHandler(this.btnAddPercent_Click);
            // 
            // btnPercentOf
            // 
            this.btnPercentOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentOf.Location = new System.Drawing.Point(13, 159);
            this.btnPercentOf.Name = "btnPercentOf";
            this.btnPercentOf.Size = new System.Drawing.Size(161, 67);
            this.btnPercentOf.TabIndex = 2;
            this.btnPercentOf.Text = "Prozent von Wert";
            this.btnPercentOf.UseVisualStyleBackColor = true;
            this.btnPercentOf.Click += new System.EventHandler(this.btnPercentOf_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentage.Location = new System.Drawing.Point(180, 12);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(161, 67);
            this.btnPercentage.TabIndex = 3;
            this.btnPercentage.Text = "Prozentsatz";
            this.btnPercentage.UseVisualStyleBackColor = true;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnGrossToNet
            // 
            this.btnGrossToNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrossToNet.Location = new System.Drawing.Point(180, 86);
            this.btnGrossToNet.Name = "btnGrossToNet";
            this.btnGrossToNet.Size = new System.Drawing.Size(161, 67);
            this.btnGrossToNet.TabIndex = 4;
            this.btnGrossToNet.Text = "Brutto => Netto";
            this.btnGrossToNet.UseVisualStyleBackColor = true;
            this.btnGrossToNet.Click += new System.EventHandler(this.btnGrossToNet_Click);
            // 
            // btnNetToGross
            // 
            this.btnNetToGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetToGross.Location = new System.Drawing.Point(180, 159);
            this.btnNetToGross.Name = "btnNetToGross";
            this.btnNetToGross.Size = new System.Drawing.Size(161, 67);
            this.btnNetToGross.TabIndex = 5;
            this.btnNetToGross.Text = "Netto => Brutto";
            this.btnNetToGross.UseVisualStyleBackColor = true;
            this.btnNetToGross.Click += new System.EventHandler(this.btnNetToGross_Click);
            // 
            // PercentageFunctionChoosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 235);
            this.Controls.Add(this.btnNetToGross);
            this.Controls.Add(this.btnGrossToNet);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnPercentOf);
            this.Controls.Add(this.btnAddPercent);
            this.Controls.Add(this.btnSubPercent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PercentageFunctionChoosingForm";
            this.Text = "Prozentrechnung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubPercent;
        private System.Windows.Forms.Button btnAddPercent;
        private System.Windows.Forms.Button btnPercentOf;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnGrossToNet;
        private System.Windows.Forms.Button btnNetToGross;
    }
}