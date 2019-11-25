namespace Just4You.Modules.Finances
{
    partial class FinancesFunctionChoosingForm
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
            this.btnOneTimePayment = new System.Windows.Forms.Button();
            this.btnNumberOfPayments = new System.Windows.Forms.Button();
            this.btnPaymentAmount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOneTimePayment
            // 
            this.btnOneTimePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOneTimePayment.Location = new System.Drawing.Point(12, 12);
            this.btnOneTimePayment.Name = "btnOneTimePayment";
            this.btnOneTimePayment.Size = new System.Drawing.Size(410, 67);
            this.btnOneTimePayment.TabIndex = 0;
            this.btnOneTimePayment.Text = "Kredit mit einmaliger Rückzahlung";
            this.btnOneTimePayment.UseVisualStyleBackColor = true;
            this.btnOneTimePayment.Click += new System.EventHandler(this.btnOneTimePayment_Click);
            // 
            // btnNumberOfPayments
            // 
            this.btnNumberOfPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNumberOfPayments.Location = new System.Drawing.Point(12, 85);
            this.btnNumberOfPayments.Name = "btnNumberOfPayments";
            this.btnNumberOfPayments.Size = new System.Drawing.Size(410, 67);
            this.btnNumberOfPayments.TabIndex = 1;
            this.btnNumberOfPayments.Text = "Ratenkauf mit Laufzeit";
            this.btnNumberOfPayments.UseVisualStyleBackColor = true;
            this.btnNumberOfPayments.Click += new System.EventHandler(this.btnNumberOfPayments_Click);
            // 
            // btnPaymentAmount
            // 
            this.btnPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPaymentAmount.Location = new System.Drawing.Point(12, 158);
            this.btnPaymentAmount.Name = "btnPaymentAmount";
            this.btnPaymentAmount.Size = new System.Drawing.Size(410, 67);
            this.btnPaymentAmount.TabIndex = 2;
            this.btnPaymentAmount.Text = "Ratenkauf mit Ratenhöhe";
            this.btnPaymentAmount.UseVisualStyleBackColor = true;
            this.btnPaymentAmount.Click += new System.EventHandler(this.btnPaymentAmount_Click);
            // 
            // FinancesFunctionChoosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 234);
            this.Controls.Add(this.btnPaymentAmount);
            this.Controls.Add(this.btnNumberOfPayments);
            this.Controls.Add(this.btnOneTimePayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FinancesFunctionChoosingForm";
            this.Text = "FinancesFunctionChoosingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOneTimePayment;
        private System.Windows.Forms.Button btnNumberOfPayments;
        private System.Windows.Forms.Button btnPaymentAmount;
    }
}