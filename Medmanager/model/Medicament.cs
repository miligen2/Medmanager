using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medmanager
{
    internal class Medicament
    {
        public Medicament() { }
        public String name { get; set; }
        public String contreIndiction { get; set; }
      



        public Medicament(String name, String contreIndiction)
        {
            this.name = name;
            this.contreIndiction = contreIndiction;
        }
    }
}
