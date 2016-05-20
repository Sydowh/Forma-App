namespace FORMA
{
    partial class Form_Suppr_Domaine
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
            this.lbl_confirmation = new System.Windows.Forms.Label();
            this.lbl_attention = new System.Windows.Forms.Label();
            this.lbl_domaine = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_confirmation
            // 
            this.lbl_confirmation.AutoSize = true;
            this.lbl_confirmation.Location = new System.Drawing.Point(143, 9);
            this.lbl_confirmation.Name = "lbl_confirmation";
            this.lbl_confirmation.Size = new System.Drawing.Size(195, 13);
            this.lbl_confirmation.TabIndex = 0;
            this.lbl_confirmation.Text = "Confirmer la suppresion de ce domaine :";
            // 
            // lbl_attention
            // 
            this.lbl_attention.AutoSize = true;
            this.lbl_attention.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_attention.Location = new System.Drawing.Point(8, 61);
            this.lbl_attention.Name = "lbl_attention";
            this.lbl_attention.Size = new System.Drawing.Size(464, 13);
            this.lbl_attention.TabIndex = 1;
            this.lbl_attention.Text = "/ ! \\ Attention cette suppresion entrainera la suppression des sessions et des fo" +
    "rmations liées / ! \\";
            // 
            // lbl_domaine
            // 
            this.lbl_domaine.AutoSize = true;
            this.lbl_domaine.Location = new System.Drawing.Point(222, 26);
            this.lbl_domaine.Name = "lbl_domaine";
            this.lbl_domaine.Size = new System.Drawing.Size(0, 13);
            this.lbl_domaine.TabIndex = 2;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(146, 109);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(88, 40);
            this.btn_valider.TabIndex = 3;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(250, 109);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(88, 40);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // Form_Suppr_Domaine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_domaine);
            this.Controls.Add(this.lbl_attention);
            this.Controls.Add(this.lbl_confirmation);
            this.Name = "Form_Suppr_Domaine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppresion Domaine";
            this.Load += new System.EventHandler(this.Form_Suppr_Domaine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_confirmation;
        private System.Windows.Forms.Label lbl_attention;
        private System.Windows.Forms.Label lbl_domaine;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
    }
}