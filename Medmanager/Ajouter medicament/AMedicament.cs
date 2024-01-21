﻿using Medmanager.model;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Medmanager
{
    public partial class AMedicament : Form
    {
        private Connection_DB connection = new Connection_DB();
        private int medecinId;

        public AMedicament(int medecinId)
        {
            InitializeComponent();
            connection.Open(); 
            LoadAntecedent();
            this.medecinId = medecinId;
        }
        private void LoadAntecedent()
        {
            List<Antecedent> antecedents = connection.GetAntecedent();
            comboBox1.Items.Clear();
            foreach (Antecedent ant in antecedents)
            {
                comboBox1.Items.Add(ant.Name);
            }
            connection.GetAntecedent();
        }


        private void buttonValider_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0 || comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }

            string nom = textBox1.Text;
            string indication = comboBox1.Text;

            connection.InsertDataMedicament(nom, indication);


            textBox1.Text = string.Empty;


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AMedicament_Load(object sender, EventArgs e)
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
