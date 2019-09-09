using ProgramaPreParcial.Clases;
using System;
using System.Collections;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void UserCreate() //Metodo para crear el Usuario
        {
            User User1 = new User();
            User1.user = txtUser.Text;
            User1.email = txtEmail.Text;
            if (txtPassword.TextLength > 6 )
            {
                User1.password = txtPassword.Text;

            }
            else
            {
                lblPassword.Text = "Minimo 6 Caracteres";
            }   
            
        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            UserCreate();
        }
    }
}
