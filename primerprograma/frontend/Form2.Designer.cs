namespace frontend
{
    partial class Form2
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
            this.BarraCarga = new System.Windows.Forms.ProgressBar();
            this.etiqueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BarraCarga
            // 
            this.BarraCarga.Location = new System.Drawing.Point(324, 200);
            this.BarraCarga.Name = "BarraCarga";
            this.BarraCarga.Size = new System.Drawing.Size(152, 51);
            this.BarraCarga.TabIndex = 4;
            // 
            // etiqueta
            // 
            this.etiqueta.AutoSize = true;
            this.etiqueta.Location = new System.Drawing.Point(246, 85);
            this.etiqueta.Name = "etiqueta";
            this.etiqueta.Size = new System.Drawing.Size(46, 17);
            this.etiqueta.TabIndex = 5;
            this.etiqueta.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiqueta);
            this.Controls.Add(this.BarraCarga);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar BarraCarga;
        private System.Windows.Forms.Label etiqueta;
    }
}