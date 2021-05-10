using Gestion_personnel.connexion;
using Gestion_personnel.modele;
using System;
using System.Collections.Generic;

namespace Gestion_personnel.dal
{
    /// <summary>
    /// Classe qui permet de gérer toute demandes qui concerne les données
    /// </summary>
    public class AccesData
    {   //  connexion à la BDD 
        private static string connectionString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=mlr1";

        /// <summary>
        /// Contrôle si l'user à le droit de se connecter (login password)
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static Boolean ControleAuthentification(string login, string pwd)
        {
            string req = "select * from responsable where login=@login and pwd=SHA2(@pwd, 256) ";
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

        /// <summary>
        /// Récupère et retourne les personnels provenant de la BDD
        /// </summary>
        /// <returns>La liste des personnels</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as service ";
            req += "from personnel p join service s on (p.idservice = s.idservice) ";
            req += "order by nom, prenom;";

            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Personnel personnel = new Personnel((int)curs.Field("idpersonnel"), (int)curs.Field("idservice"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"), (string)curs.Field("service"));
                lesPersonnels.Add(personnel);
            }
            curs.Close();
            return lesPersonnels;
        }

        /// <summary>
        /// Récupère et retourne les absences provenant de la BDD
        /// </summary>
        /// <returns>La liste des absences</returns>
        public static List<Absence> GetLesAbsences()
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "select a.idpersonnel as idpersonnel, a.datedebut as datedebut, m.idmotif as idmotif, a.datefin as datefin, m.libelle as motif ";
            req += "from absence a join motif m on (a.idmotif = m.idmotif) ORDER BY datedebut DESC";

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
        /// <summary>
        /// Récupère et retourne les services provenant de la BDD
        /// </summary>
        /// <returns>Les services</returns>
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
        /// <summary>
        /// Récupère et retourne les motifs provenant de la BDD
        /// </summary>
        /// <returns>Les motifs</returns>
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
        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void DelPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }
        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void AddPersonnel(Personnel personnel)
        {
            string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
            req += "values (@nom, @prenom, @tel, @mail, @idservice);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);

        }
        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice ";
            req += "where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }
        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public static void DelAbsence(Absence absence)
        {
            string req = "delete from absence where idpersonnel = @idpersonnel AND datedebut = @datedebut AND idmotif = @idmotif AND datefin = @datefin;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.Idpersonnel);
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@idmotif", absence.Idmotif);
            parameters.Add("@datefin", absence.Datefin);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);

        }
        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public static void AddAbsence(Absence absence)
        {
            string req = "insert into absence(idpersonnel, datedebut, idmotif, datefin) ";
            req += "values (@idpersonnel, @datedebut, @idmotif, @datefin);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.Idpersonnel);
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@idmotif", absence.Idmotif);
            parameters.Add("@datefin", absence.Datefin);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }
        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public static void UpdateAbsence(Absence absence)
        {
            string req = "update absence set datedebut = @datedebut, idmotif = @idmotif, datefin = @datefin ";
            req += "where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.Idpersonnel);
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@idmotif", absence.Idmotif);
            parameters.Add("@datefin", absence.Datefin);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }
    }
}
