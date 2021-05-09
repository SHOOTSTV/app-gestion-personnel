using System;
using System.Collections.Generic;
using Gestion_personnel.dal;
using Gestion_personnel.vue;
using Gestion_personnel.modele;

namespace Gestion_personnel.controleur
{
    /// <summary>
    /// Gère les interractions entre la vue et le modèle
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// fenêtre de login
        /// </summary>
        private frmLogin frmLogin;

        /// <summary>
        /// ouverture de la fenêtre 
        /// </summary>
        public Controle()
        {
            frmLogin = new frmLogin(this);
            frmLogin.ShowDialog();
        }

        /// <summary>
        /// demande de vérification du login
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Récupère et retourne les infos du personnel de la BDD
        /// </summary>
        /// <returns>liste personnels</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return AccesData.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des absences de la BDD
        /// </summary>
        /// <returns>liste absences</returns>
        public List<Absence> GetLesAbsences()
        {
            return AccesData.GetLesAbsences();
        }

        /// <summary>
        /// Récupère et retourne les infos des services de la BDD
        /// </summary>
        /// <returns>liste services</returns>
        public List<Service> GetLesServices()
        {
            return AccesData.GetLesServices();
        }
        /// <summary>
        /// Récupère et retourne les infos des motifs de la BDD
        /// </summary>
        /// <returns>liste motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return AccesData.GetLesMotifs();
        }
        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void DelPersonnel(Personnel personnel)
        {
            AccesData.DelPersonnel(personnel);
        }
        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnel(Personnel personnel)
        {
            AccesData.AddPersonnel(personnel);
        }
        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnel personnel)
        {
            AccesData.UpdatePersonnel(personnel);
        }
        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void DelAbsence(Absence absence)
        {
            AccesData.DelAbsence(absence);
        }
        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            AccesData.AddAbsence(absence);
        }
        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void UpdateAbsence(Absence absence)
        {
            AccesData.UpdateAbsence(absence);
        }
    }
}
