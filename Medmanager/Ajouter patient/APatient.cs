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
    public partial class APatient : Form
    {

        private Connection_DB conn = new Connection_DB();
        public APatient()
        {
            InitializeComponent();
            conn.Open();

        }



        private string nom;
        private string prenom;
        private string sexe;
        private string numero;

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
            sexe = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            numero = textBox4.Text;
        }

        private void buttonValider_Click_1(object sender, EventArgs e)
        {
                conn.InsertDataPatient(nom, prenom, sexe, numero);
                Console.WriteLine("valeur ajouté avec succés");
        }


    }
}
