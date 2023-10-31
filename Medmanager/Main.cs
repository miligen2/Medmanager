using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Medmanager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            MySqlConnection conn = new MySqlConnection("database=medmanager; server=localhost; user id=root; pwd=");
            try 
            { 
                conn.Open();
            }
            catch {  }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void consultationMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test"); 
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
         
        }

        private void ajoutMédicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AMedicament aMedicament = new AMedicament();
            aMedicament.Show();
        }
    }
}
