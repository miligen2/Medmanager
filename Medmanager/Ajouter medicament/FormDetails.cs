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
            comboBox1.Text = selectedRow.Cells["contre_indiction"].Value.ToString();

            medicamentID = Convert.ToInt32(selectedRow.Cells["id"].Value);
        }
        public FormDetails()
        {
            InitializeComponent();
            conn.Open();
            LoadAntecedent();
        }

        public void LoadAntecedent()
        {
            List<Antecedent> antecedents = conn.GetAntecedent();
            comboBox1.Items.Clear();
            foreach(Antecedent ant in antecedents)
            {
                comboBox1.Items.Add(ant.Name);
            }


        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérez les valeurs modifiées
                string newNom = textBox1.Text;
                string newIndication = comboBox1.Text;

                // Appelez la méthode UpdateMedicament pour effectuer la mise à jour
                conn.UpdateMedicament(medicamentID, newNom, newIndication);

                // Fermez le formulaire après la mise à jour
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suppr_Click(object sender, EventArgs e)
        {
            conn.DeletMedicament(medicamentID);
            this.Close();
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
