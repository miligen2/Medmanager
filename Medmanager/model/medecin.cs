using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medmanager.model
{
    internal class Medecin
    {
        public int id;
        public string prenom { get; set;}
        public string nom {  get; set; }
        public DateTime dateAnniversaire { get; set; }

        public Medecin(int id ,string prenom,string nom, DateTime anniversaire)
        {
            this.id = id;
            this.prenom = prenom;
            this.nom = nom;
            this.dateAnniversaire = anniversaire;
        }
    } 
}
