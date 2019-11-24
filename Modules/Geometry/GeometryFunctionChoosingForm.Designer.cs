namespace Just4You.Modules.Geometry
{
    partial class GeometryFunctionChoosingForm
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
            this.btnTriangle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTriangle
            // 
            this.btnTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnTriangle.Location = new System.Drawing.Point(12, 12);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(199, 67);
            this.btnTriangle.TabIndex = 0;
            this.btnTriangle.Text = "Dreieck";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(12, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "Parallelogramm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCircle.Location = new System.Drawing.Point(12, 158);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(199, 67);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "Kreis";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // GeometryFunctionChoosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 237);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTriangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GeometryFunctionChoosingForm";
            this.Text = "Geometrie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCircle;
    }
}