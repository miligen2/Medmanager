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
    public partial class AjoutAntePatient : Form
    {
        private Connection_DB conn = new Connection_DB();
        private int medecinId;
        public AjoutAntePatient(int medecinId)
        {
            InitializeComponent();
            conn.Open();
            LoadPatient();
            LoadAntecent();
            this.medecinId = medecinId;
            
        }
        private int idPatient;
        private int idAntecedent;
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
        private void LoadAntecent()
        {
            List<Antecedent> antecedents = conn.GetAntecedent();
            comboBox2.Items.Clear();
            foreach (Antecedent antecedent in antecedents)
            {
                comboBox2.Items.Add(antecedent.Name);
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                idAntecedent = conn.GetAntecedent()[comboBox2.SelectedIndex].id;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                idPatient = conn.GetPatientsFromDatabase()[comboBox1.SelectedIndex].id;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            conn.InsertAntecedentInpatient(idPatient, idAntecedent);
            comboBox2.ResetText();
        }

        private void AjoutAntePatient_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
