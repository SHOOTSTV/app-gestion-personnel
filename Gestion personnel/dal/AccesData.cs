using Gestion_personnel.connexion;
using Gestion_personnel.modele;
using System;
using System.Collections.Generic;

namespace Gestion_personnel.dal
{
    // Classe qui permet de gérer toute demandes qui concerne les données
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
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
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

        // Récupère et retourne les personnels provenant de la BDD
        public static List<Personnel> GetLesPersonnels()
        {
            List <Personnel> lesPersonnels = new List<Personnel>();
            string req = "select idpersonnel as idpersonnel, idservice as idservice, nom as nom, prenom as prenom, tel as tel, mail as mail  from personnel";

            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Personnel personnel = new Personnel((int)curs.Field("idpersonnel"), (int)curs.Field("idservice"),(string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"));
                lesPersonnels.Add(personnel);
            }
            curs.Close();
            return lesPersonnels;
        }

        // Récupère et retourne les absences provenant de la BDD
        public static List<Absence> GetLesAbsences()
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "select idpersonnel as idpersonnel, datedebut as datedebut, idmotif as idmotif, datefin as datefin from absence";

            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Absence absence = new Absence((int)curs.Field("idpersonnel"), (DateTime)curs.Field("datedebut"), (int)curs.Field("idmotif"), (DateTime)curs.Field("datefin"));
                lesAbsences.Add(absence);
            }
            curs.Close();
            return lesAbsences;
        }
    }
}
