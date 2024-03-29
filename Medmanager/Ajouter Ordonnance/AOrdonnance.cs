﻿    using Medmanager.model;
    using MySqlX.XDevAPI;
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Common;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Aspose.Pdf;
    using Aspose.Pdf.Text;


    namespace Medmanager
    {
        public partial class AOrdonnance : Form
        {

            private Connection_DB connection = new Connection_DB();

            private Patient selectedPatient;
            private string posologie;
            private decimal duree;
            private string instruction;
            private int medecinId;
            int selectedMedicationId;

            public AOrdonnance(int medecinId)
            {
                InitializeComponent();
                this.medecinId = medecinId;


                connection.Open();

                LoadPatients();
                LoadMedicament();// Appel de la méthode pour charger les patients dans le ComboBox
                IdMedecin();
                dataGridView1.Columns.Add("MedicamentColumn", "Médicament");

            }

            private void IdMedecin()
            {

                string nameMedecin = connection.GetNomFromId(medecinId);

                label5.Text = $"Dr {nameMedecin}";
            }
            private void LoadMedicament()
            {
                List<Medicament> medicaments = connection.GetMedicamentList();
                comboBox2.Items.Clear();
                foreach (Medicament medicament in medicaments)
                {
                    comboBox2.Items.Add(medicament.name);
                }
            }
            private void LoadPatients()
            {
                List<Patient> patients = connection.GetPatientsFromDatabase();
                comboBox1.Items.Clear(); // Efface les éléments précédents du ComboBox
                foreach (Patient pat in patients)
                {
                    string patientInfos = $"{pat.Nom} {pat.Prenom} {pat.Sexe}";
                    comboBox1.Items.Add(patientInfos);
                }
            }
            private void LoadAllergie()
            {
                connection.GetPatientAllergieByID(selectedPatient.id,dataGridView2);


                // Mise à jour visuelle de la DataGridView
                dataGridView1.Refresh();
            }

            private void GeneratePDF()
            {
                try
                {
                    // Créer un nouveau document PDF
                    Document pdfDocument = new Document();

                    // Ajouter une page au document
                    Page page = pdfDocument.Pages.Add();

                    // Ajouter du texte au PDF
                    TextFragment objetTextFragment = new TextFragment();
                    objetTextFragment.Text = "OBJET : Ordonnance médicale";
                    objetTextFragment.Position = new Position(50, 780);
                    objetTextFragment.TextState.FontSize = 14;
                    page.Paragraphs.Add(objetTextFragment);

                    TextFragment medecinTextFragment = new TextFragment();
                    string nameMedecin = connection.GetNomFromId(medecinId);
                    medecinTextFragment.Text = $" Dr {nameMedecin}";
                    medecinTextFragment.Position = new Position(50, 750);
                    page.Paragraphs.Add(medecinTextFragment);

                    TextFragment titleTextFragment = new TextFragment();
                    titleTextFragment.Text = $"Ordonnance médicale pour {selectedPatient.Nom} {selectedPatient.Prenom}";
                    titleTextFragment.Position = new Position(50, 720);
                    titleTextFragment.TextState.FontSize = 18;
                    page.Paragraphs.Add(titleTextFragment);

                    TextFragment lineTextFragment = new TextFragment();
                    lineTextFragment.Text = "---------------------------------------------------";
                    lineTextFragment.Position = new Position(50, 700);
                    page.Paragraphs.Add(lineTextFragment);

                    TextFragment posologieTextFragment = new TextFragment();
                    posologieTextFragment.Text = $"Posologie: {posologie}";
                    posologieTextFragment.Position = new Position(50, 680);
                    page.Paragraphs.Add(posologieTextFragment);

                    TextFragment dureeTextFragment = new TextFragment();
                    dureeTextFragment.Text = $"Durée: {duree} jours";
                    dureeTextFragment.Position = new Position(50, 660);
                    page.Paragraphs.Add(dureeTextFragment);

                    TextFragment instructionTextFragment = new TextFragment();
                    instructionTextFragment.Text = $"Instructions: {instruction}";
                    instructionTextFragment.Position = new Position(50, 640);
                    page.Paragraphs.Add(instructionTextFragment);

                    TextFragment lineTextFragment2 = new TextFragment();
                    lineTextFragment2.Text = "---------------------------------------------------";
                    lineTextFragment2.Position = new Position(50, 620);
                    page.Paragraphs.Add(lineTextFragment2);

                    TextFragment medicationsTextFragment = new TextFragment();
                    medicationsTextFragment.Text = "Liste des médicaments :";
                    medicationsTextFragment.Position = new Position(50, 600);
                    medicationsTextFragment.TextState.FontSize = 14;
                    page.Paragraphs.Add(medicationsTextFragment);

                    int yPosition = 580;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string medicationName = row.Cells["MedicamentColumn"].Value as string;
                        TextFragment medicationTextFragment = new TextFragment();
                        medicationTextFragment.Text = $"- {medicationName}";
                        medicationTextFragment.Position = new Position(50, yPosition);
                        page.Paragraphs.Add(medicationTextFragment);
                        yPosition -= 20;
                    }

                    // Obtenez le nom complet du patient
                    string nomPatient = $"{selectedPatient.Nom}_{selectedPatient.Prenom}";

                // Concaténez le nom du patient avec le nom du fichier PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = $"ordonnance_{nomPatient}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Enregistrez le PDF avec le nouveau nom de fichier
                    pdfDocument.Save(saveFileDialog.FileName);
                    MessageBox.Show("Document PDF créé avec succès !");
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Oups une erreur est survenue, veuillez réessayer");
                    Console.WriteLine("Erreur lors de la création du fichier PDF : " + ex.Message);
                }
            }



            private void Form1_Load(object sender, EventArgs e)
            {

            }


        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer l'ID du patient sélectionné
                int idPatient = selectedPatient.id;

                // Parcourir chaque ligne du DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Obtenir le nom du médicament à partir de la cellule "MedicamentColumn"
                    string medicationName = row.Cells["MedicamentColumn"].Value as string;

                    // Obtenir l'ID du médicament en utilisant le nom du médicament
                    int idMedicament = connection.GetMedicamentIdByName(medicationName);

                    // Insérer les données d'ordonnance dans la base de données
                    connection.InsertOrdonnance(posologie, duree, instruction, medecinId, idPatient, idMedicament);
                }

                // Générer le document PDF après l'insertion des données
                GeneratePDF();

                // Afficher un message de succès
                MessageBox.Show("Ordonnance insérée avec succès !");
            }
            catch (Exception ex)
            {
                // Afficher un message d'erreur en cas d'exception
                MessageBox.Show("Oups une erreur est survenue, veuillez réessayer.");

                // Afficher les détails de l'erreur dans la console
                Console.WriteLine("Erreur lors de l'insertion des données d'ordonnance : " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                int selectedIndex = comboBox1.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < comboBox1.Items.Count)
                {
                    selectedPatient = connection.GetPatientsFromDatabase()[selectedIndex];
                    LoadAllergie();
                }
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {
                posologie= textBox1.Text;
            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {
                instruction= textBox2.Text;
            }

            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            {
                duree = numericUpDown1.Value;
            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                try 
                { 
                    // Récupérer le médicament sélectionné depuis comboBox2
                    string selectedMedication = comboBox2.SelectedItem as string;

                    // Vérifier si un médicament est sélectionné
                    if (!string.IsNullOrEmpty(selectedMedication))
                    {
                        // Obtenir l'ID du médicament sélectionné à partir de la base de données
                        selectedMedicationId = connection.GetMedicamentIdByName(selectedMedication);
                        // Vérifier si le patient est allergique au médicament sélectionné
                        bool hasAllergy = connection.getAllergieMedicament(selectedPatient.id, selectedMedicationId);

                        if (hasAllergy)
                        {
                            // Afficher une boîte de dialogue demandant si le médecin souhaite procéder
                            DialogResult result = MessageBox.Show("Le patient a une allergie à ce médicament. Voulez-vous quand même l'ajouter à l'ordonnance ?", "Allergie au médicament", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                // Ajouter le médicament sélectionné à la DataGridView
                                dataGridView1.Rows.Add(selectedMedication);
                            }
                        }
                        else
                        {
                            // Ajouter le médicament sélectionné à la DataGridView
                            dataGridView1.Rows.Add(selectedMedication);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oups une erreur est survenue lors de l'ajout du médicament à l'ordonnance. Détails : " + ex.Message);
                    Console.WriteLine("Erreur lors de l'ajout du médicament à l'ordonnance : " + ex.Message);
                }
            }

            private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu(medecinId);
            menu.Show(this);
        }
    }
    }
