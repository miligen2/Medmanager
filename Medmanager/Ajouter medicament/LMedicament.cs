using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medmanager.Ajouter_medicament
{
    public partial class LMedicament : Form
    {
        private Connection_DB conn = new Connection_DB();
        private int medecinId;
        public LMedicament(int medecinId)
        {
            InitializeComponent();
            conn.Open();
            loadMedicament();
            this.medecinId = medecinId;
        }
        private void loadMedicament()
        {
            conn.ReadMedicament(dataGridView1);


            // Mise à jour visuelle de la DataGridView
            dataGridView1.Refresh();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // On regarde si une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenez la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Créez une instance du formulaire de modification
                FormDetails formModifier = new FormDetails();

                // Initialisez le formulaire avec les données de la ligne sélectionnée
                formModifier.InitializeForm(selectedRow,medecinId);

                // Affichez le formulaire de modification
                formModifier.ShowDialog();

                // Rafraîchissez la DataGridView après la modification (si nécessaire)
                loadMedicament();
            }
        }

        private void LMedicament_Load(object sender, EventArgs e)
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
