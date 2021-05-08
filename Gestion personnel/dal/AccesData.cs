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
            string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as service ";
            req += "from personnel p join service s on (p.idservice = s.idservice) ";
            req += "order by nom, prenom;";

            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Personnel personnel = new Personnel((int)curs.Field("idpersonnel"), (int)curs.Field("idservice"),(string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"), (string)curs.Field("service"));
                lesPersonnels.Add(personnel);
            }
            curs.Close();
            return lesPersonnels;
        }

        // Récupère et retourne les absences provenant de la BDD
        public static List<Absence> GetLesAbsences()
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "select a.idpersonnel as idpersonnel, a.datedebut as datedebut, m.idmotif as idmotif, a.datefin as datefin, m.libelle as motif ";
            req += "from absence a join motif m on (a.idmotif = m.idmotif) ";

            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Absence absence = new Absence((int)curs.Field("idpersonnel"), (DateTime)curs.Field("datedebut"), (int)curs.Field("idmotif"), (DateTime)curs.Field("datefin"), (string)curs.Field("motif"));
                lesAbsences.Add(absence);
            }
            curs.Close();
            return lesAbsences;
        }
        // Récupère et retourne les services provenant de la BDD
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "select * from service ";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Service service = new Service((int)curs.Field("idservice"), (string)curs.Field("nom"));
                lesServices.Add(service);
            }
            curs.Close();
            return lesServices;
        }
        // Récupère et retourne les motifs provenant de la BDD
        public static List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "select * from motif ";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Motif motif = new Motif((int)curs.Field("idmotif"), (string)curs.Field("libelle"));
                lesMotifs.Add(motif);
            }
            curs.Close();
            return lesMotifs;
        }

    }
}
