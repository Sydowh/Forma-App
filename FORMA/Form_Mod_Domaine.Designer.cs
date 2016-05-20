namespace FORMA
{
    partial class Form_Mod_Domaine
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
            this.txt_intitule = new System.Windows.Forms.TextBox();
            this.lbl_intitule = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_intitule
            // 
            this.txt_intitule.Location = new System.Drawing.Point(75, 47);
            this.txt_intitule.Name = "txt_intitule";
            this.txt_intitule.Size = new System.Drawing.Size(100, 20);
            this.txt_intitule.TabIndex = 0;
            // 
            // lbl_intitule
            // 
            this.lbl_intitule.AutoSize = true;
            this.lbl_intitule.Location = new System.Drawing.Point(108, 31);
            this.lbl_intitule.Name = "lbl_intitule";
            this.lbl_intitule.Size = new System.Drawing.Size(38, 13);
            this.lbl_intitule.TabIndex = 1;
            this.lbl_intitule.Text = "Intitulé";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(75, 73);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(100, 24);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // Form_Mod_Domaine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 141);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_intitule);
            this.Controls.Add(this.txt_intitule);
            this.Name = "Form_Mod_Domaine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification Domaine";
            this.Load += new System.EventHandler(this.Form_Mod_Domaine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_intitule;
        private System.Windows.Forms.Label lbl_intitule;
        private System.Windows.Forms.Button btn_valider;
    }
}