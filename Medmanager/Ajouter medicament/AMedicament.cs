using Microsoft.SqlServer.Server;
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
    public partial class AMedicament : Form
    {
        private DrugDataAcces dataAccess= new DrugDataAcces();
            
        public AMedicament()
        {
            InitializeComponent();
        }


        private void buttonValider_Click(object sender, EventArgs e)
        {
            Drug drug = new Drug(this.textBox1.Text, this.textBox2.Text);
            dataAccess.addDrug(drug);
            updateDataGridView();

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            

            
        }
        public void updateDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = dataAccess.getDrugList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Récupérer les valeurs des cellules de la ligne sélectionnée
                
                string name = selectedRow.Cells["Name"].Value.ToString();
                string description = selectedRow.Cells["Description"].Value.ToString();
                

                // Afficher les détails de la ligne dans une fenêtre modale
                FormDetails formDetails = new FormDetails(name, description);
                formDetails.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}
