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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medmanager.Ajouter_patient
{
    public partial class FormModifier : Form
    {
        private int patientID;
        private Connection_DB connection = new Connection_DB();

        public void InitializeForm(DataGridViewRow selectedRow)
        {
            // Set the values of the controls based on the selected patient

            // Initialisez les contrôles avec les données de la ligne sélectionnée
            textBoxNom.Text = selectedRow.Cells["nom"].Value.ToString();
            textBoxPrenom.Text = selectedRow.Cells["prenom"].Value.ToString();
            textBoxSexe.Text = selectedRow.Cells["sexe"].Value.ToString();
            textBoxNumero.Text = selectedRow.Cells["numero"].Value.ToString();
  
        

            patientID = Convert.ToInt32(selectedRow.Cells["id_patient"].Value);
        }

        public FormModifier()
        {
            InitializeComponent();
            connection.Open();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérez les valeurs modifiées
                string newNom = textBoxNom.Text;
                string newPrenom = textBoxPrenom.Text;
                string newSexe = textBoxSexe.Text;
                string newNumero = textBoxNumero.Text;
          

                // Appelez la méthode UpdatePatient pour effectuer la mise à jour
                connection.UpdatePatient(patientID, newNom, newPrenom,newSexe, newNumero);


                // Fermez le formulaire après la mise à jour
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Call the DeletPatient method to delete the patient
            connection.DeletPatient(patientID);
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
