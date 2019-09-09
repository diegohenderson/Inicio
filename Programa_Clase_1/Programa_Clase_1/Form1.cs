using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Clase_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_1_Click(object sender, EventArgs e)
        {
            lbl_resultado1.Text = "Buenos dias   "
                         + txt_1.Text
                         + " que tengas un buen dia ";
        }

        private void Txt_1_TextChanged(object sender, EventArgs e)
        {
            this.txt_1.ForeColor = SystemColors.ControlText;
        }

        
    }
}
