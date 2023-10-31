using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medmanager
{
    internal class Drug
    {
        public String Name { get; set; }
        public String Description { get; set; }

        public Drug(String name, String description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
