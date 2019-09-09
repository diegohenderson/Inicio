namespace Programa_Clase_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_datos = new System.Windows.Forms.Label();
            this.lbl_resultado1 = new System.Windows.Forms.Label();
            this.bt_1 = new System.Windows.Forms.Button();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_datos
            // 
            this.lbl_datos.AutoSize = true;
            this.lbl_datos.Location = new System.Drawing.Point(139, 111);
            this.lbl_datos.Name = "lbl_datos";
            this.lbl_datos.Size = new System.Drawing.Size(45, 17);
            this.lbl_datos.TabIndex = 0;
            this.lbl_datos.Text = "Datos";
            // 
            // lbl_resultado1
            // 
            this.lbl_resultado1.AutoSize = true;
            this.lbl_resultado1.Location = new System.Drawing.Point(233, 85);
            this.lbl_resultado1.Name = "lbl_resultado1";
            this.lbl_resultado1.Size = new System.Drawing.Size(0, 17);
            this.lbl_resultado1.TabIndex = 1;
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.Color.DarkViolet;
            this.bt_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_1.ForeColor = System.Drawing.Color.GhostWhite;
            this.bt_1.Location = new System.Drawing.Point(319, 105);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(75, 23);
            this.bt_1.TabIndex = 2;
            this.bt_1.Text = "&Aceptar";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.Bt_1_Click);
            // 
            // txt_1
            // 
            this.txt_1.BackColor = System.Drawing.Color.MediumOrchid;
            this.txt_1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_1.Location = new System.Drawing.Point(190, 106);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(123, 23);
            this.txt_1.TabIndex = 3;
            this.txt_1.TextChanged += new System.EventHandler(this.Txt_1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.lbl_resultado1);
            this.Controls.Add(this.lbl_datos);
            this.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Name = "Form1";
            this.Text = "Ventana Nueva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_datos;
        private System.Windows.Forms.Label lbl_resultado1;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.TextBox txt_1;
    }
}

