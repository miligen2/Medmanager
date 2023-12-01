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
    public partial class RechercheMedicament : Form
    {
        private Connection_DB conn = new Connection_DB();
        public RechercheMedicament()
        {
            InitializeComponent();
            conn.Open();
            LoadFamilies();
        }
        private void LoadFamilies()
        {
            // Chargez les types de famille uniques depuis la base de données
            List<string> families = conn.GetUniqueFamilies();

            // Ajoutez les types de famille au ComboBox
            comboBoxFamilies.Items.AddRange(families.ToArray());
        }
        private void loadMedicament()
        {
            conn.ReadMedicament(dataGridViewMedicaments);

            // Parcourez toutes les lignes de la DataGridView
            foreach (DataGridViewRow row in dataGridViewMedicaments.Rows)
            {
                // Vérifiez si la colonne "quantite" a une valeur égale à zéro
                int quantite = Convert.ToInt32(row.Cells["quantite"].Value);
                if (quantite == 0)
                {
                    // Changez la couleur de fond de la ligne en rouge
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }

            // Mise à jour visuelle de la DataGridView
            dataGridViewMedicaments.Refresh();
        }

        private void RechercheMedicament_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxFamilies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFamily = comboBoxFamilies.SelectedItem.ToString();

            // Chargez les médicaments de la famille sélectionnée depuis la base de données
            conn.ReadMedicamentsByFamily(dataGridViewMedicaments, selectedFamily);
        }

        private void dataGridViewMedicaments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // On regarde si une ligne est sélectionnée
            if (dataGridViewMedicaments.SelectedRows.Count > 0)
            {
                // Obtenez la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridViewMedicaments.SelectedRows[0];

                // Créez une instance du formulaire de modification
                FormDetails formModifier = new FormDetails();

                // Initialisez le formulaire avec les données de la ligne sélectionnée
                formModifier.InitializeForm(selectedRow);

                // Affichez le formulaire de modification
                formModifier.ShowDialog();

                // Rafraîchissez la DataGridView après la modification (si nécessaire)
                loadMedicament();
            }
        }
    }
}

