namespace ProgramaPreParcial
{
    partial class MatrizdemasDimenciones
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
            this.btCarga = new System.Windows.Forms.Button();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.lbl00 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCarga
            // 
            this.btCarga.Location = new System.Drawing.Point(305, 144);
            this.btCarga.Name = "btCarga";
            this.btCarga.Size = new System.Drawing.Size(75, 23);
            this.btCarga.TabIndex = 0;
            this.btCarga.Text = "button1";
            this.btCarga.UseVisualStyleBackColor = true;
            this.btCarga.Click += new System.EventHandler(this.BtCarga_Click);
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(99, 265);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(100, 22);
            this.txtCarga.TabIndex = 2;
            // 
            // lbl00
            // 
            this.lbl00.AutoSize = true;
            this.lbl00.Location = new System.Drawing.Point(63, 128);
            this.lbl00.Name = "lbl00";
            this.lbl00.Size = new System.Drawing.Size(0, 17);
            this.lbl00.TabIndex = 3;
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Location = new System.Drawing.Point(148, 128);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(0, 17);
            this.lbl01.TabIndex = 4;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(62, 161);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(0, 17);
            this.lbl10.TabIndex = 5;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(148, 161);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(0, 17);
            this.lbl11.TabIndex = 6;
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Location = new System.Drawing.Point(62, 201);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(0, 17);
            this.lbl20.TabIndex = 7;
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.Location = new System.Drawing.Point(148, 201);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(0, 17);
            this.lbl21.TabIndex = 8;
            // 
            // MatrizdemasDimenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl21);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.lbl00);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.btCarga);
            this.Name = "MatrizdemasDimenciones";
            this.Text = "MatrizdemasDimenciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCarga;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.Label lbl00;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl21;
    }
}