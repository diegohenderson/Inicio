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
    public partial class MatrizdemasDimenciones : Form
    {
        //definida global
        Label[,] lbl = new Label[3, 2];
        int Filas = 0;
        int Columnas = 0;
        int Provocador = 1;
        public MatrizdemasDimenciones() //Constructor
        {
            InitializeComponent();


            lbl[0, 0] = lbl00;
            lbl[0, 1] = lbl01;
            lbl[1, 0] = lbl10;
            lbl[1, 1] = lbl11;
            lbl[2, 0] = lbl20;
            lbl[2, 1] = lbl21;


        }

        private void BtCarga_Click(object sender, EventArgs e)
        {
                //posible solucion dada en clase
            lbl[Filas, Columnas].Text = txtCarga.Text;
            try
            {
                if (Columnas == 0)
                {
                    Columnas = 1;
                }
                else
                {
                    Columnas = 0;
                    Filas++;
                }
                

            }
            catch (IndexOutOfRangeException )
            {//Error cuando la  matriz esta llena 
                Filas = 0;
                Columnas = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        lbl[i, j].Text = "";
                    }
                }
                lbl[Filas, Columnas].Text = txtCarga.Text;
                Columnas = 1;
            }
            catch(Exception err)
            { 
                //MessageBox.Show(err.Message); //Message box

                MessageBox.Show(err.Message); //Message box

            }
        }
    }
}
