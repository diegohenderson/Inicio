namespace Programa_Clase_2
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
            this.bt_tarea = new System.Windows.Forms.Button();
            this.txt_box_tarea = new System.Windows.Forms.TextBox();
            this.lbl_oper = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_tarea
            // 
            this.bt_tarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tarea.Location = new System.Drawing.Point(215, 86);
            this.bt_tarea.Name = "bt_tarea";
            this.bt_tarea.Size = new System.Drawing.Size(179, 92);
            this.bt_tarea.TabIndex = 1;
            this.bt_tarea.Text = "&+";
            this.bt_tarea.UseVisualStyleBackColor = true;
            this.bt_tarea.Click += new System.EventHandler(this.Bt_tarea_Click);
            // 
            // txt_box_tarea
            // 
            this.txt_box_tarea.Location = new System.Drawing.Point(61, 121);
            this.txt_box_tarea.Name = "txt_box_tarea";
            this.txt_box_tarea.Size = new System.Drawing.Size(100, 22);
            this.txt_box_tarea.TabIndex = 2;
            this.txt_box_tarea.TextChanged += new System.EventHandler(this.Txt_box_tarea_TextChanged);
            // 
            // lbl_oper
            // 
            this.lbl_oper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_oper.Location = new System.Drawing.Point(12, 39);
            this.lbl_oper.Name = "lbl_oper";
            this.lbl_oper.Size = new System.Drawing.Size(393, 35);
            this.lbl_oper.TabIndex = 3;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_cantidad.Location = new System.Drawing.Point(12, 9);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(393, 30);
            this.lbl_cantidad.TabIndex = 4;
            this.lbl_cantidad.Text = "Cantidad: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "o";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 64);
            this.label1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AcceptButton = this.bt_tarea;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_oper);
            this.Controls.Add(this.txt_box_tarea);
            this.Controls.Add(this.bt_tarea);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_tarea;
        private System.Windows.Forms.TextBox txt_box_tarea;
        private System.Windows.Forms.Label lbl_oper;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}