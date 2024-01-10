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
        string login, password;
        private Connection_DB conn = new Connection_DB();
        public Main()
        {
            InitializeComponent();
 
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.Connexion(login,password)) 
                {
                    MainMenu mainMenu = new MainMenu();
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
    }
}
