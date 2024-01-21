﻿
using Medmanager.Ajouter_medicament;
using Medmanager.Ajouter_patient;
using Medmanager.model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.BC;
using Org.BouncyCastle.Crypto;
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
    // La classe Connection_DB est actuellement définie comme internal,
    // ce qui signifie qu'elle est accessible uniquement à l'intérieur de l'assembly où elle est déclarée.
    {

        MySqlConnection conn;
        string connectionString;

        public Connection_DB()
        {
            string server = "localhost";
            string database = "medmanager2";
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
        // connexion

        public bool Connexion(string login, string password)
        {
            try
            {

                string query = "SELECT login, password FROM medecin WHERE login = @login";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", login);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string dbLogin = reader.GetString("login");
                        string dbPassword = reader.GetString("password");

                        if (password == dbPassword)
                        {
                            // Connexion réussie
                            Console.WriteLine("Connexion réussie !");
                            return true;
                        }
                        else
                        {
                            // Mot de passe incorrect
                            Console.WriteLine("Mot de passe incorrect !");
                            return false;
                        }
                    }
                    else
                    {
                        // Aucun enregistrement trouvé
                        Console.WriteLine("Utilisateur non trouvé !");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de connexion : " + ex.Message);
                return false;
            }
        }

        public void InsertMedecin(string nom, string prenom, string login, string hashedPassword)
        {
                try
                {


                    // Requête SQL d'insertion
                    string query = "INSERT INTO medecin (nom, prenom, login, password) VALUES (@Nom, @Prenom, @Login, @Password)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Paramètres
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@Prenom", prenom);
                        cmd.Parameters.AddWithValue("@Login", login);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        // Exécution de la requête
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Médecin ajouté avec succès !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'insertion du médecin : " + ex.Message);
                }
            
        }

        // main =

        public int GetNumberOfPatients()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM patient";
                MySqlCommand command = new MySqlCommand(query, conn);
                int numberOfPatients = Convert.ToInt32(command.ExecuteScalar());
                return numberOfPatients;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération du nombre de patients : " + ex.Message);
                return 0; 
            }
        }

        //fin main 
        //antécédent
        public List<Antecedent> GetAntecedent()
        {
            List<Antecedent> antecedents = new List<Antecedent>();
            try
            {
                string query = "SELECT id_antecedent, nom FROM antecedent ORDER BY nom";
                MySqlCommand command = new MySqlCommand( query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    Antecedent antecedent = new Antecedent(id, nom);
                    antecedents.Add(antecedent);
                }
                reader.Close();


            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);

            }
            return antecedents;

        }

        public void InsertAntecedentInpatient(int idP, int idA)
        {
            try
            {
                string query = "INSERT INTO a_eu (id, id_patient) VALUES (@idA, @idP)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@idA", idA);
                command.Parameters.AddWithValue("@idP", idP);

                command.ExecuteNonQuery();


                Console.WriteLine("Antécédent : " + idA + " Ajouté à : " + idP);


            }catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion: " + ex.Message);
            }
        }

        // fin

        // allergie
        public List<Allergie> GetAllergies()
        {
            List<Allergie> allergies = new List<Allergie>();    
            try
            {
                string query = "SELECT * FROM allergies ORDER BY nom";
                MySqlCommand command = new MySqlCommand(query,conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    Allergie allergie = new Allergie(id, nom);
                    allergies.Add(allergie);
                }
                reader.Close();

            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return allergies;
        }
        public void InsertAllergiesIntoPatient(int idallergies, int idpatient)
        {
            try
            {
                string query = "INSERT INTO est (id_allergie,id_patient) VALUES (@idallergies,@idpatient)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@idallergies", idallergies);
                command.Parameters.AddWithValue("@idpatient", idpatient);
                command.ExecuteNonQuery();

                Console.WriteLine("allergies : " + idallergies + " Ajouté à : " + idpatient);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion des données : " + ex.Message);
            }
        }
        //patient 
        public void InsertDataPatient(string nom, string prenom, string sexe, string numero)
        {
            try
            {
                string query = "INSERT INTO patient (nom, prenom, sexe, numero) VALUES (@nom, @prenom, @sexe, @numero)";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.Parameters.AddWithValue("@sexe", sexe);
                command.Parameters.AddWithValue("@numero", numero);

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine($"Nombre de lignes insérées : {rowsAffected}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion des données : " + ex.Message);
            }

        }
        public List<Patient> GetPatientsFromDatabase()
        {
            List<Patient> patients = new List<Patient>();

            try
            {
                string query = "SELECT id_patient, nom, prenom, sexe, numero FROM patient ORDER BY nom";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    string prenom = reader.GetString(2);
                    string sexe = reader.GetString(3);
                    string numero = reader.GetString(4);

                    Patient patient = new Patient(id,nom,prenom,sexe,numero);
                    patients.Add(patient);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération des patients : " + ex.Message);
            }

            return patients;

        }



        public void ReadPatients(DataGridView dataGridView)
        {
            try
            {
                string query = "SELECT * FROM patient";
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
                string query = "DELETE FROM patient WHERE id_patient = @patientID";

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




        public void UpdatePatient(int patientID, string newNom, string newPrenom, string newSexe, string newNumero)
        {
            try
            {
                string query = "UPDATE patient SET nom = @newNom, prenom = @newPrenom, sexe= @newSexe,  numero = @newNumero WHERE id_patient = @patientID";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@newNom", newNom);
                command.Parameters.AddWithValue("@newPrenom", newPrenom);
                command.Parameters.AddWithValue("@newNumero", newNumero);
                command.Parameters.AddWithValue("@newSexe", newSexe);
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

        public void InsertDataMedicament(string nom, string indication)
        {
            try
            {
                string query = "INSERT INTO medicament (nom, contre_indiction) VALUES (@nom, @indication)";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@indication", indication);

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine($"Nombre de lignes insérées : {rowsAffected}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion des données : " + ex.Message);
            }
        }

        public List<Medicament> GetMedicamentList()
        {
            List <Medicament> medicaments = new List<Medicament>();
            try
            {
                string query = "SELECT * FROM medicament";
                MySqlCommand command = new MySqlCommand( query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    string nom = reader["nom"].ToString();
                    string contreIndication = reader["contre_indiction"].ToString();
                    Medicament medicament = new Medicament(nom, contreIndication);

                    medicaments.Add(medicament);
                }
                reader.Close();

          

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return medicaments;
        }
        public int GetMedicamentIdByName(string medicamentName)
        {
            int idMedicament = -1; 

                string query = "SELECT id FROM medicament WHERE nom = @medicamentName";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@medicamentName", medicamentName);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                            idMedicament = reader.GetInt32("id");
                        }
                    reader.Close();
                   }
                
            

            return idMedicament;
        }

        public List<Medicament> ReadMedicament(DataGridView dataGridView)
        {
            List<Medicament> medicamentList = new List<Medicament>();

            try
            {
                string query = "SELECT id, nom, contre_indiction FROM medicament";
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

        public void UpdateMedicament(int medicamentID, string newNom, string newIndication)
        {
            try
            {
                string query = "UPDATE medicament SET nom = @newNom, contre_indiction = @newIndication WHERE id = @medicamentID";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@newNom", newNom);
                command.Parameters.AddWithValue("@newIndication", newIndication);
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
                string query = "DELETE FROM medicament WHERE id = @medicamentID";

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

            






        // medecin

        public string GetNomFromId(int id)
        {
            try
            {
                string query = "SELECT nom, prenom FROM medecin WHERE id = @id";
                using(MySqlCommand command = new MySqlCommand(query,conn))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nom = reader["nom"].ToString();
                            string prenom = reader["prenom"].ToString();
                            return $"{nom} {prenom}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "Error user ";
        }

        public int GetMedecinId(string login)
        {
            try
            {
                string query = "SELECT id FROM medecin WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@login", login);

                // Utiliser ExecuteScalar pour obtenir la valeur de la première colonne de la première ligne
                object result = command.ExecuteScalar();

                // Convertir le résultat en int
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    // Gérer le cas où le résultat est null
                    return 0; // Vous pouvez ajuster le type de retour en conséquence
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0; // Vous pouvez ajuster le type de retour en conséquence
            }
        }

        public int InsertOrdonnance(string posologie, decimal duree, string ins, int id_medecin, int id_patient,int id_medicament)
        {
            int idOrdonnance = -1; // Initialiser à une valeur invalide

            try
            {
                string query = "INSERT INTO ordonnance (`posologie`, `duree_traitement`, `instruction_specifique`, `id_Medecin`, `id_patient`,id_medicament) VALUES (@posologie, @duree, @ins, @id_medecin, @id_patient,@id_medicament);SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@posologie", posologie);
                    cmd.Parameters.AddWithValue("@duree", duree);
                    cmd.Parameters.AddWithValue("@ins", ins);
                    cmd.Parameters.AddWithValue("@id_medecin", id_medecin);
                    cmd.Parameters.AddWithValue("@id_patient", id_patient);
                    cmd.Parameters.AddWithValue("@id_medicament", id_medicament);

                    cmd.ExecuteNonQuery();

                    idOrdonnance = Convert.ToInt32(cmd.LastInsertedId);
                    // Ajouter des déclarations de débogage
                    Console.WriteLine("ID généré : " + idOrdonnance);
                    Console.WriteLine("Query executed: " + query);
                    // Récupérer l'ID généré
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion des données : " + ex.Message);
            }
     
            return idOrdonnance;
        }

        public void GetPatientAllergieByID(int id_patient, DataGridView dataGridView)
        {
            try
            {
                string query = @"
                            SELECT a.nom
                            FROM Est e
                            INNER JOIN Allergies a ON e.id_allergie = a.id_allergie
                            WHERE e.id_patient = @id_patient";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id_patient", id_patient);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool getAllergieMedicament(int idPatient, int  idMedicament)
        {
            string query = @"
                SELECT a.nom, m.nom AS nom_medicament
                FROM est e 
                INNER JOIN incompatibles i ON e.id_allergie = i.id_al
                INNER JOIN allergies a ON i.id_al = a.id_allergie
                INNER JOIN medicament m ON i.id_med = m.id
                WHERE e.id_patient = @idP AND e.id_allergie = @idMed
                                            ";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@idP", idPatient);
            command.Parameters.AddWithValue("@idMed", idMedicament);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string allergie = reader["nom"].ToString();
                    string medicament = reader["nom_medicament"].ToString();

                    Console.WriteLine("Allergie : " + allergie + "médicament" + medicament);
                    return true;
                }
            }
            return false;

        }

        public void getAntecedentFromIdPatient(int idPatient, DataGridView dataGridView)
        {
            try
            {
                string query = @"SELECT a.nom
                FROM a_eu aeu
                INNER JOIN antecedent a ON aeu.id = a.id_antecedent
                WHERE aeu.id_patient = @idPatient";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@idPatient", idPatient);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public void DeletAntecedent(string nomAntecedent, int idPatient)
        {

            try
            {
                // Utilisez une sous-requête pour obtenir l'ID de l'antécédent
                string query = "DELETE FROM a_eu WHERE id_patient = @idPatient AND id IN (SELECT id_antecedent FROM antecedent WHERE nom = @nomAntecedent)";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nomAntecedent", nomAntecedent);
                    command.Parameters.AddWithValue("@idPatient", idPatient);
                    command.ExecuteNonQuery();

                    MessageBox.Show("L'antécédent a été supprimé avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de l'antécédent : " + ex.Message);
                MessageBox.Show("Une erreur s'est produite lors de la suppression de l'antécédent.", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void InsertIncompatibilite(int idAllergie, int idAntecedent, int idMedicament, int idMedicament2)
        {
            try
            {
                string query = "INSERT INTO `incompatibles`(`id_a`, `id_med`, `id_al`, `id_med_Medicament`) VALUES (@ant, @med, @all, @med2)";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ant", idAntecedent);
                    command.Parameters.AddWithValue("@med", idMedicament);
                    command.Parameters.AddWithValue("@all", idAllergie);
                    command.Parameters.AddWithValue("@med2", idMedicament2);

                    command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Une erreur s'est produite lors de l'insertion de l'incompatibilité.", "Erreur d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool CheckExistingIncompatibility(int idAntecedent, int idMedicament, int idAllergie, int idMedicament2)
        {
            string query = "SELECT COUNT(*) FROM `incompatibles` WHERE `id_a` = @ant AND `id_med` = @med AND `id_al` = @all AND `id_med_Medicament` = @med2";

            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@ant", idAntecedent);
                command.Parameters.AddWithValue("@med", idMedicament);
                command.Parameters.AddWithValue("@all", idAllergie);
                command.Parameters.AddWithValue("@med2", idMedicament2);

                int count = Convert.ToInt32(command.ExecuteScalar());

                // Retourne true si l'incompatibilité existe déjà, sinon false
                return count > 0;
            }
        }

    }

}