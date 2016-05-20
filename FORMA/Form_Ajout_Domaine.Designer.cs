namespace FORMA
{
    partial class Form_Ajout_Domaine
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
            this.txt_domaine = new System.Windows.Forms.TextBox();
            this.lbl_domaine = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_domaine
            // 
            this.txt_domaine.Location = new System.Drawing.Point(33, 83);
            this.txt_domaine.Name = "txt_domaine";
            this.txt_domaine.Size = new System.Drawing.Size(200, 20);
            this.txt_domaine.TabIndex = 0;
            // 
            // lbl_domaine
            // 
            this.lbl_domaine.AutoSize = true;
            this.lbl_domaine.Location = new System.Drawing.Point(113, 67);
            this.lbl_domaine.Name = "lbl_domaine";
            this.lbl_domaine.Size = new System.Drawing.Size(38, 13);
            this.lbl_domaine.TabIndex = 1;
            this.lbl_domaine.Text = "Intitulé";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(94, 109);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(80, 40);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // Form_Ajout_Domaine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_domaine);
            this.Controls.Add(this.txt_domaine);
            this.Name = "Form_Ajout_Domaine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout de domaine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_domaine;
        private System.Windows.Forms.Label lbl_domaine;
        private System.Windows.Forms.Button btn_valider;
    }
}