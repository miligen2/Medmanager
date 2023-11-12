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
            conn.ReadMedicament(dataGridView1);

            // Parcourez toutes les lignes de la DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
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
            dataGridView1.Refresh();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Assurez-vous qu'une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenez la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

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
