using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medmanager.model
{
    internal class Allergie
    {
        public int id { get; set; }
      public string Name { get; set; }
      public Allergie(int id, string name) {
            this.id = id;
            this.Name = name;
        }
    }
}
