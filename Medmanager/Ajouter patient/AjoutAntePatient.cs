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
        public AjoutAntePatient()
        {
            InitializeComponent();
            conn.Open();
            LoadPatient();
            LoadAntecent();
            
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
                // Récupérer l'ID du patient sélectionné
                idPatient = conn.GetPatientsFromDatabase()[comboBox1.SelectedIndex].id;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            conn.InsertAntecedentInpatient(idPatient, idAntecedent);
            comboBox2.ResetText();
        }
    }
}
