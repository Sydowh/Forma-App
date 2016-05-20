namespace FORMA
{
    partial class Form_Mod_Formation
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
            this.btn_valider = new System.Windows.Forms.Button();
            this.txt_intitule = new System.Windows.Forms.TextBox();
            this.txt_niveau = new System.Windows.Forms.TextBox();
            this.lbl_formation = new System.Windows.Forms.Label();
            this.lbl_niveau = new System.Windows.Forms.Label();
            this.lbl_objectifs = new System.Windows.Forms.Label();
            this.rtxt_objectifs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(99, 250);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(80, 40);
            this.btn_valider.TabIndex = 0;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // txt_intitule
            // 
            this.txt_intitule.Location = new System.Drawing.Point(39, 57);
            this.txt_intitule.Name = "txt_intitule";
            this.txt_intitule.Size = new System.Drawing.Size(200, 20);
            this.txt_intitule.TabIndex = 1;
            // 
            // txt_niveau
            // 
            this.txt_niveau.Location = new System.Drawing.Point(39, 96);
            this.txt_niveau.Name = "txt_niveau";
            this.txt_niveau.Size = new System.Drawing.Size(200, 20);
            this.txt_niveau.TabIndex = 2;
            // 
            // lbl_formation
            // 
            this.lbl_formation.AutoSize = true;
            this.lbl_formation.Location = new System.Drawing.Point(122, 41);
            this.lbl_formation.Name = "lbl_formation";
            this.lbl_formation.Size = new System.Drawing.Size(38, 13);
            this.lbl_formation.TabIndex = 4;
            this.lbl_formation.Text = "Intitulé";
            // 
            // lbl_niveau
            // 
            this.lbl_niveau.AutoSize = true;
            this.lbl_niveau.Location = new System.Drawing.Point(122, 80);
            this.lbl_niveau.Name = "lbl_niveau";
            this.lbl_niveau.Size = new System.Drawing.Size(41, 13);
            this.lbl_niveau.TabIndex = 5;
            this.lbl_niveau.Text = "Niveau";
            // 
            // lbl_objectifs
            // 
            this.lbl_objectifs.AutoSize = true;
            this.lbl_objectifs.Location = new System.Drawing.Point(122, 122);
            this.lbl_objectifs.Name = "lbl_objectifs";
            this.lbl_objectifs.Size = new System.Drawing.Size(48, 13);
            this.lbl_objectifs.TabIndex = 6;
            this.lbl_objectifs.Text = "Objectifs";
            // 
            // rtxt_objectifs
            // 
            this.rtxt_objectifs.Location = new System.Drawing.Point(39, 138);
            this.rtxt_objectifs.Name = "rtxt_objectifs";
            this.rtxt_objectifs.Size = new System.Drawing.Size(200, 96);
            this.rtxt_objectifs.TabIndex = 7;
            this.rtxt_objectifs.Text = "";
            // 
            // Form_Mod_Formation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 361);
            this.Controls.Add(this.rtxt_objectifs);
            this.Controls.Add(this.lbl_objectifs);
            this.Controls.Add(this.lbl_niveau);
            this.Controls.Add(this.lbl_formation);
            this.Controls.Add(this.txt_niveau);
            this.Controls.Add(this.txt_intitule);
            this.Controls.Add(this.btn_valider);
            this.Name = "Form_Mod_Formation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification Formation";
            this.Load += new System.EventHandler(this.Form_Mod_Formation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox txt_intitule;
        private System.Windows.Forms.TextBox txt_niveau;
        private System.Windows.Forms.Label lbl_formation;
        private System.Windows.Forms.Label lbl_niveau;
        private System.Windows.Forms.Label lbl_objectifs;
        private System.Windows.Forms.RichTextBox rtxt_objectifs;
    }
}