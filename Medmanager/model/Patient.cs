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
        public string Sexe { get; set; }

     

        public Patient(string nom, string prenom,string sexe, string numero)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Numero = numero;
            this.Sexe = sexe;
        }
    }
}
