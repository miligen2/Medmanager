using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medmanager
{
    internal class Drug
    {
        public Drug() { }
        public String name { get; set; }
        public String description { get; set; }
        public String famille { get; set; }
        public int quantite { get; set; }
        public decimal prix { get; set; }



        public Drug(String name, String description, String famille, int quantite , decimal prix)
        {
            this.name = name;
            this.description = description;
            this.famille = famille;
            this.prix = prix;
            this.quantite = quantite;

        }
    }
}
