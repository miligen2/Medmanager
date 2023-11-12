using Medmanager.model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Medmanager
{
    internal class Connection_DB
    //La classe Connection_DB est actuellement définie comme internal,
    //ce qui signifie qu'elle est accessible uniquement à l'intérieur de l'assembly où elle est déclarée.*
    {

        MySqlConnection conn;
        string connectionString;

        public Connection_DB()
        {
            string server = "localhost";
            string database = "medmanager";
            string user = "root";
            string password = "";

            connectionString = $"server={server};database={database};user={user};password={password}";
            conn = new MySqlConnection(connectionString);
        }

        public bool Open()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connexion à la base de données MySQL réussie !");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la connexion à la base de données MySQL : " + ex.Message);
            }
            return false;
        }

        public void Close()
        {
            conn.Close();
            Console.WriteLine("Connexion à la base de données MySQL fermée.");
        }




        // main =
        public int GetNumberOfConsultations()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM consultations";
                MySqlCommand command = new MySqlCommand(query, conn);
                int numberOfConsultations = Convert.ToInt32(command.ExecuteScalar());
                return numberOfConsultations;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération du nombre de consultations : " + ex.Message);
                return 0; // Return 0 in case of an error
            }
        }

        public int GetNumberOfPatients()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM clients";
                MySqlCommand command = new MySqlCommand(query, conn);
                int numberOfPatients = Convert.ToInt32(command.ExecuteScalar());
                return numberOfPatients;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération du nombre de patients : " + ex.Message);
                return 0; // Return 0 in case of an error
            }
        }

        //fin main 

        //patient 
        public void InsertDataPatient(string nom, string prenom, string email, string numero, string code_postal, DateTime date_entree)
        {
            try
            {
                string query = "INSERT INTO clients (nom, prenom, email, numero, CP, dateEntree) VALUES (@nom, @prenom, @email, @numero, @code_postal, @date)";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@code_postal", code_postal);
                command.Parameters.AddWithValue("@date", date_entree);

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine($"Nombre de lignes insérées : {rowsAffected}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion des données : " + ex.Message);
            }
        }
        public void ReadPatients(DataGridView dataGridView)
        {
            try
            {
                string query = "SELECT * FROM clients";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView.DataSource = table;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du chargement des patients : " + ex.Message);
            }
        }
        public void DeletPatient(int patientID)
        {
            try
            {
                // Écrivez ici le code pour supprimer le patient de la base de données en utilisant l'ID
                // Assurez-vous de prendre des précautions pour éviter les problèmes de suppression (comme la vérification des dépendances).

                string query = "DELETE FROM clients WHERE id = @patientID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientID", patientID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Patient supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du patient : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public void UpdatePatient(int patientID, string newNom, string newPrenom, string newNumero, string newCodePostal, string newEmail)
        {
            try
            {
                string query = "UPDATE clients SET nom = @newNom, prenom = @newPrenom, numero = @newNumero, email = @newEmail, CP = @newCodePostal WHERE id = @patientID";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@newNom", newNom);
                command.Parameters.AddWithValue("@newPrenom", newPrenom);
                command.Parameters.AddWithValue("@newNumero", newNumero);
                command.Parameters.AddWithValue("@newCodePostal", newCodePostal);
                command.Parameters.AddWithValue("@newEmail", newEmail);
                command.Parameters.AddWithValue("@patientID", patientID);

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine($"Nombre de lignes mises à jour : {rowsAffected}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la mise à jour des données du patient : " + ex.Message);
            }
        }
//fin patient 

        public void InsertDataMedicament(string nom, string description, int quantite, decimal prix)
        {
            try
            {
                string query = "INSERT INTO medicaments (nom, description, quantite, prix) VALUES (@nom, @description, @quantite, @prix)";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@quantite", quantite);
                command.Parameters.AddWithValue("@prix", prix);

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine($"Nombre de lignes insérées : {rowsAffected}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion des données : " + ex.Message);
            }
        }

        public List<Drug> ReadMedicament(DataGridView dataGridView)
        {
            List<Drug> medicamentList = new List<Drug>();

            try
            {
                string query = "SELECT id, nom, description, quantite, prix FROM medicaments";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView.DataSource = table;

            }
            catch(Exception ex)
            {
                Console.WriteLine("Erreur lecture médicament : " + ex.Message);
            }
            return medicamentList;
        }

        public void UpdateMedicament(int medicamentID, string newNom, string newDescription, int newQuantite, decimal newPrix)
        {
            try
            {
                string query = "UPDATE medicaments SET nom = @newNom, description = @newDescription, quantite = @newQuantite, prix = @newPrix WHERE id = @medicamentID";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@newNom", newNom);
                command.Parameters.AddWithValue("@newDescription", newDescription);
                command.Parameters.AddWithValue("@newQuantite", newQuantite);
                command.Parameters.AddWithValue("@newPrix", newPrix);
                command.Parameters.AddWithValue("@medicamentID", medicamentID);

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine($"Nombre de lignes mises à jour : {rowsAffected}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la mise à jour des données : " + ex.Message);
            }
        }

        public void InsertDataConsultation(int selectedId, string typeConsultation, DateTime dateConsultation, string commentaire, ListBox listBox)
        {
            try
            {
                string clientInfo = listBox.SelectedItem.ToString();
                string[] clientInfos = clientInfo.Split('-');
                string nomPrenom = clientInfos[0].Trim();
                string[] nomPrenomParts = nomPrenom.Split(' ');
                string nom = nomPrenomParts[0];
                string prenom = nomPrenomParts[1];

                string query = "INSERT INTO consultations (typeConsultation, commentaire, dateConsultation, clientId) VALUES (@typeConsultation, @commentaire, @dateConsultation, @clientId)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@typeConsultation", typeConsultation);
                command.Parameters.AddWithValue("@commentaire", commentaire);
                command.Parameters.AddWithValue("@dateConsultation", dateConsultation);
                command.Parameters.AddWithValue("@clientId", selectedId);

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine($"Nombre de lignes insérées : {rowsAffected}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion des données de consultation : " + ex.Message);
            }
        }






       
    }

}