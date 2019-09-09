using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Clase_2
{
    public partial class Form2 : Form
    {
        
        string operacion = "";
        int cantidad = 0;
        int suma = 0;
        
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Bt_tarea_Click(object sender, EventArgs e)
        {
                        
            suma = suma + Convert.ToInt32(txt_box_tarea.Text);
            cantidad = cantidad + 1;
            operacion = operacion +   txt_box_tarea.Text ;
            
            lbl_cantidad.Text = "La cantidad de Operandos es : "+ cantidad.ToString();
            lbl_oper.Text = operacion+ "  =  " + suma.ToString();
            operacion = operacion + " + ";
            txt_box_tarea.Clear();
            txt_box_tarea.Focus();
            
            
        }

        private void Txt_box_tarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = operacion.Substring(3,2);
            
            
            //label1.Text = operacion.Substring(3);

        }
    }
}
