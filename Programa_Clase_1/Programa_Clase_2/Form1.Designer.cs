namespace Programa_Clase_2
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
            this.txt_box2 = new System.Windows.Forms.TextBox();
            this.bt_suma = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.txt_box1 = new System.Windows.Forms.TextBox();
            this.bt_resta = new System.Windows.Forms.Button();
            this.lbl_prueba = new System.Windows.Forms.Label();
            this.bt_multiplica = new System.Windows.Forms.Button();
            this.bt_Divide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.barra_progreso = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txt_box2
            // 
            this.txt_box2.Location = new System.Drawing.Point(49, 72);
            this.txt_box2.Name = "txt_box2";
            this.txt_box2.Size = new System.Drawing.Size(128, 22);
            this.txt_box2.TabIndex = 0;
            // 
            // bt_suma
            // 
            this.bt_suma.Location = new System.Drawing.Point(372, 190);
            this.bt_suma.Name = "bt_suma";
            this.bt_suma.Size = new System.Drawing.Size(103, 57);
            this.bt_suma.TabIndex = 1;
            this.bt_suma.Text = "&Suma";
            this.bt_suma.UseVisualStyleBackColor = true;
            this.bt_suma.Click += new System.EventHandler(this.Bt_1_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_resultado.Location = new System.Drawing.Point(12, 104);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(217, 57);
            this.lbl_resultado.TabIndex = 2;
            // 
            // txt_box1
            // 
            this.txt_box1.Location = new System.Drawing.Point(49, 44);
            this.txt_box1.Name = "txt_box1";
            this.txt_box1.Size = new System.Drawing.Size(128, 22);
            this.txt_box1.TabIndex = 3;
            // 
            // bt_resta
            // 
            this.bt_resta.Location = new System.Drawing.Point(372, 19);
            this.bt_resta.Name = "bt_resta";
            this.bt_resta.Size = new System.Drawing.Size(103, 57);
            this.bt_resta.TabIndex = 4;
            this.bt_resta.Text = "Resta";
            this.bt_resta.UseVisualStyleBackColor = true;
            this.bt_resta.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbl_prueba
            // 
            this.lbl_prueba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_prueba.Location = new System.Drawing.Point(586, 244);
            this.lbl_prueba.Name = "lbl_prueba";
            this.lbl_prueba.Size = new System.Drawing.Size(100, 23);
            this.lbl_prueba.TabIndex = 5;
            // 
            // bt_multiplica
            // 
            this.bt_multiplica.Location = new System.Drawing.Point(372, 76);
            this.bt_multiplica.Name = "bt_multiplica";
            this.bt_multiplica.Size = new System.Drawing.Size(103, 57);
            this.bt_multiplica.TabIndex = 6;
            this.bt_multiplica.Text = "Multiplicar";
            this.bt_multiplica.UseVisualStyleBackColor = true;
            // 
            // bt_Divide
            // 
            this.bt_Divide.Location = new System.Drawing.Point(372, 133);
            this.bt_Divide.Name = "bt_Divide";
            this.bt_Divide.Size = new System.Drawing.Size(103, 57);
            this.bt_Divide.TabIndex = 7;
            this.bt_Divide.Text = "Dividir";
            this.bt_Divide.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 123);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tarea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // barra_progreso
            // 
            this.barra_progreso.Location = new System.Drawing.Point(68, 364);
            this.barra_progreso.Name = "barra_progreso";
            this.barra_progreso.Size = new System.Drawing.Size(187, 23);
            this.barra_progreso.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barra_progreso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Divide);
            this.Controls.Add(this.bt_multiplica);
            this.Controls.Add(this.lbl_prueba);
            this.Controls.Add(this.bt_resta);
            this.Controls.Add(this.txt_box1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.bt_suma);
            this.Controls.Add(this.txt_box2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_box2;
        private System.Windows.Forms.Button bt_suma;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txt_box1;
        private System.Windows.Forms.Button bt_resta;
        private System.Windows.Forms.Label lbl_prueba;
        private System.Windows.Forms.Button bt_multiplica;
        private System.Windows.Forms.Button bt_Divide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar barra_progreso;
    }
}

