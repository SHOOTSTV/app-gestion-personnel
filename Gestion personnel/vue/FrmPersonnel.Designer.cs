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
            this.btnShowAbs = new System.Windows.Forms.Button();
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
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDatefin = new System.Windows.Forms.Label();
            this.lblDatedebut = new System.Windows.Forms.Label();
            this.bdgPersonnel = new System.Windows.Forms.BindingSource(this.components);
            this.bdgAbsence = new System.Windows.Forms.BindingSource(this.components);
            this.bdgService = new System.Windows.Forms.BindingSource(this.components);
            this.bdgMotif = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.grbPersonnel.SuspendLayout();
            this.grbAddperso.SuspendLayout();
            this.grbAbsence.SuspendLayout();
            this.grbAddabsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMotif)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPerso
            // 
            this.btnAddPerso.Location = new System.Drawing.Point(407, 380);
            this.btnAddPerso.Name = "btnAddPerso";
            this.btnAddPerso.Size = new System.Drawing.Size(87, 27);
            this.btnAddPerso.TabIndex = 5;
            this.btnAddPerso.Text = "Ajouter";
            this.btnAddPerso.UseVisualStyleBackColor = true;
            this.btnAddPerso.Click += new System.EventHandler(this.btnAddPerso_Click);
            // 
            // btnModifPerso
            // 
            this.btnModifPerso.Location = new System.Drawing.Point(502, 380);
            this.btnModifPerso.Name = "btnModifPerso";
            this.btnModifPerso.Size = new System.Drawing.Size(87, 27);
            this.btnModifPerso.TabIndex = 4;
            this.btnModifPerso.Text = "Modifier";
            this.btnModifPerso.UseVisualStyleBackColor = true;
            this.btnModifPerso.Click += new System.EventHandler(this.btnModifPerso_Click);
            // 
            // btnDeletePerso
            // 
            this.btnDeletePerso.Location = new System.Drawing.Point(596, 380);
            this.btnDeletePerso.Name = "btnDeletePerso";
            this.btnDeletePerso.Size = new System.Drawing.Size(87, 27);
            this.btnDeletePerso.TabIndex = 3;
            this.btnDeletePerso.Text = "Supprimer";
            this.btnDeletePerso.UseVisualStyleBackColor = true;
            this.btnDeletePerso.Click += new System.EventHandler(this.btnDeletePerso_Click);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(19, 35);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(665, 322);
            this.dgvPersonnel.TabIndex = 2;
            // 
            // btnAddAbsence
            // 
            this.btnAddAbsence.Location = new System.Drawing.Point(194, 380);
            this.btnAddAbsence.Name = "btnAddAbsence";
            this.btnAddAbsence.Size = new System.Drawing.Size(87, 27);
            this.btnAddAbsence.TabIndex = 7;
            this.btnAddAbsence.Text = "Ajouter";
            this.btnAddAbsence.UseVisualStyleBackColor = true;
            this.btnAddAbsence.Click += new System.EventHandler(this.btnAddAbsence_Click);
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(288, 380);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(87, 27);
            this.btnModifAbsence.TabIndex = 6;
            this.btnModifAbsence.Text = "Modifier";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            this.btnModifAbsence.Click += new System.EventHandler(this.btnModifAbsence_Click);
            // 
            // btnDeleteAbsence
            // 
            this.btnDeleteAbsence.Location = new System.Drawing.Point(383, 380);
            this.btnDeleteAbsence.Name = "btnDeleteAbsence";
            this.btnDeleteAbsence.Size = new System.Drawing.Size(87, 27);
            this.btnDeleteAbsence.TabIndex = 5;
            this.btnDeleteAbsence.Text = "Supprimer";
            this.btnDeleteAbsence.UseVisualStyleBackColor = true;
            this.btnDeleteAbsence.Click += new System.EventHandler(this.btnDeleteAbsence_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(513, 35);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(87, 27);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.AllowUserToAddRows = false;
            this.dgvAbsence.AllowUserToDeleteRows = false;
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(52, 35);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.ReadOnly = true;
            this.dgvAbsence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsence.Size = new System.Drawing.Size(418, 322);
            this.dgvAbsence.TabIndex = 3;
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnShowAbs);
            this.grbPersonnel.Controls.Add(this.btnDeletePerso);
            this.grbPersonnel.Controls.Add(this.btnModifPerso);
            this.grbPersonnel.Controls.Add(this.btnAddPerso);
            this.grbPersonnel.Controls.Add(this.dgvPersonnel);
            this.grbPersonnel.Location = new System.Drawing.Point(14, 14);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(705, 428);
            this.grbPersonnel.TabIndex = 7;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Liste du personnel";
            // 
            // btnShowAbs
            // 
            this.btnShowAbs.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAbs.Location = new System.Drawing.Point(30, 380);
            this.btnShowAbs.Name = "btnShowAbs";
            this.btnShowAbs.Size = new System.Drawing.Size(141, 27);
            this.btnShowAbs.TabIndex = 6;
            this.btnShowAbs.Text = "Afficher les absences";
            this.btnShowAbs.UseVisualStyleBackColor = true;
            this.btnShowAbs.Click += new System.EventHandler(this.btnShowAbs_Click);
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
            this.grbAddperso.Enabled = false;
            this.grbAddperso.Location = new System.Drawing.Point(14, 467);
            this.grbAddperso.Name = "grbAddperso";
            this.grbAddperso.Size = new System.Drawing.Size(705, 193);
            this.grbAddperso.TabIndex = 8;
            this.grbAddperso.TabStop = false;
            this.grbAddperso.Text = "ajouter un personnel";
            // 
            // btnAnnulerperso
            // 
            this.btnAnnulerperso.Location = new System.Drawing.Point(128, 153);
            this.btnAnnulerperso.Name = "btnAnnulerperso";
            this.btnAnnulerperso.Size = new System.Drawing.Size(87, 27);
            this.btnAnnulerperso.TabIndex = 10;
            this.btnAnnulerperso.Text = "annuler";
            this.btnAnnulerperso.UseVisualStyleBackColor = true;
            this.btnAnnulerperso.Click += new System.EventHandler(this.btnAnnulerperso_Click);
            // 
            // btnSaveperso
            // 
            this.btnSaveperso.Location = new System.Drawing.Point(34, 153);
            this.btnSaveperso.Name = "btnSaveperso";
            this.btnSaveperso.Size = new System.Drawing.Size(87, 27);
            this.btnSaveperso.TabIndex = 6;
            this.btnSaveperso.Text = "enregistrer";
            this.btnSaveperso.UseVisualStyleBackColor = true;
            this.btnSaveperso.Click += new System.EventHandler(this.btnSaveperso_Click);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(359, 129);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(175, 23);
            this.cboService.TabIndex = 9;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(302, 133);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(45, 15);
            this.lblService.TabIndex = 8;
            this.lblService.Text = "service";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(338, 85);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(196, 21);
            this.txtTel.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(338, 36);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(196, 21);
            this.txtMail.TabIndex = 6;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(302, 89);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(21, 15);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "tel";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(302, 39);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(31, 15);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "mail";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(83, 85);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(196, 21);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(83, 36);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(196, 21);
            this.txtNom.TabIndex = 2;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(27, 89);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(51, 15);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(30, 39);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(33, 15);
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
            this.grbAbsence.Location = new System.Drawing.Point(744, 14);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(621, 428);
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
            this.grbAddabsence.Controls.Add(this.cboMotif);
            this.grbAddabsence.Controls.Add(this.lblMotif);
            this.grbAddabsence.Controls.Add(this.lblDatefin);
            this.grbAddabsence.Controls.Add(this.lblDatedebut);
            this.grbAddabsence.Enabled = false;
            this.grbAddabsence.Location = new System.Drawing.Point(744, 467);
            this.grbAddabsence.Name = "grbAddabsence";
            this.grbAddabsence.Size = new System.Drawing.Size(621, 193);
            this.grbAddabsence.TabIndex = 10;
            this.grbAddabsence.TabStop = false;
            this.grbAddabsence.Text = "ajouter une absence";
            // 
            // btnAnnulerabsence
            // 
            this.btnAnnulerabsence.Location = new System.Drawing.Point(122, 153);
            this.btnAnnulerabsence.Name = "btnAnnulerabsence";
            this.btnAnnulerabsence.Size = new System.Drawing.Size(87, 27);
            this.btnAnnulerabsence.TabIndex = 11;
            this.btnAnnulerabsence.Text = "annuler";
            this.btnAnnulerabsence.UseVisualStyleBackColor = true;
            this.btnAnnulerabsence.Click += new System.EventHandler(this.btnAnnulerabsence_Click);
            // 
            // btnSaveabsence
            // 
            this.btnSaveabsence.Location = new System.Drawing.Point(28, 153);
            this.btnSaveabsence.Name = "btnSaveabsence";
            this.btnSaveabsence.Size = new System.Drawing.Size(87, 27);
            this.btnSaveabsence.TabIndex = 11;
            this.btnSaveabsence.Text = "enregistrer";
            this.btnSaveabsence.UseVisualStyleBackColor = true;
            this.btnSaveabsence.Click += new System.EventHandler(this.btnSaveabsence_Click);
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFin.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(129, 82);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(233, 22);
            this.dtpFin.TabIndex = 11;
            // 
            // dtpDebut
            // 
            this.dtpDebut.CustomFormat = "dd/MM/yyyy HH:mm:sss";
            this.dtpDebut.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDebut.Location = new System.Drawing.Point(129, 36);
            this.dtpDebut.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(233, 22);
            this.dtpDebut.TabIndex = 10;
            this.dtpDebut.Value = new System.DateTime(2021, 5, 9, 18, 9, 0, 0);
            // 
            // cboMotif
            // 
            this.cboMotif.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(425, 36);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(175, 23);
            this.cboMotif.TabIndex = 9;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(370, 39);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(37, 15);
            this.lblMotif.TabIndex = 8;
            this.lblMotif.Text = "motif";
            // 
            // lblDatefin
            // 
            this.lblDatefin.AutoSize = true;
            this.lblDatefin.Location = new System.Drawing.Point(30, 85);
            this.lblDatefin.Name = "lblDatefin";
            this.lblDatefin.Size = new System.Drawing.Size(66, 15);
            this.lblDatefin.TabIndex = 4;
            this.lblDatefin.Text = "date de fin";
            // 
            // lblDatedebut
            // 
            this.lblDatedebut.AutoSize = true;
            this.lblDatedebut.Location = new System.Drawing.Point(30, 39);
            this.lblDatedebut.Name = "lblDatedebut";
            this.lblDatedebut.Size = new System.Drawing.Size(83, 15);
            this.lblDatedebut.TabIndex = 0;
            this.lblDatedebut.Text = "date de début";
            // 
            // frmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 689);
            this.Controls.Add(this.grbAddabsence);
            this.Controls.Add(this.grbAbsence);
            this.Controls.Add(this.grbAddperso);
            this.Controls.Add(this.grbPersonnel);
            this.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            ((System.ComponentModel.ISupportInitialize)(this.bdgService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMotif)).EndInit();
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
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDatefin;
        private System.Windows.Forms.Label lblDatedebut;
        private System.Windows.Forms.Button btnAnnulerperso;
        private System.Windows.Forms.Button btnSaveperso;
        private System.Windows.Forms.Button btnSaveabsence;
        private System.Windows.Forms.Button btnAnnulerabsence;
        private System.Windows.Forms.BindingSource bdgPersonnel;
        private System.Windows.Forms.BindingSource bdgAbsence;
        private System.Windows.Forms.BindingSource bdgService;
        private System.Windows.Forms.BindingSource bdgMotif;
        private System.Windows.Forms.Button btnShowAbs;
    }
}

