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
            this.Hide();
            LMedicament lMedicament = new LMedicament(medecinId);
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
            this.Hide();
            AMedicament aMedicament = new AMedicament(medecinId);
            aMedicament.Show();
        }

        private void ajouterPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            APatient aPatient = new APatient(medecinId);
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
            this.Hide();
            CPatient cPatient = new CPatient(medecinId);
            cPatient.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

 

        private void créerUneOrdonnanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AOrdonnance aOrdonnance = new AOrdonnance(medecinId);
            aOrdonnance.Show();
        }

        private void ajouterUnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjoutAntePatient ajoutAntePatient = new AjoutAntePatient(medecinId);
            ajoutAntePatient.Show();
        }

        private void ajouterUneAllérgieÀUnPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjoutAllergiesPatient ajoutAllergiesPatient = new AjoutAllergiesPatient(medecinId);
            ajoutAllergiesPatient.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void consulterAntécédentàUnPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsulterAntecedent consulterAntecedent = new ConsulterAntecedent(medecinId);
            consulterAntecedent.Show();
        }
    }
}
