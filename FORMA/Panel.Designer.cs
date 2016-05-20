namespace FORMA
{
    partial class Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_domaine = new System.Windows.Forms.Button();
            this.btn_formation = new System.Windows.Forms.Button();
            this.btn_utilisateur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_domaine
            // 
            this.btn_domaine.Location = new System.Drawing.Point(112, 49);
            this.btn_domaine.Name = "btn_domaine";
            this.btn_domaine.Size = new System.Drawing.Size(160, 50);
            this.btn_domaine.TabIndex = 0;
            this.btn_domaine.Text = "Domaines";
            this.btn_domaine.UseVisualStyleBackColor = true;
            this.btn_domaine.Click += new System.EventHandler(this.btn_domaine_Click);
            // 
            // btn_formation
            // 
            this.btn_formation.Location = new System.Drawing.Point(112, 107);
            this.btn_formation.Name = "btn_formation";
            this.btn_formation.Size = new System.Drawing.Size(160, 50);
            this.btn_formation.TabIndex = 1;
            this.btn_formation.Text = "Formations";
            this.btn_formation.UseVisualStyleBackColor = true;
            this.btn_formation.Click += new System.EventHandler(this.btn_formation_Click);
            // 
            // btn_utilisateur
            // 
            this.btn_utilisateur.Location = new System.Drawing.Point(112, 162);
            this.btn_utilisateur.Name = "btn_utilisateur";
            this.btn_utilisateur.Size = new System.Drawing.Size(160, 50);
            this.btn_utilisateur.TabIndex = 2;
            this.btn_utilisateur.Text = "Utilisateurs";
            this.btn_utilisateur.UseVisualStyleBackColor = true;
            this.btn_utilisateur.Click += new System.EventHandler(this.btn_utilisateur_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btn_utilisateur);
            this.Controls.Add(this.btn_formation);
            this.Controls.Add(this.btn_domaine);
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel d\'administration - Connecté";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Panel_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_domaine;
        private System.Windows.Forms.Button btn_formation;
        private System.Windows.Forms.Button btn_utilisateur;
    }
}