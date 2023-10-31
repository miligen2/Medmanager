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
    public partial class FormDetails : Form
    {
        public FormDetails(string name, string description)
        {
            InitializeComponent();
            this.textBox1.Text = name;
            this.textBox2.Text = description;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            string description = this.textBox2.Text;

            this.Close();
        }
    }
}
