using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir1
{
    public class Client
    {
        public string Nom { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }

        public Client (string nom, string email, int telephone)
        {
            this.Email = email;
            this.Nom = nom;
            this.Telephone = telephone;
        }

        public Client(string email)
        {
            Email = email;
        }
    }
}
