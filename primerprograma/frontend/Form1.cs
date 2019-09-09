using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Boton_datos1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Text = "el dato ingresado es: "
                           + textBox1.Text
                           + " fin de la frase ";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            this.textBox1.ForeColor = SystemColors.InactiveCaption;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
