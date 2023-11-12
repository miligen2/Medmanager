using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medmanager.Ajouter_Consultation
{
    public partial class LConsultation : Form
    {

        Connection_DB connection = new Connection_DB();  
        public LConsultation()
        {
            InitializeComponent();
            connection.Open();
            LoadConsultationsWithPatients();
        }

        private void LoadConsultationsWithPatients()
        {
            connection.ReadConsultationsWithPatients(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            // Assurez-vous qu'une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenez la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Créez une instance du formulaire de modification
                FormConsultation formModifier = new FormConsultation();

                // Initialisez le formulaire avec les données de la ligne sélectionnée
                formModifier.InitializeForm(selectedRow);

                // Affichez le formulaire de modification
                formModifier.ShowDialog();

                // Rafraîchissez la DataGridView après la modification (si nécessaire)
                LoadConsultationsWithPatients();
            }
        }
    }
}
