using System;
using System.Windows.Forms;

namespace Programa_Clase_2
{
    public partial class Form1 : Form
    {
        int valor1;
        int valor2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_1_Click(object sender, System.EventArgs e)
        {
            valor1 = Convert.ToInt32(txt_box1.Text);
            valor2 = Convert.ToInt32(txt_box2.Text);
            lbl_resultado.Text = Convert.ToString(valor1 + valor2);

            /*lbl_resultado1.Text =  
             * (Convert.ToInt32(txt_box1.Text)
             + Convert.ToInt32(txt_box2)).ToString();
                                    o convertir a string  los 2 ya convertidos a enteros
                                    */
            //bt_prueba.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txt_box1.Text);
            valor2 = Convert.ToInt32(txt_box2.Text);
            lbl_resultado.Text = (valor1 - valor2).ToString();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            /*Timer Reloj = new Timer();
            Reloj.Interval = 5000;
            do
            {
                barra_progreso.Value = barra_progreso.Value + 1;
            
                
            } while (barra_progreso.Value  < 100); */
            Form Tarea = new Form2();
            Tarea.ShowDialog();
        }
    }
}
