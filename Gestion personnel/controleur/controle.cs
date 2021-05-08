using System;
using System.Collections.Generic;
using Gestion_personnel.dal;
using Gestion_personnel.vue;
using Gestion_personnel.modele;

namespace Gestion_personnel.controleur
{
    public class Controle
    {
        // fenêtre de login
        private frmLogin frmLogin;

        // ouverture de la fenêtre 
        public Controle()
        {
            frmLogin = new frmLogin(this);
            frmLogin.ShowDialog();
        }

        // demande de vérification du login
        public Boolean ControleAuthentification(string login, string pwd)
        {
            if(AccesData.ControleAuthentification(login, pwd))
            {
                frmLogin.Hide();
                (new frmPersonnel(this)).ShowDialog();
                return true;
            }
            else
            {
                return false;

            }
        }

        // Récupère et retourne les infos du personnel de la BDD
        public List<Personnel> GetLesPersonnels()
        {
            return AccesData.GetLesPersonnels();
        }

        // Récupère et retourne les infos des absences de la BDD
        public List<Absence> GetLesAbsences()
        {
            return AccesData.GetLesAbsences();
        }

        // Récupère et retourne les infos des services de la BDD
        public List<Service> GetLesServices()
        {
            return AccesData.GetLesServices();
        }
        // Récupère et retourne les infos des motifs de la BDD
        public List<Motif> GetLesMotifs()
        {
            return AccesData.GetLesMotifs();
        }
    } 
}
