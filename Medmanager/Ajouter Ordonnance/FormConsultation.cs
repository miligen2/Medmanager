using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medmanager.Ajouter_Consultation
{
    public partial class FormConsultation : Form
    {
        private int consultationID;
        private Connection_DB conn = new Connection_DB();
        public void InitializeForm(DataGridViewRow selectedRow)
        {
            textBox1.Text = selectedRow.Cells["commentaire"].Value.ToString();
            textBox3.Text = selectedRow.Cells["typeConsultation"].Value.ToString();
            dateTimePicker2.Value = (DateTime)selectedRow.Cells["dateConsultation"].Value;

            consultationID = Convert.ToInt32(selectedRow.Cells["id"].Value);
            
        }

        public FormConsultation()
        {
            InitializeComponent();
            conn.Open();
            loadPatient(); 
            
        }
        private void loadPatient()
        {
           // conn.ReadPatients(dataGridView1);
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                string newCommentaire = textBox1.Text;
                string newTypeConsultation = textBox3.Text;
                DateTime newDateConsultation = dateTimePicker2.Value;

                // Appelez la méthode de mise à jour avec les nouvelles valeurs
                conn.UpdateConsultation(consultationID, newTypeConsultation, newCommentaire, newDateConsultation);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
