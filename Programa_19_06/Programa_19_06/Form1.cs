using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_19_06
{
    public partial class Form1 : Form
    {
        int flagH= 1;
        int flagV = 1;
        int paso = 1;
        //int pasoV = 50;
        public Form1()
        {
            InitializeComponent();
        }
        private void controlVertical()
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            while (contador <= 2000) 
            {
                //control H
                if (label1.Left < panel1.Size.Width && flagH == 1)
                {
                    label1.Left = label1.Left + paso;
                    
                   
                }
                else
                {
                    flagH = -1;
                    label1.Left = label1.Left - paso;
                if (label1.Left <= 0)
                    {
                        flagH = 1;
                    }
                    //if (label1.Left > panel1.Size.Width && flagH == 0)
                    //{
                    //    label1.Left = label1.Left - paso;
                    //}


                }

                // control V
                if ((label1.Top * 2 + label1.Height) >= panel1.Size.Height || label1.Top <= 0)
                {
                    
                    flagV = -1* flagV;
                }
                label1.Top = label1.Top + paso * flagV;

                 
                    
                
                contador++;
                panel1.Refresh(); //refresca la pantalla
            }
        }
    }
}
////control H
            /*if (label1.Left< this.Size.Width && flagH== 1)
            {
                label1.Left = label1.Left + paso;
                
            }
            else
            {
                flagH = -1;
                label1.Left = label1.Left - paso;
            }
            // control V
            if (label1.Top< this.Size.Height && flagV == 1)
            {
                label1.Top = label1.Top + paso;

            }
            else
            {
                flagV = -1;
                label1.Top = label1.Top - paso;
            }*/