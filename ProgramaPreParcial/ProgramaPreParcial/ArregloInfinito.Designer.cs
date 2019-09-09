namespace ProgramaPreParcial
{
    partial class ArregloInfinito
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(316, 163);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(157, 132);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(195, 22);
            this.txt.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(154, 163);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(103, 23);
            this.lbl.TabIndex = 2;
            // 
            // ArregloInfinito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btAceptar);
            this.Name = "ArregloInfinito";
            this.Text = "ArregloInfinito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lbl;
    }
}