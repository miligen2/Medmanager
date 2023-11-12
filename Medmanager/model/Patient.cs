using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medmanager.model
{
    internal class Patient
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }
        public string CodePostal { get; set; }
        public DateTime DateEntree { get; set; }

        public Patient(string nom, string prenom, string numero, string email, string codePostal, DateTime dateEntree)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Numero = numero;
            this.Email = email;
            this.CodePostal = codePostal;
            this.DateEntree = dateEntree;
        }
    }
}
