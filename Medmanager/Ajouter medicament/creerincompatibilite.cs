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

namespace Medmanager.Ajouter_medicament
{
    public partial class creerincompatibilite : Form
    {
        private Connection_DB connection = new Connection_DB();
        private int selectedMedicamentId;
        private int selectedMedicamentId2;
        private int medecinId;
        private int idAllergies;
        private int idAntecedent;
        public creerincompatibilite(int medecinId)
        {
            InitializeComponent();
            connection.Open();

            LoadMedicament();
            LoadAllergie();
            LoadAntecent();

            this.medecinId = medecinId;
        }

        private void LoadMedicament()
        {
            List<Medicament> medicaments = connection.GetMedicamentList();
            comboBox1.Items.Clear();
            foreach (Medicament medicament in medicaments)
            {
                comboBox1.Items.Add(medicament.name);
                comboBox4.Items.Add(medicament.name);
            }
        }
        private void LoadAllergie()
        {
            List<Allergie> allergies = connection.GetAllergies();
            comboBox2.Items.Clear();
            foreach (Allergie allergie in allergies)
            {
                comboBox2.Items.Add(allergie.Name);
            }

        }
        private void LoadAntecent()
        {
            List<Antecedent> antecedents = connection.GetAntecedent();
            comboBox3.Items.Clear();
            foreach (Antecedent antecedent in antecedents)
            {
                comboBox3.Items.Add(antecedent.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (comboBox1.SelectedIndex >= 0)
                {

                    // Récupérez le nom du médicament sélectionné
                    string selectedMedicamentName = comboBox1.SelectedItem.ToString();

                    // Utilisez la méthode GetMedicamentIdByName pour obtenir l'ID du médicament
                     selectedMedicamentId = connection.GetMedicamentIdByName(selectedMedicamentName);

                }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu(medecinId);
            menu.Show(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifie si une sélection valide a été faite
            if (comboBox2.SelectedIndex >= 0 && comboBox2.SelectedIndex < connection.GetAllergies().Count)
            {
                // Obtenir l'ID de l'allergie sélectionnée à partir de la liste des allergies
                idAllergies = connection.GetAllergies()[comboBox2.SelectedIndex].id;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifie si une sélection valide a été faite
            if (comboBox3.SelectedIndex >= 0)
            {
                // Obtenir l'ID de l'antécédent sélectionné à partir de la liste des antécédents
                idAntecedent = connection.GetAntecedent()[comboBox3.SelectedIndex].id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifiez si l'incompatibilité existe déjà
                if (connection.CheckExistingIncompatibility(idAntecedent, selectedMedicamentId, idAllergies, selectedMedicamentId2))
                {
                    // Affichez un message d'erreur si l'incompatibilité existe déjà
                    MessageBox.Show("Cette incompatibilité existe déjà.", "Erreur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Si l'incompatibilité n'existe pas, effectuez l'insertion
                    connection.InsertIncompatibilite(idAllergies, idAntecedent, selectedMedicamentId, selectedMedicamentId2);

                    // Affichez un message de réussite si l'opération a réussi
                    MessageBox.Show("L'incompatibilité a été ajoutée avec succès.", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur en cas d'exception
                Console.WriteLine(ex.Message);

                MessageBox.Show("Une erreur s'est produite lors de l'ajout de l'incompatibilité.", "Erreur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex >= 0)
            {

                // Récupérez le nom du médicament sélectionné
                string selectedMedicamentName = comboBox4.SelectedItem.ToString();

                // Utilisez la méthode GetMedicamentIdByName pour obtenir l'ID du médicament
                selectedMedicamentId2 = connection.GetMedicamentIdByName(selectedMedicamentName);

            }
        }
    }
}
