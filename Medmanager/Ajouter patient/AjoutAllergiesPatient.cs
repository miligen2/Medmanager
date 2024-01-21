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

    public partial class AjoutAllergiesPatient : Form
    {
        private Connection_DB conn = new Connection_DB();

        private int medecinId;

        private int idPatient;
        private int idAllergies;

        public AjoutAllergiesPatient(int medecinId)
        {
            InitializeComponent();
            conn.Open();

            LoadPatient();
            LoadAllergie();
            this.medecinId = medecinId;
        }
        private void LoadAllergie()
        {
            List<Allergie> allergies = conn.GetAllergies();
            comboBox2.Items.Clear();
            foreach (Allergie allergie in allergies)
            {
                comboBox2.Items.Add(allergie.Name);
            }

        }
        private void LoadPatient()
        {
            List<Patient> pat = conn.GetPatientsFromDatabase();
            comboBox1.Items.Clear();
            foreach (Patient patItem in pat)
            {
                string onePatient = $"{patItem.Nom} {patItem.Prenom} {patItem.Sexe}";
                comboBox1.Items.Add(onePatient);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0 && comboBox2.SelectedIndex < conn.GetAllergies().Count)
            {
                idAllergies = conn.GetAllergies()[comboBox2.SelectedIndex].id;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox1.SelectedIndex < conn.GetPatientsFromDatabase().Count)
            {
                idPatient = conn.GetPatientsFromDatabase()[comboBox1.SelectedIndex].id;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            conn.InsertAllergiesIntoPatient(idAllergies, idPatient);
            comboBox2.ResetText();
        }

        private void AjoutAllergiesPatient_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainMenu menu = new MainMenu(medecinId);
            menu.Show(this);

        }
    }
}
