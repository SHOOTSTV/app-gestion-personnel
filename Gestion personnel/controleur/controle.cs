using System;
using System.Collections.Generic;
using Gestion_personnel.dal;
using Gestion_personnel.vue;
using Gestion_personnel.modele;

namespace Gestion_personnel.controleur
{
    public class controle
    {
        // fenêtre de login
        private frmLogin frmLogin;

        // ouverture de la fenêtre 
        public controle()
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
                (new frmPersonnel()).ShowDialog();
                return true;
            }
            else
            {
                return false;

            }
        }
    } 
}
