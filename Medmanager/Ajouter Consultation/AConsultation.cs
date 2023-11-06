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
            connection.LoadPatients(listBox1);
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
                if (listBox1.SelectedItem != null)
                {
                    string selectedClientInfo = listBox1.SelectedItem.ToString();

                    string[] clientInfos = selectedClientInfo.Split('-');
                    string idString = clientInfos[1].Trim();
                    int selectedId = int.Parse(idString);
                    string typeConsultation = textBox1.Text;
                    string commentaire = textBox3.Text;
                    DateTime dateConsultation = dateTimePicker2.Value;

                    connection.InsertDataConsultation(selectedId, typeConsultation, dateConsultation, commentaire, listBox1);
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un client.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion des données de consultation : " + ex.Message);
            }
        }
    }
}
