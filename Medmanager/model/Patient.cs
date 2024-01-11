using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medmanager.model
{
    internal class Patient
    {
        public int id {  get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Numero { get; set; }
        public string Sexe { get; set; }

     

        public Patient(int id, string nom, string prenom,string sexe, string numero)
        {
            this.id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Numero = numero;
            this.Sexe = sexe;
        }
    }
}
