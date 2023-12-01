using Medmanager.Ajouter_Consultation;
using Medmanager.model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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

        public void InsertDataMedicament(string nom, string description, string famille, int quantite, decimal prix)
        {
            try
            {
                string query = "INSERT INTO medicaments (nom, description,famille, quantite, prix) VALUES (@nom, @description, @famille, @quantite, @prix)";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@famille", famille);
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
                string query = "SELECT id, nom, description, famille, quantite, prix FROM medicaments";
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

        public void UpdateMedicament(int medicamentID, string newNom, string newDescription,string newFamille, int newQuantite, decimal newPrix)
        {
            try
            {
                string query = "UPDATE medicaments SET nom = @newNom, description = @newDescription, famille = @newFamille, quantite = @newQuantite, prix = @newPrix WHERE id = @medicamentID";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@newNom", newNom);
                command.Parameters.AddWithValue("@newDescription", newDescription);
                command.Parameters.AddWithValue("@newFamille", newFamille);
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
        public void DeletMedicament(int medicamentID)
        {
            try
            {
                string query = "DELETE FROM medicaments WHERE id = @medicamentID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@medicamentID", medicamentID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Médicament supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du médicament : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ReadMedicamentsByFamily(DataGridView dataGridView, string famille)
        {
            try
            {
                string query = $"SELECT * FROM medicaments WHERE famille = '{famille}'";

                // Utilisez un objet MySqlCommand pour exécuter la requête
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Utilisez un objet MySqlDataAdapter pour remplir un DataTable avec les résultats de la requête
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Liez le DataTable à la DataGridView pour afficher les résultats
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la lecture des médicaments par famille : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<string> GetUniqueFamilies()
        {
            List<string> families = new List<string>();

            try
            {
                // Utilisez un objet MySqlCommand pour exécuter la requête SQL
                using (MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT famille FROM medicaments", conn))
                {
                    // Ouvrez la connexion si elle n'est pas déjà ouverte
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    // Utilisez un objet MySqlDataReader pour lire les résultats de la requête
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Parcourez les résultats et ajoutez chaque famille à la liste
                        while (reader.Read())
                        {
                            families.Add(reader["famille"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des familles : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return families;
        }

            public void InsertDataConsultation(int clientId, string typeConsultation, DateTime dateConsultation, string commentaire)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Construire votre commande SQL d'insertion
                    string query = "INSERT INTO consultations (clientId, typeConsultation, dateConsultation, commentaire) " +
                                   "VALUES (@clientId, @typeConsultation, @dateConsultation, @commentaire)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@clientId", clientId);
                        cmd.Parameters.AddWithValue("@typeConsultation", typeConsultation);
                        cmd.Parameters.AddWithValue("@dateConsultation", dateConsultation);
                        cmd.Parameters.AddWithValue("@commentaire", commentaire);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer l'exception (enregistrez dans un fichier journal, affichez un message d'erreur, etc.)
                throw new Exception("Erreur lors de l'insertion des données de consultation : " + ex.Message);
            }
        }

        public void UpdateConsultation(int consultationID, string newTypeConsultation, string newCommentaire, DateTime newDateConsultation)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Mettre à jour les informations de la consultation
                    string queryConsultation = "UPDATE consultations SET typeConsultation = @typeConsultation, " +
                                               "dateConsultation = @dateConsultation, commentaire = @commentaire " +
                                               "WHERE id = @consultationId";

                    using (MySqlCommand cmdConsultation = new MySqlCommand(queryConsultation, connection))
                    {
                        cmdConsultation.Parameters.AddWithValue("@typeConsultation", newTypeConsultation);
                        cmdConsultation.Parameters.AddWithValue("@dateConsultation", newDateConsultation);
                        cmdConsultation.Parameters.AddWithValue("@commentaire", newCommentaire);
                        cmdConsultation.Parameters.AddWithValue("@consultationId", consultationID);

                        cmdConsultation.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                // Gérer l'exception
                throw new Exception("Erreur lors de la mise à jour de la consultation : " + ex.Message);
            }
        }



        public void ReadConsultationsWithPatients(DataGridView dataGridView)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Construire votre commande SQL avec une jointure entre les tables
                    string query = "SELECT consultations.id, clients.nom, clients.prenom, " +
                                   "consultations.typeConsultation, consultations.dateConsultation, consultations.commentaire " +
                                   "FROM consultations " +
                                   "INNER JOIN clients ON consultations.clientId = clients.id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Associer les données à la dataGridView
                            dataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer l'exception
                throw new Exception("Erreur lors de la lecture des consultations : " + ex.Message);
            }
        }










    }

}