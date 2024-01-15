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
    public partial class Main : Form
    {

        public int MedecinId { get; private set; }
        
        private string login; 
        private string password;
        private string hashedPassword;
        private Connection_DB conn = new Connection_DB();
        public Main()
        {
            InitializeComponent();
            conn.Open();
 
        }

        private void loadIDmedecin()
        {
         MedecinId = conn.GetMedecinId(login);

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            login = textBox1.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hashedPassword = Register.HashMotDePass(password);
            try
            {
               
                if (conn.Connexion(login,hashedPassword)) 
                {
                    loadIDmedecin();
                    MainMenu mainMenu = new MainMenu(MedecinId);
                    mainMenu.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Identifiant ou Mot De Passe incorrect");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show(this);
            this.Hide();
        }
    }
}
