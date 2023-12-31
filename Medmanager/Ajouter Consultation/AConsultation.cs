﻿using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medmanager
{
    public partial class AConsultation : Form
    {

        private Connection_DB connection = new Connection_DB();
        public AConsultation()
        {
            InitializeComponent();
            connection.Open();
            LoadPatients();
        }
        private void LoadPatients()
        {
            connection.ReadPatients(dataGridView1);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Récupérer les informations du client sélectionné dans la dataGridView1
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int clienId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    // Récupérer les informations de la consultation
                    string typeConsultation = textBox1.Text;
                    DateTime dateConsultation = dateTimePicker2.Value;
                    string commentaire = textBox3.Text;

                    // Insérer les données de la consultation dans la base de données
                    connection.InsertDataConsultation(clienId, typeConsultation, dateConsultation, commentaire);

                    // Rafraîchir la liste des patients après l'insertion
                    LoadPatients();

                    // Effacer les champs de saisie
                    textBox1.Text = "";
                    textBox3.Text = "";
                    dateTimePicker2.Value = DateTime.Now;


                    MessageBox.Show("Consultation ajoutée avec succès.");
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un client dans la liste.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion des données de consultation : " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
