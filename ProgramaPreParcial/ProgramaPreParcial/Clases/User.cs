using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProgramaPreParcial.Clases
{
    public class User
    {
        //Constructor
        public User()
        {
            user = "";
            password = "";
            email = "";
        }
        //propiedades de la clase User
        public User[] ArrayUser = { };
        public string user;
        List<User> Usuarios = new List<User>();
        public string password;
        public string email;
        
        //public string[] ArrayPassword;
        //public string[] ArrayEmail;

        //metodo
        public void SaveUser ()
        {
           
        }
    }
}
