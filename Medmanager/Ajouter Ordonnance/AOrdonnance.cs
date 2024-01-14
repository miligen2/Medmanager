using Medmanager.model;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medmanager
{
    public partial class AOrdonnance : Form
    {

        private Connection_DB connection = new Connection_DB();

        private Patient selectedPatient;
        private string posologie;
        private decimal duree;
        private string instruction;
        private int medecinId;

        public AOrdonnance(int medecinId)
        {
            InitializeComponent();
            this.medecinId = medecinId;


            connection.Open();

            LoadPatients();
            LoadMedicament();// Appel de la méthode pour charger les patients dans le ComboBox
            IdMedecin();
            dataGridView1.Columns.Add("MedicamentColumn", "Médicament");

        }

        private void IdMedecin()
        {

            string nameMedecin = connection.GetNomFromId(medecinId);

            label5.Text = $"Dr {nameMedecin}";
        }
        private void LoadMedicament()
        {
            List<Medicament> medicaments = connection.GetMedicamentList();
            comboBox2.Items.Clear();
            foreach (Medicament medicament in medicaments)
            {
                comboBox2.Items.Add(medicament.name);
            }
        }
        private void LoadPatients()
        {
            List<Patient> patients = connection.GetPatientsFromDatabase();
            comboBox1.Items.Clear(); // Efface les éléments précédents du ComboBox
            foreach (Patient pat in patients)
            {
                string patientInfos = $"{pat.Nom} {pat.Prenom} {pat.Sexe}";
                comboBox1.Items.Add(patientInfos);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                // Insérer les données d'ordonnance et récupérer l'id_ordonnance généré
                int idOrdonnance = connection.InsertOrdonnance(posologie, duree, instruction, medecinId, selectedPatient.id);

                // Ajouter les médicaments associés à l'ordonnance dans la base de données
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string medicationName = row.Cells["MedicamentColumn"].Value as string;

                    // Récupérer l'id_medicament à partir du nom du médicament
                    int idMedicament = connection.GetMedicamentIdByName(medicationName);

                    // Insérer l'association id_ordonnance - id_medicament dans la table de liaison
                    connection.InsertOrdonnanceMedicament(idOrdonnance, idMedicament);
                }

                MessageBox.Show("Ordonnance insérée avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion des données d'ordonnance : " + ex.Message);
                Console.WriteLine("Erreur lors de l'insertion des données d'ordonnance : " + ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < comboBox1.Items.Count)
            {
                selectedPatient = connection.GetPatientsFromDatabase()[selectedIndex];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            posologie= textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            instruction= textBox2.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            duree = numericUpDown1.Value;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected medication from comboBox2
            string selectedMedication = comboBox2.SelectedItem as string;

            // Check if a medication is selected
            if (!string.IsNullOrEmpty(selectedMedication))
            {
                // Add the selected medication to the DataGridView
                dataGridView1.Rows.Add(selectedMedication);
            }
        }
    }
}
