namespace Gestion_personnel
{
    partial class frmPersonnel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddPerso = new System.Windows.Forms.Button();
            this.btnModifPerso = new System.Windows.Forms.Button();
            this.btnDeletePerso = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnAddAbsence = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnDeleteAbsence = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.grbAddperso = new System.Windows.Forms.GroupBox();
            this.btnAnnulerperso = new System.Windows.Forms.Button();
            this.btnSaveperso = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.grbAddabsence = new System.Windows.Forms.GroupBox();
            this.btnAnnulerabsence = new System.Windows.Forms.Button();
            this.btnSaveabsence = new System.Windows.Forms.Button();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.cboAbsence = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDatefin = new System.Windows.Forms.Label();
            this.lblDatedebut = new System.Windows.Forms.Label();
            this.bdgPersonnel = new System.Windows.Forms.BindingSource(this.components);
            this.bdgAbsence = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.grbPersonnel.SuspendLayout();
            this.grbAddperso.SuspendLayout();
            this.grbAbsence.SuspendLayout();
            this.grbAddabsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPerso
            // 
            this.btnAddPerso.Location = new System.Drawing.Point(335, 329);
            this.btnAddPerso.Name = "btnAddPerso";
            this.btnAddPerso.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerso.TabIndex = 5;
            this.btnAddPerso.Text = "Ajouter";
            this.btnAddPerso.UseVisualStyleBackColor = true;
            // 
            // btnModifPerso
            // 
            this.btnModifPerso.Location = new System.Drawing.Point(416, 329);
            this.btnModifPerso.Name = "btnModifPerso";
            this.btnModifPerso.Size = new System.Drawing.Size(75, 23);
            this.btnModifPerso.TabIndex = 4;
            this.btnModifPerso.Text = "Modifier";
            this.btnModifPerso.UseVisualStyleBackColor = true;
            // 
            // btnDeletePerso
            // 
            this.btnDeletePerso.Location = new System.Drawing.Point(497, 329);
            this.btnDeletePerso.Name = "btnDeletePerso";
            this.btnDeletePerso.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePerso.TabIndex = 3;
            this.btnDeletePerso.Text = "Supprimer";
            this.btnDeletePerso.UseVisualStyleBackColor = true;
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(29, 30);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.Size = new System.Drawing.Size(543, 279);
            this.dgvPersonnel.TabIndex = 2;
            // 
            // btnAddAbsence
            // 
            this.btnAddAbsence.Location = new System.Drawing.Point(166, 329);
            this.btnAddAbsence.Name = "btnAddAbsence";
            this.btnAddAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAddAbsence.TabIndex = 7;
            this.btnAddAbsence.Text = "Ajouter";
            this.btnAddAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(247, 329);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnModifAbsence.TabIndex = 6;
            this.btnModifAbsence.Text = "Modifier";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAbsence
            // 
            this.btnDeleteAbsence.Location = new System.Drawing.Point(328, 329);
            this.btnDeleteAbsence.Name = "btnDeleteAbsence";
            this.btnDeleteAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAbsence.TabIndex = 5;
            this.btnDeleteAbsence.Text = "Supprimer";
            this.btnDeleteAbsence.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(440, 30);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.AllowUserToAddRows = false;
            this.dgvAbsence.AllowUserToDeleteRows = false;
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(45, 30);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.ReadOnly = true;
            this.dgvAbsence.Size = new System.Drawing.Size(358, 279);
            this.dgvAbsence.TabIndex = 3;
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnDeletePerso);
            this.grbPersonnel.Controls.Add(this.btnModifPerso);
            this.grbPersonnel.Controls.Add(this.btnAddPerso);
            this.grbPersonnel.Controls.Add(this.dgvPersonnel);
            this.grbPersonnel.Location = new System.Drawing.Point(12, 12);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(604, 371);
            this.grbPersonnel.TabIndex = 7;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Liste du personnel";
            // 
            // grbAddperso
            // 
            this.grbAddperso.Controls.Add(this.btnAnnulerperso);
            this.grbAddperso.Controls.Add(this.btnSaveperso);
            this.grbAddperso.Controls.Add(this.cboService);
            this.grbAddperso.Controls.Add(this.lblService);
            this.grbAddperso.Controls.Add(this.txtTel);
            this.grbAddperso.Controls.Add(this.txtMail);
            this.grbAddperso.Controls.Add(this.lblTel);
            this.grbAddperso.Controls.Add(this.lblMail);
            this.grbAddperso.Controls.Add(this.txtPrenom);
            this.grbAddperso.Controls.Add(this.txtNom);
            this.grbAddperso.Controls.Add(this.lblPrenom);
            this.grbAddperso.Controls.Add(this.lblNom);
            this.grbAddperso.Location = new System.Drawing.Point(12, 405);
            this.grbAddperso.Name = "grbAddperso";
            this.grbAddperso.Size = new System.Drawing.Size(604, 167);
            this.grbAddperso.TabIndex = 8;
            this.grbAddperso.TabStop = false;
            this.grbAddperso.Text = "Ajouter un personnel";
            // 
            // btnAnnulerperso
            // 
            this.btnAnnulerperso.Location = new System.Drawing.Point(110, 133);
            this.btnAnnulerperso.Name = "btnAnnulerperso";
            this.btnAnnulerperso.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerperso.TabIndex = 10;
            this.btnAnnulerperso.Text = "annuler";
            this.btnAnnulerperso.UseVisualStyleBackColor = true;
            // 
            // btnSaveperso
            // 
            this.btnSaveperso.Location = new System.Drawing.Point(29, 133);
            this.btnSaveperso.Name = "btnSaveperso";
            this.btnSaveperso.Size = new System.Drawing.Size(75, 23);
            this.btnSaveperso.TabIndex = 6;
            this.btnSaveperso.Text = "enregistrer";
            this.btnSaveperso.UseVisualStyleBackColor = true;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Items.AddRange(new object[] {
            "administratif",
            "médiation culturelle",
            "prêt"});
            this.cboService.Location = new System.Drawing.Point(308, 112);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(151, 21);
            this.cboService.TabIndex = 9;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(259, 115);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(41, 13);
            this.lblService.TabIndex = 8;
            this.lblService.Text = "service";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(290, 74);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(169, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(290, 31);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(169, 20);
            this.txtMail.TabIndex = 6;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(259, 77);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(18, 13);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "tel";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(259, 34);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(25, 13);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "mail";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(71, 74);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(169, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(71, 31);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(169, 20);
            this.txtNom.TabIndex = 2;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(23, 77);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(42, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(26, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(27, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "nom";
            // 
            // grbAbsence
            // 
            this.grbAbsence.Controls.Add(this.btnAddAbsence);
            this.grbAbsence.Controls.Add(this.dgvAbsence);
            this.grbAbsence.Controls.Add(this.btnModifAbsence);
            this.grbAbsence.Controls.Add(this.btnReturn);
            this.grbAbsence.Controls.Add(this.btnDeleteAbsence);
            this.grbAbsence.Enabled = false;
            this.grbAbsence.Location = new System.Drawing.Point(638, 12);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(532, 371);
            this.grbAbsence.TabIndex = 9;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "Liste des absences";
            // 
            // grbAddabsence
            // 
            this.grbAddabsence.Controls.Add(this.btnAnnulerabsence);
            this.grbAddabsence.Controls.Add(this.btnSaveabsence);
            this.grbAddabsence.Controls.Add(this.dtpFin);
            this.grbAddabsence.Controls.Add(this.dtpDebut);
            this.grbAddabsence.Controls.Add(this.cboAbsence);
            this.grbAddabsence.Controls.Add(this.lblMotif);
            this.grbAddabsence.Controls.Add(this.lblDatefin);
            this.grbAddabsence.Controls.Add(this.lblDatedebut);
            this.grbAddabsence.Enabled = false;
            this.grbAddabsence.Location = new System.Drawing.Point(638, 405);
            this.grbAddabsence.Name = "grbAddabsence";
            this.grbAddabsence.Size = new System.Drawing.Size(532, 167);
            this.grbAddabsence.TabIndex = 10;
            this.grbAddabsence.TabStop = false;
            this.grbAddabsence.Text = "Ajouter une absence";
            // 
            // btnAnnulerabsence
            // 
            this.btnAnnulerabsence.Location = new System.Drawing.Point(105, 133);
            this.btnAnnulerabsence.Name = "btnAnnulerabsence";
            this.btnAnnulerabsence.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerabsence.TabIndex = 11;
            this.btnAnnulerabsence.Text = "annuler";
            this.btnAnnulerabsence.UseVisualStyleBackColor = true;
            // 
            // btnSaveabsence
            // 
            this.btnSaveabsence.Location = new System.Drawing.Point(24, 133);
            this.btnSaveabsence.Name = "btnSaveabsence";
            this.btnSaveabsence.Size = new System.Drawing.Size(75, 23);
            this.btnSaveabsence.TabIndex = 11;
            this.btnSaveabsence.Text = "enregistrer";
            this.btnSaveabsence.UseVisualStyleBackColor = true;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(111, 71);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 11;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(111, 31);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 10;
            // 
            // cboAbsence
            // 
            this.cboAbsence.FormattingEnabled = true;
            this.cboAbsence.Items.AddRange(new object[] {
            "vacances",
            "maladie",
            "motif familial",
            "congé parental"});
            this.cboAbsence.Location = new System.Drawing.Point(364, 31);
            this.cboAbsence.Name = "cboAbsence";
            this.cboAbsence.Size = new System.Drawing.Size(151, 21);
            this.cboAbsence.TabIndex = 9;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(317, 34);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(29, 13);
            this.lblMotif.TabIndex = 8;
            this.lblMotif.Text = "motif";
            // 
            // lblDatefin
            // 
            this.lblDatefin.AutoSize = true;
            this.lblDatefin.Location = new System.Drawing.Point(26, 74);
            this.lblDatefin.Name = "lblDatefin";
            this.lblDatefin.Size = new System.Drawing.Size(57, 13);
            this.lblDatefin.TabIndex = 4;
            this.lblDatefin.Text = "date de fin";
            // 
            // lblDatedebut
            // 
            this.lblDatedebut.AutoSize = true;
            this.lblDatedebut.Location = new System.Drawing.Point(26, 34);
            this.lblDatedebut.Name = "lblDatedebut";
            this.lblDatedebut.Size = new System.Drawing.Size(73, 13);
            this.lblDatedebut.TabIndex = 0;
            this.lblDatedebut.Text = "date de début";
            // 
            // frmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 597);
            this.Controls.Add(this.grbAddabsence);
            this.Controls.Add(this.grbAbsence);
            this.Controls.Add(this.grbAddperso);
            this.Controls.Add(this.grbPersonnel);
            this.Name = "frmPersonnel";
            this.Text = "Logiciel de gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.grbPersonnel.ResumeLayout(false);
            this.grbAddperso.ResumeLayout(false);
            this.grbAddperso.PerformLayout();
            this.grbAbsence.ResumeLayout(false);
            this.grbAddabsence.ResumeLayout(false);
            this.grbAddabsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAbsence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnDeletePerso;
        private System.Windows.Forms.Button btnAddPerso;
        private System.Windows.Forms.Button btnModifPerso;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnDeleteAbsence;
        private System.Windows.Forms.Button btnAddAbsence;
        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.GroupBox grbAddperso;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.GroupBox grbAddabsence;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.ComboBox cboAbsence;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDatefin;
        private System.Windows.Forms.Label lblDatedebut;
        private System.Windows.Forms.Button btnAnnulerperso;
        private System.Windows.Forms.Button btnSaveperso;
        private System.Windows.Forms.Button btnSaveabsence;
        private System.Windows.Forms.Button btnAnnulerabsence;
        private System.Windows.Forms.BindingSource bdgPersonnel;
        private System.Windows.Forms.BindingSource bdgAbsence;
    }
}

