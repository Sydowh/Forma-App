using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace FORMA
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        /// <summary>
        /// Constructeur de DBConnect
        /// </summary>
        public DBConnect()
        {
            Initialize();
        }

        /// <summary>
        /// Renvoie des variables de connexion
        /// </summary>
        private void Initialize()
        {
            server = "mysql.francois-garcia.ws";
            database = "sydowh";
            uid = "gillesferrand";
            password = "5du8z9pA";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password;

            connection = new MySqlConnection(connectionString);
        }


        #region Requêtes BD
        /// <summary>
        /// Ouvre la connexion à la base de données, affiche les erreurs de connexion
        /// </summary>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Problème de connexiion au serveur.");
                        break;

                    case 1045:
                        MessageBox.Show("Problème d'utilisateur et/ou de mot de passe.");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Ferme la connexion à la base de données, affiche les erreurs en cas de problèmes
        /// </summary>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Insertion de données grâce à une requête passé en paramètre 
        /// Exécute la requête SQL dans la base de données
        /// <param name="query">Paramètre en string, requête SQL contenant un INSERT</param>
        /// </summary>
        public void Insert(string query)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        /// <summary>
        /// Suppression de données grâce à une requête passé en paramètre
        /// Exécute la requête SQL dans la base de données
        /// <param name="query">Paramètre en string, requête SQL contenant un DELETE</param>
        /// </summary>
        public void Delete(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        /// <summary>
        /// Mis à jour de données grâce à une requête passé en paramètre
        /// Exécute la requête SQL dans la base de données
        /// <param name="query">Paramètre en string, requête SQL contenant un UPDATE</param>
        /// </summary>
        public void Update(string query)
        {
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        /// <summary>
        /// Lecture de données grâce à une requête passé en paramètre
        /// Exécute la requête SQL dans la base de données
        /// <param name="query">Paramètre en string, requête SQL contenant un SELECT</param>
        /// </summary>
        public void Select(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        /// <summary>
        /// Comptage de données grâce à une requête passé en paramètre
        /// Exécute la requête SQL dans la base de données
        /// <param name="query">Paramètre en string, requête SQL contenant un SELECT</param>
        /// <returns>Nombre d'occurences de données après exécution</returns>
        /// </summary>
        public int Count(string query)
        {
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
        // Affichage Listes
        /// <summary>
        /// Retourne la liste des formations au format listView pour les afficher dans une WindowsForm
        /// Exécute la requête SQL dans la base de données
        ///<param name="query">Requête SQL qui sera exécuté dans la base de données</param>
        ///<param name="p_listView">Objet qui sera afficher dans une WindowsForm : Listes des formations</param>
        /// </summary>
        public void listViewFormation(string query, ListView p_listView)
        {
            p_listView.Items.Clear();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader["LIBELLE_FORM"].ToString());
                    item.SubItems.Add(dataReader["NIVEAU_FORM"].ToString());
                    item.SubItems.Add(dataReader["OBJECTIFS"].ToString());
                    item.SubItems.Add(dataReader["CODE_FORM"].ToString());
                    p_listView.Items.Add(item);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

            }
            else
            {
                MessageBox.Show("Une erreur est survenue");
            }
        }
        /// <summary>
        /// Retourne la liste des domaines au format listView pour les afficher dans une WindowsForm
        /// Exécute la requête SQL dans la base de données
        ///<param name="query">Requête SQL qui sera exécuté dans la base de données</param>
        ///<param name="p_listView">Objet qui sera afficher dans une WindowsForm : Listes des domaines</param>
        /// </summary>
        public void listViewDomaine(string query, ListView p_listView)
        {
            // Reset de la liste pour éviter les duplicatins de données
            p_listView.Items.Clear();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader["LIBELLE_DOM"].ToString());
                    item.SubItems.Add(dataReader["CODE_DOM"].ToString());
                    p_listView.Items.Add(item);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

            }
            else
            {
                MessageBox.Show("Une erreur est survenue");
            }
        }
        /// <summary>
        /// Retourne la liste des utilisateurs au format listView pour les afficher dans une WindowsForm
        /// Exécute la requête SQL dans la base de données
        ///<param name="query">Requête SQL qui sera exécuté dans la base de données</param>
        ///<param name="p_listView">Objet qui sera afficher dans une WindowsForm : Listes des utilisateurs</param>
        /// </summary>
        public void listViewUtilisateur(string query, ListView p_listView)
        {
            // Reset de la liste pour éviter les duplicatins de données
            p_listView.Items.Clear();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader["EMAIL_UTIL"].ToString());
                    item.SubItems.Add(dataReader["NOM_UTIL"].ToString());
                    item.SubItems.Add(dataReader["PRENOM_UTIL"].ToString());
                    item.SubItems.Add(dataReader["FONC_UTIL"].ToString());
                    item.SubItems.Add(dataReader["NOM_ASSO"].ToString());
                    item.SubItems.Add(dataReader["CODE_UTIL"].ToString());
                    p_listView.Items.Add(item);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

            }
            else
            {
                MessageBox.Show("Une erreur est survenue");
            }
        }
        #endregion
    }
}