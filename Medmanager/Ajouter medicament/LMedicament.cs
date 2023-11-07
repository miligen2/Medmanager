using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medmanager.Ajouter_medicament
{
    public partial class LMedicament : Form
    {
        private Connection_DB conn = new Connection_DB();
        public LMedicament()
        {
            InitializeComponent();
            conn.Open();
            loadMedicament();
        }
        private void loadMedicament()
        {
            conn.ReadMedicament();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Connection_DB conn = new Connection_DB();

            List<Drug> medicamentList = conn.ReadMedicament();

            // Vider les données existantes dans le DataGridView
            dataGridView1.Rows.Clear();

            // Ajouter les nouvelles données au DataGridView
            foreach (Drug medicament in medicamentList)
            {
                dataGridView1.Rows.Add(medicament.name, medicament.description, medicament.quantite, medicament.prix);
            }
        }
    }
}
