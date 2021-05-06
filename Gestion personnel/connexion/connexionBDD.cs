using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion_personnel.connexion
{
    // connexion à la base de données et éxecution des requêtes
    public class connexionBDD
    {   
        // Instance unique de la classe
        private static connexionBDD instance = null;
        // Objet de connexion à la base de donnée à partir d'une chaine de connexion 
        private MySqlConnection connection;
        // Objet pour executer une requête SQL
        private MySqlCommand command;
        // Objet contenant le résultat d'une requête "select" (curseur)
        private MySqlDataReader reader;
        
        // Constructeur privé pour créer la connexion à la base de donnée et l'ouvrir
        private connexionBDD(string stringConnect)
        {
            try
            {
                connection = new MySqlConnection(stringConnect);
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }

        // Crée une instance unique de la classe
        public static connexionBDD GetInstance(string stringConnect)
        {
            if (instance is null)
            {
                instance = new connexionBDD(stringConnect);
            }
            return instance;
        }

        // Exécution d'une requête autre que "select"
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Exécution d'une requête de type "select" et valorise le curseur
        public void ReqSelect(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Essaye de lire la ligne suivante du curseur
        public bool Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        // Retourne le contenu d'un champ dont le nom est envoyé en paramètre
        public object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }

        // Femeture du curseur
        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
        }
    }
}
