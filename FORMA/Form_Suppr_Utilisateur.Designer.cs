namespace FORMA
{
    partial class Form_Suppr_Utilisateur
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
            this.lbl_conf = new System.Windows.Forms.Label();
            this.lbl_attention = new System.Windows.Forms.Label();
            this.lbl_utilisateur = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_conf
            // 
            this.lbl_conf.AutoSize = true;
            this.lbl_conf.Location = new System.Drawing.Point(136, 49);
            this.lbl_conf.Name = "lbl_conf";
            this.lbl_conf.Size = new System.Drawing.Size(202, 13);
            this.lbl_conf.TabIndex = 0;
            this.lbl_conf.Text = "Confirmer la suppresion de cet utilisateur :";
            this.lbl_conf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_attention
            // 
            this.lbl_attention.AutoSize = true;
            this.lbl_attention.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_attention.Location = new System.Drawing.Point(30, 102);
            this.lbl_attention.Name = "lbl_attention";
            this.lbl_attention.Size = new System.Drawing.Size(427, 13);
            this.lbl_attention.TabIndex = 1;
            this.lbl_attention.Text = "/ ! \\ Attention cette suppresion entrainera la suppression des incriptions aux se" +
    "ssions / ! \\";
            // 
            // lbl_utilisateur
            // 
            this.lbl_utilisateur.AutoSize = true;
            this.lbl_utilisateur.Location = new System.Drawing.Point(203, 78);
            this.lbl_utilisateur.Name = "lbl_utilisateur";
            this.lbl_utilisateur.Size = new System.Drawing.Size(0, 13);
            this.lbl_utilisateur.TabIndex = 2;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(138, 143);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(88, 40);
            this.btn_valider.TabIndex = 3;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(250, 143);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(88, 40);
            this.btn_supprimer.TabIndex = 4;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // Form_Suppr_Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 197);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_utilisateur);
            this.Controls.Add(this.lbl_attention);
            this.Controls.Add(this.lbl_conf);
            this.Name = "Form_Suppr_Utilisateur";
            this.Text = "Suppresion Utilisateur";
            this.Load += new System.EventHandler(this.Form_Suppr_Utilisateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_conf;
        private System.Windows.Forms.Label lbl_attention;
        private System.Windows.Forms.Label lbl_utilisateur;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_supprimer;
    }
}