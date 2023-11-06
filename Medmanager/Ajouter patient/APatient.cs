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
    public partial class APatient : Form
    {
        public APatient()
        {
            InitializeComponent();
        }

        private string nom;
        private string prenom;
        private string email;
        private string numero;
        private string codePostal;
        private DateTime dateEntree;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            prenom = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nom = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            email = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            numero = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            codePostal = textBox5.Text;
        }


        private void buttonValider_Click_1(object sender, EventArgs e)
        {
            Connection_DB connection = new Connection_DB();

            if (connection.Open())
            {

                connection.InsertDataPatient(nom, prenom, email, numero, codePostal, dateEntree);

                connection.Close();
            }
        }

        private void buttonAnnuler_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateEntree = dateTimePicker1.Value;
        }
    }
}
