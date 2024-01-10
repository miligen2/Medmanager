using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medmanager
{
    internal class DrugDataAcces
        
    {
        private List<Medicament> drugs = new List<Medicament>();
        public void addDrug(Medicament drug)
        {
            this.drugs.Add(drug);
        }
        public void deleteDrug(Medicament drug)
        {
            this.drugs.Remove(drug);
        }
        
        public List<Medicament> getDrugList() {  return this.drugs; }
    }
}
