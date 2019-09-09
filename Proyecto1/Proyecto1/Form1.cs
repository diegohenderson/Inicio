using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        
        public int Length { get; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            do
            {
                progressBar1.Value = progressBar1.Value + 1;
                
            } while (progressBar1.Value < 100);
            //Form2 nuevaventana = new Form2();
            //nuevaventana.ShowDialog();

        }
private void MensajeBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
