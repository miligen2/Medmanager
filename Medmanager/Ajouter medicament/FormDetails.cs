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

namespace Medmanager
{
    public partial class FormDetails : Form
    {
        private int medicamentID;
        private Connection_DB conn = new Connection_DB();

        public void InitializeForm(DataGridViewRow selectedRow)
        {
            // Initialisez les contrôles avec les données de la ligne sélectionnée
            textBox1.Text = selectedRow.Cells["nom"].Value.ToString();
            textBox2.Text = selectedRow.Cells["description"].Value.ToString();
            textBoxFamille.Text = selectedRow.Cells["famille"].Value.ToString();
            numericUpDownQuantité.Value = Convert.ToDecimal(selectedRow.Cells["quantite"].Value);
            numericUpDownPrix.Value = Convert.ToDecimal(selectedRow.Cells["prix"].Value);

            medicamentID = Convert.ToInt32(selectedRow.Cells["id"].Value);

            if ((int)numericUpDownQuantité.Value == 0)
            {
                // Affichez la ligne en rouge
                numericUpDownQuantité.BackColor = Color.Red;
            }
        }
        public FormDetails()
        {
            InitializeComponent();
            conn.Open();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérez les valeurs modifiées
                string newNom = textBox1.Text;
                string newDescription = textBox2.Text;
                string newFamille = textBoxFamille.Text;
                int newQuantite = (int)numericUpDownQuantité.Value;
                decimal newPrix = numericUpDownPrix.Value;

                // Appelez la méthode UpdateMedicament pour effectuer la mise à jour
                conn.UpdateMedicament(medicamentID, newNom, newDescription,newFamille, newQuantite, newPrix);

                // Fermez le formulaire après la mise à jour
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void numericUpDownQuantité_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownPrix_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void suppr_Click(object sender, EventArgs e)
        {
            conn.DeletMedicament(medicamentID);
            this.Close();
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFamille_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
