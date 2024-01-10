using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medmanager.model
{
    internal class medecin
    {
        public string prenom
        {
            get; set;
        }
        public string nom {  get; set; }
        public DateTime dateAnniversaire { get; set; }

        public medecin(string prenom,string nom, DateTime anniversaire)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.dateAnniversaire = anniversaire;
        }
    } 
}
