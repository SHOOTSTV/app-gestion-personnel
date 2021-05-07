using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_personnel.controleur;
using Gestion_personnel.modele;

namespace Gestion_personnel
{
    public partial class frmPersonnel : Form
    {
        // Instance du controleur
        private Controle controle;
        // Initialisation des composants graphiques
        public frmPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }


        // Initialisation fram : remplissage des lites
        public void Init()
        {
            RemplirListePersonnels();
            RemplirListeAbsences();
        }

        // Affichage des personnels
        public void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.Columns["idservice"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        // Affichage des absences d'un personnel
        public void RemplirListeAbsences()
        {
            List<Absence> lesAbsences = controle.GetLesAbsences();
            bdgAbsence.DataSource = lesAbsences;
            dgvAbsence.DataSource = bdgAbsence;
            dgvAbsence.Columns["idpersonnel"].Visible = false;
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
