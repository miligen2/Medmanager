using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Medmanager
{
    public partial class Register : Form
    {
        private Connection_DB conn = new Connection_DB();
        private string prenom, nom, login, password, cPassword, hashedPassword;

        public Register()
        {
            InitializeComponent();
            conn.Open();
        }

        public static string HashMotDePass(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertir le mot de passe en tableau de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertir le tableau de bytes en une chaîne hexadécimale
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if (login != null && password != null && cPassword !=null && prenom!=null && nom!=null) 
                {
                    if (password == cPassword)
                    {
                        hashedPassword = HashMotDePass(password);
                        conn.InsertMedecin(nom, prenom, login, hashedPassword);
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe différent. Veuillez réessayer. ");
                    }

                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                }
            
            
            } catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);

            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main main = new Main();
            main.Show(this);
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            login = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            cPassword = textBox3.Text;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            prenom = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            nom = textBox5.Text;
        }
    }
}
