using Medmanager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Medmanager.Ajouter_patient
{
    public partial class CPatient : Form
    {
        private Connection_DB connection = new Connection_DB();

        public CPatient()
        {
            InitializeComponent();
            connection.Open();
            LoadPatients();
        }
        private void CPatient_Load(object sender, EventArgs e)
        {

        }

        private void LoadPatients()
        {
            connection.ReadPatients(dataGridView1);
        }




        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenez la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Créez une instance du formulaire de modification
                FormModifier formModifier = new FormModifier();

                // Initialisez le formulaire avec les données de la ligne sélectionnée
                formModifier.InitializeForm(selectedRow);

                // Affichez le formulaire de modification
                formModifier.ShowDialog();

                // Rafraîchissez la DataGridView après la modification (si nécessaire)
                LoadPatients();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
