using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_personnel.controleur;
using Gestion_personnel.modele;
using System.Linq;

namespace Gestion_personnel
{
    public partial class frmPersonnel : Form
    {
        // Instance du controleur
        private Controle controle;
        // Booléen pour savoir si une modification est demandée
        private Boolean ModifEnCours = false;
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
            RemplirListeServices();
            
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

        // Affiche les services
        public void RemplirListeServices()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdgService.DataSource = lesServices;
            cboService.DataSource = bdgService;
            if (cboService.Items.Count > 0)
            {
                cboService.SelectedIndex = 0;
            }
        }

        // Affichage des absences d'un personnel
        public void RemplirAbsencesById(int id)
        {           
            List<Absence> absences = controle.GetLesAbsences().Where(abs => abs.Idpersonnel == id).ToList();
            bdgAbsence.DataSource = absences;
            dgvAbsence.DataSource = bdgAbsence;
            dgvAbsence.Columns["idpersonnel"].Visible = false;
            dgvAbsence.Columns["idmotif"].Visible = false;
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        // Affiche les motifs
        public void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controle.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotif;
            if (cboMotif.Items.Count > 0)
            {
                cboMotif.SelectedIndex = 0;
            }
        }

        // Demande de suppression d'un personnel
        private void btnDeletePerso_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        // Ouvre l'interface pour ajouter un personnel
        private void btnAddPerso_Click(object sender, EventArgs e)
        {
            grbAddperso.Enabled = true;
            grbAddperso.Text = "ajouter un personnel";
        }
        // Vider les zones de saisies et fermeture de l'interface ajout
        private void btnAnnulerperso_Click(object sender, EventArgs e)
        {
            ViderPersonnel();
            grbAddperso.Enabled = false;
            ModifEnCours = false;
        }
        // Vide les zones de saisie d'un personnel
        private void ViderPersonnel()
        {
            txtNom.Text = String.Empty;
            txtPrenom.Text = String.Empty;
            txtMail.Text = String.Empty;
            txtTel.Text = String.Empty;
            cboService.SelectedIndex = 0;
        }
        // Demande d'ajout d'un personnel
        private void btnSaveperso_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1 && MessageBox.Show("Etes vous sûr?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Service service = (Service)bdgService.List[bdgService.Position];
                int idpersonnel = 0;
                if (ModifEnCours)
                {
                    idpersonnel = (int)dgvPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                }
                Personnel personnel = new Personnel(idpersonnel, service.Idservice, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Nom);
                if (ModifEnCours)
                {
                    controle.UpdatePersonnel(personnel);
                    ModifEnCours = false;
                    grbAddperso.Enabled = true;
                    grbAddperso.Text = "ajouter un personnel";

                }
                else
                {
                    controle.AddPersonnel(personnel);
                }
                RemplirListePersonnels();
                ViderPersonnel();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
        // Demande de modification d'un personnel
        private void btnModifPerso_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {   
                ModifEnCours = true;               
                grbAddperso.Enabled = true;
                grbAddperso.Text = "modifier un personnel";
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        // Demande d'affichage des absences
        private void btnShowAbs_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {               
                grbAbsence.Enabled = true;
                object value = null;
                foreach (DataGridViewRow Row in dgvPersonnel.SelectedRows)
                {
                    value = Row.Cells["idpersonnel"].Value;             
                }
                RemplirAbsencesById((int)value);
                RemplirListeMotifs();
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        // Demande de retour et vide le tableau
        private void btnReturn_Click(object sender, EventArgs e)
        {
            grbAbsence.Enabled = false;
            dgvAbsence.Rows.Clear();
            grbAddabsence.Enabled = false;
        }
        // Demande de suppression d'une absence
        private void btnDeleteAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];

                object value = null;
                foreach (DataGridViewRow Row in dgvPersonnel.SelectedRows)
                {
                    value = Row.Cells["idpersonnel"].Value;
                }
                if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelAbsence(absence);
                    RemplirAbsencesById((int)value);
                    RemplirListeMotifs();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        // Demande d'ajout d'une absence
        private void btnSaveabsence_Click(object sender, EventArgs e)
        {
            if (cboMotif.SelectedIndex != -1 && MessageBox.Show("Etes vous sûr?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Motif motif = (Motif)bdgMotif.List[bdgMotif.Position];
                
                object value = null;
                foreach (DataGridViewRow Row in dgvPersonnel.SelectedRows)
                {
                    value = Row.Cells["idpersonnel"].Value;
                }

                Absence absence = new Absence(((int)value), dtpDebut.Value, motif.Idmotif, dtpFin.Value, cboMotif.Text);
                if (ModifEnCours)
                {
                    controle.UpdateAbsence(absence);
                    ModifEnCours = false;
                    grbAddabsence.Enabled = true;
                    grbAddabsence.Text = "ajouter une absence";

                }
                else
                {
                    controle.AddAbsence(absence);
                }
                RemplirAbsencesById((int)value);
                RemplirListeMotifs();

            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
        // Demande de modification d'une absence
        private void btnModifAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                ModifEnCours = true;
                grbAddabsence.Enabled = true;
                grbAddabsence.Text = "modifier une absence";
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                dtpDebut.Value = absence.Datedebut;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif);
                dtpFin.Value = absence.Datefin;
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        // Ouvre l'interface pour ajouter une absence
        private void btnAddAbsence_Click(object sender, EventArgs e)
        {
            grbAddabsence.Enabled = true;
        }
        // Vider les zones de saisies et fermeture de l'interface d'ajout d'une absence
        private void btnAnnulerabsence_Click(object sender, EventArgs e)
        {
            grbAddabsence.Enabled = false;
        }
    }
}
