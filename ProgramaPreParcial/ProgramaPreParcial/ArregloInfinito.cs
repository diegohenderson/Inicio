using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPreParcial
{
    public partial class ArregloInfinito : Form
    {
        System.String[] Lista = new System.String[1];
        int Index = 0;
        
        public ArregloInfinito()
        {
            InitializeComponent();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Lista[Index] = txt.Text;
                Index++;
                if (Index==4)
                {
                    throw (new Exception("error logico mio"));
                }
            }
            catch (IndexOutOfRangeException)
            {

                string[] Dummy = new string[Lista.Length + 1];
                for (int i = 0; i < Index ; i++)
                {
                    Dummy[i] = Lista[i];
                }
                Lista = Dummy;
                Lista[Index] = txt.Text;
                Index++;
                lbl.Text = Lista.Length.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
