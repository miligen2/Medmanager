using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medmanager.Ajouter_medicament;
using Medmanager.Ajouter_patient;
using MySql.Data.MySqlClient;





namespace Medmanager
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

      
            Connection_DB connection = new Connection_DB();
            connection.Open();

            int numberOfPatients = connection.GetNumberOfPatients();
            label3.Text = $"Nombre de patient : {numberOfPatients}";

        }

        private void consultationMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMedicament lMedicament = new LMedicament();
            lMedicament.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }


        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void ajoutMédicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AMedicament aMedicament = new AMedicament();
            aMedicament.Show();
        }

        private void ajouterPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APatient aPatient = new APatient();
            aPatient.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void consulterPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPatient cPatient = new CPatient();
            cPatient.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

 
        private void medicamentParFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercheMedicament rechercheMedicament = new RechercheMedicament(); rechercheMedicament.Show();
        }

        private void créerUneOrdonnanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AOrdonnance aOrdonnance = new AOrdonnance();
            aOrdonnance.Show();
        }
    }
}
