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
            this.SuspendLayout();
            // 
            // lblGestionPerso
            // 
            this.lblGestionPerso.AutoSize = true;
            this.lblGestionPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPerso.Location = new System.Drawing.Point(79, 60);
            this.lblGestionPerso.Name = "lblGestionPerso";
            this.lblGestionPerso.Size = new System.Drawing.Size(592, 37);
            this.lblGestionPerso.TabIndex = 0;
            this.lblGestionPerso.Text = "Gestion du personnel de la médiathèque";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(178, 290);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(117, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Identifiant :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(141, 340);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(154, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mot de passe :";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(301, 296);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(159, 20);
            this.txtBoxLogin.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(301, 345);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(159, 20);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(485, 337);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(115, 33);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Se connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblGestionPerso);
            this.Name = "loginPage";
            this.Text = "Authentifiez vous";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionPerso;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnConnect;
    }
}

