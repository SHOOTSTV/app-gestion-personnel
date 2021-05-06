using Gestion_personnel.connexion;
using Gestion_personnel.modele;
using System;
using System.Collections.Generic;

namespace Gestion_personnel.dal
{
    public class AccesData
    {   //  connexion à la BDD 
        private static string connectionString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=mlr1";
        
        // Contrôle si l'user à le droit de se connecter (login password)
        public static Boolean ControleAuthentification(string login, string pwd)
        {
            string req = "select * from responsable where login=@login and pwd=@pwd";
           // req += "where r.login=@login and pwd=SHA2(@pwd, 256)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);           
            parameters.Add("@pwd", pwd);
            connexionBDD curs = connexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);
            if (curs.Read())
            {              
                curs.Close();
                return true;
            }
            else
            {                
                curs.Close();
                return false;
            }
        }
    }
}
