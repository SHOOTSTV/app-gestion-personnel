using System;
using Gestion_personnel.controleur;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_personnel.vue
{
    /// <summary>
    /// Fenêtre de login
    /// </summary>
    public partial class frmLogin : Form
    {
        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Initialisation des composants graphiques
        /// </summary>
        /// <param name="controle"></param>
        public frmLogin(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// Demande au contrôleur de controler l'accès
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!txtLogin.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                if (!controle.ControleAuthentification(txtLogin.Text, txtPwd.Text))
                {
                    MessageBox.Show("Authentification incorrecte", "Alerte");
                    txtLogin.Text = "";
                    txtPwd.Text = "";
                    txtLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
