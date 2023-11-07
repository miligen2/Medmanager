using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Drug> ReadMedicament()
        {
            List<Drug> medicamentList = new List<Drug>();

            try
            {
                string query = "SELECT * FROM medicaments";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nom = reader.GetString("nom");
                    string description = reader.GetString("description");
                    int quantite = reader.GetInt32("quantite");
                    decimal prix = reader.GetDecimal("prix");

                    Drug medicament = new Drug(nom, description, quantite, prix);
                    medicamentList.Add(medicament);

                }

                reader.Close();


            }
            catch(Exception ex)
            {
                Console.WriteLine("Erreur lecture médicament : " + ex.Message);
            }
            return medicamentList;
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




        public void LoadPatients(ListBox listBox)
        {
            try
            {
                string query = "SELECT id, nom, prenom , numero, CP FROM clients"; 
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nom = reader.GetString("nom");
                    string prenom = reader.GetString("prenom");
                    string numero = reader.GetString("numero");
                    string codePostal = reader.GetString("CP");
                    string informations = $"{nom} {prenom} - {numero} - {codePostal}";

                    listBox.Items.Add(informations);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du chargement des patients : " + ex.Message);
            }
        }
    }

}