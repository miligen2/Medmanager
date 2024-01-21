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
    public partial class ConsulterAntecedent : Form
    {
        Connection_DB conn = new Connection_DB();
        private int medecinId;
        public ConsulterAntecedent(int medecinId)
        {
            InitializeComponent();
            conn.Open();
            
            LoadPatient();
            this.medecinId = medecinId;
        }
        private int idPatient;
        private void LoadPatient()
        {
            List<Patient> pat = conn.GetPatientsFromDatabase();
            comboBox1.Items.Clear();
            foreach (Patient patItem in pat)
            {
                string onePatient = $"{patItem.Nom} {patItem.Prenom}, {patItem.Sexe}";
                comboBox1.Items.Add(onePatient);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                idPatient = conn.GetPatientsFromDatabase()[comboBox1.SelectedIndex].id;
                conn.getAntecedentFromIdPatient(idPatient, dataGridView1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsulterAntecedent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vérifiez si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenez l'index de la ligne sélectionnée
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Obtenez la valeur de la colonne "Nom" de la ligne sélectionnée
                string nomAntecedent = dataGridView1.Rows[selectedIndex].Cells["Nom"].Value.ToString();

                conn.DeletAntecedent(nomAntecedent, idPatient);

                // Rafraîchissez le DataGridView après la suppression
                conn.getAntecedentFromIdPatient(idPatient, dataGridView1);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu(medecinId);
            menu.Show(this);
        }
    }
}
