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
using Medmanager.model;
using MySql.Data.MySqlClient;





namespace Medmanager
{
    public partial class MainMenu : Form
    {
        private int medecinId;
        Connection_DB connection = new Connection_DB();
        public MainMenu(int medecinId)
        {
            InitializeComponent();

            this.medecinId = medecinId;
      
            connection.Open();

            int numberOfPatients = connection.GetNumberOfPatients();
            label3.Text = $"Nombre de patient : {numberOfPatients}";
            NameMedecin();

        }

        private void NameMedecin()
        {
            string nameMedecin = connection.GetNomFromId(medecinId);
            label2.Text = $"Bonjour, Dr {nameMedecin}";
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
            AOrdonnance aOrdonnance = new AOrdonnance(medecinId);
            aOrdonnance.Show();
        }

        private void ajouterUnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutAntePatient ajoutAntePatient = new AjoutAntePatient();
            ajoutAntePatient.Show();
        }

        private void ajouterUneAllérgieÀUnPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutAllergiesPatient ajoutAllergiesPatient = new AjoutAllergiesPatient();
            ajoutAllergiesPatient.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
