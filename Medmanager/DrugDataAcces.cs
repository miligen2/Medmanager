using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medmanager
{
    internal class DrugDataAcces
        
    {
        private List<Drug> drugs = new List<Drug>();
        public void addDrug(Drug drug)
        {
            this.drugs.Add(drug);
        }
        public void deleteDrug(Drug drug)
        {
            this.drugs.Remove(drug);
        }
        
        public List<Drug> getDrugList() {  return this.drugs; }
    }
}
