using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medmanager.Ajouter_Consultation;
using Medmanager.Ajouter_medicament;
using MySql.Data.MySqlClient;





namespace Medmanager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

      
            Connection_DB connection = new Connection_DB();

            connection.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void supprimerConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supprimerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
         AConsultation aConsultation = new AConsultation();
            aConsultation.Show();
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
    }
}
