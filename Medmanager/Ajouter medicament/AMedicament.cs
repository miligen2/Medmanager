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
        Connection_DB connection = new Connection_DB();

        public AMedicament()
        {
            InitializeComponent();
        }


        private void buttonValider_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Veuillez remplir les champs");
                return;
            }

            string nom = textBox1.Text;
            string description = textBox2.Text;
            int quantite = (int)numericUpDown1.Value;
            decimal prix = numericUpDown2.Value;

           
            if (connection.Open())
            {

                connection.InsertDataMedicament(nom, description, quantite, prix);

                connection.Close();
            }

     

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
