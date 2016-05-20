namespace FORMA
{
    partial class Form_Suppr_Formation
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
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_formation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Location = new System.Drawing.Point(136, 9);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(219, 13);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Confirmer de la suppresion de cette formation";
            // 
            // lbl_formation
            // 
            this.lbl_formation.AutoSize = true;
            this.lbl_formation.Location = new System.Drawing.Point(233, 30);
            this.lbl_formation.Name = "lbl_formation";
            this.lbl_formation.Size = new System.Drawing.Size(0, 13);
            this.lbl_formation.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(66, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "/ ! \\ Attention cette suppresion entrainera la suppression des sessions liées / !" +
    " \\";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(154, 109);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(88, 40);
            this.btn_valider.TabIndex = 3;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(248, 109);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(88, 40);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // Form_Suppr_Formation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_formation);
            this.Controls.Add(this.lbl_titre);
            this.Name = "Form_Suppr_Formation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppression Formation";
            this.Load += new System.EventHandler(this.Form_Suppr_Formation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_formation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
    }
}