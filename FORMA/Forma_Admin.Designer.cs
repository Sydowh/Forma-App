namespace FORMA
{
    partial class Forma_Admin
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
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.txtb_mdp = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(84, 75);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(231, 20);
            this.txtb_id.TabIndex = 0;
            // 
            // txtb_mdp
            // 
            this.txtb_mdp.Location = new System.Drawing.Point(84, 142);
            this.txtb_mdp.Name = "txtb_mdp";
            this.txtb_mdp.Size = new System.Drawing.Size(231, 20);
            this.txtb_mdp.TabIndex = 1;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(173, 59);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(32, 13);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Email";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(164, 120);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(71, 13);
            this.lbl_mdp.TabIndex = 3;
            this.lbl_mdp.Text = "Mot de passe";
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(135, 185);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(128, 51);
            this.btn_connexion.TabIndex = 4;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // Forma_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.txtb_mdp);
            this.Controls.Add(this.txtb_id);
            this.Name = "Forma_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel d\'administration - Connexion";
            this.Load += new System.EventHandler(this.Forma_Admin_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.TextBox txtb_mdp;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Button btn_connexion;
    }
}

