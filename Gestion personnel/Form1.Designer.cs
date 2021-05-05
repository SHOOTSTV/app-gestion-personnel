namespace Gestion_personnel
{
    partial class loginPage
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
            this.lblGestionPerso = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelPersonnel = new System.Windows.Forms.Panel();
            this.btnAddPerso = new System.Windows.Forms.Button();
            this.btnModifPerso = new System.Windows.Forms.Button();
            this.btnDeletePerso = new System.Windows.Forms.Button();
            this.dataGridViewPersonnel = new System.Windows.Forms.DataGridView();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListeperso = new System.Windows.Forms.Label();
            this.panelAbsence = new System.Windows.Forms.Panel();
            this.lblAbsence = new System.Windows.Forms.Label();
            this.dataGridViewAbsence = new System.Windows.Forms.DataGridView();
            this.datedebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteAbsence = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnAddAbsence = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).BeginInit();
            this.panelAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionPerso
            // 
            this.lblGestionPerso.AutoSize = true;
            this.lblGestionPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPerso.Location = new System.Drawing.Point(66, 40);
            this.lblGestionPerso.Name = "lblGestionPerso";
            this.lblGestionPerso.Size = new System.Drawing.Size(592, 37);
            this.lblGestionPerso.TabIndex = 0;
            this.lblGestionPerso.Text = "Gestion du personnel de la médiathèque";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(152, 282);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(117, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Identifiant :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(115, 329);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(154, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mot de passe :";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(288, 288);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(159, 20);
            this.txtBoxLogin.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(288, 334);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(159, 20);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(477, 326);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(115, 33);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Se connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.panelPersonnel);
            this.panelLogin.Controls.Add(this.lblGestionPerso);
            this.panelLogin.Controls.Add(this.btnConnect);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Controls.Add(this.txtBoxPassword);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.txtBoxLogin);
            this.panelLogin.Location = new System.Drawing.Point(12, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(726, 426);
            this.panelLogin.TabIndex = 6;
            // 
            // panelPersonnel
            // 
            this.panelPersonnel.Controls.Add(this.btnAddPerso);
            this.panelPersonnel.Controls.Add(this.btnModifPerso);
            this.panelPersonnel.Controls.Add(this.btnDeletePerso);
            this.panelPersonnel.Controls.Add(this.dataGridViewPersonnel);
            this.panelPersonnel.Controls.Add(this.lblListeperso);
            this.panelPersonnel.Location = new System.Drawing.Point(0, 0);
            this.panelPersonnel.Name = "panelPersonnel";
            this.panelPersonnel.Size = new System.Drawing.Size(726, 426);
            this.panelPersonnel.TabIndex = 6;
            // 
            // btnAddPerso
            // 
            this.btnAddPerso.Location = new System.Drawing.Point(379, 365);
            this.btnAddPerso.Name = "btnAddPerso";
            this.btnAddPerso.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerso.TabIndex = 5;
            this.btnAddPerso.Text = "Ajouter";
            this.btnAddPerso.UseVisualStyleBackColor = true;
            // 
            // btnModifPerso
            // 
            this.btnModifPerso.Location = new System.Drawing.Point(460, 365);
            this.btnModifPerso.Name = "btnModifPerso";
            this.btnModifPerso.Size = new System.Drawing.Size(75, 23);
            this.btnModifPerso.TabIndex = 4;
            this.btnModifPerso.Text = "Modifier";
            this.btnModifPerso.UseVisualStyleBackColor = true;
            // 
            // btnDeletePerso
            // 
            this.btnDeletePerso.Location = new System.Drawing.Point(541, 365);
            this.btnDeletePerso.Name = "btnDeletePerso";
            this.btnDeletePerso.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePerso.TabIndex = 3;
            this.btnDeletePerso.Text = "Supprimer";
            this.btnDeletePerso.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPersonnel
            // 
            this.dataGridViewPersonnel.AllowUserToAddRows = false;
            this.dataGridViewPersonnel.AllowUserToDeleteRows = false;
            this.dataGridViewPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.service,
            this.name,
            this.surname,
            this.phone,
            this.mail});
            this.dataGridViewPersonnel.Location = new System.Drawing.Point(73, 80);
            this.dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            this.dataGridViewPersonnel.ReadOnly = true;
            this.dataGridViewPersonnel.Size = new System.Drawing.Size(543, 279);
            this.dataGridViewPersonnel.TabIndex = 2;
            // 
            // service
            // 
            this.service.HeaderText = "Service ";
            this.service.Name = "service";
            this.service.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Nom";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.HeaderText = "Prénom";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Téléphone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // lblListeperso
            // 
            this.lblListeperso.AutoSize = true;
            this.lblListeperso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeperso.Location = new System.Drawing.Point(19, 24);
            this.lblListeperso.Name = "lblListeperso";
            this.lblListeperso.Size = new System.Drawing.Size(278, 37);
            this.lblListeperso.TabIndex = 1;
            this.lblListeperso.Text = "Liste du personnel";
            // 
            // panelAbsence
            // 
            this.panelAbsence.Controls.Add(this.btnAddAbsence);
            this.panelAbsence.Controls.Add(this.btnModifAbsence);
            this.panelAbsence.Controls.Add(this.btnDeleteAbsence);
            this.panelAbsence.Controls.Add(this.btnReturn);
            this.panelAbsence.Controls.Add(this.dataGridViewAbsence);
            this.panelAbsence.Controls.Add(this.lblAbsence);
            this.panelAbsence.Location = new System.Drawing.Point(12, 12);
            this.panelAbsence.Name = "panelAbsence";
            this.panelAbsence.Size = new System.Drawing.Size(726, 426);
            this.panelAbsence.TabIndex = 6;
            // 
            // lblAbsence
            // 
            this.lblAbsence.AutoSize = true;
            this.lblAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsence.Location = new System.Drawing.Point(19, 14);
            this.lblAbsence.Name = "lblAbsence";
            this.lblAbsence.Size = new System.Drawing.Size(213, 37);
            this.lblAbsence.TabIndex = 2;
            this.lblAbsence.Text = "Liste absence";
            // 
            // dataGridViewAbsence
            // 
            this.dataGridViewAbsence.AllowUserToAddRows = false;
            this.dataGridViewAbsence.AllowUserToDeleteRows = false;
            this.dataGridViewAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbsence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datedebut,
            this.datefin,
            this.motif});
            this.dataGridViewAbsence.Location = new System.Drawing.Point(200, 75);
            this.dataGridViewAbsence.Name = "dataGridViewAbsence";
            this.dataGridViewAbsence.ReadOnly = true;
            this.dataGridViewAbsence.Size = new System.Drawing.Size(358, 279);
            this.dataGridViewAbsence.TabIndex = 3;
            // 
            // datedebut
            // 
            this.datedebut.HeaderText = "Date de début";
            this.datedebut.Name = "datedebut";
            this.datedebut.ReadOnly = true;
            // 
            // datefin
            // 
            this.datefin.HeaderText = "Date de fin";
            this.datefin.Name = "datefin";
            this.datefin.ReadOnly = true;
            // 
            // motif
            // 
            this.motif.HeaderText = "Motif";
            this.motif.Name = "motif";
            this.motif.ReadOnly = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(630, 14);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAbsence
            // 
            this.btnDeleteAbsence.Location = new System.Drawing.Point(423, 365);
            this.btnDeleteAbsence.Name = "btnDeleteAbsence";
            this.btnDeleteAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAbsence.TabIndex = 5;
            this.btnDeleteAbsence.Text = "Supprimer";
            this.btnDeleteAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(342, 365);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnModifAbsence.TabIndex = 6;
            this.btnModifAbsence.Text = "Modifier";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAddAbsence
            // 
            this.btnAddAbsence.Location = new System.Drawing.Point(261, 365);
            this.btnAddAbsence.Name = "btnAddAbsence";
            this.btnAddAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAddAbsence.TabIndex = 7;
            this.btnAddAbsence.Text = "Ajouter";
            this.btnAddAbsence.UseVisualStyleBackColor = true;
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.panelAbsence);
            this.Controls.Add(this.panelLogin);
            this.Name = "loginPage";
            this.Text = "Authentifiez vous";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelPersonnel.ResumeLayout(false);
            this.panelPersonnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).EndInit();
            this.panelAbsence.ResumeLayout(false);
            this.panelAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGestionPerso;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelPersonnel;
        private System.Windows.Forms.DataGridView dataGridViewPersonnel;
        private System.Windows.Forms.Label lblListeperso;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.Button btnDeletePerso;
        private System.Windows.Forms.Button btnAddPerso;
        private System.Windows.Forms.Button btnModifPerso;
        private System.Windows.Forms.Panel panelAbsence;
        private System.Windows.Forms.Label lblAbsence;
        private System.Windows.Forms.DataGridView dataGridViewAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefin;
        private System.Windows.Forms.DataGridViewTextBoxColumn motif;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnDeleteAbsence;
        private System.Windows.Forms.Button btnAddAbsence;
    }
}

