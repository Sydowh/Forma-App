namespace FORMA
{
    partial class Form_Ajout_Formation
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lIBELLE_DOMLabel;
            this.txt_libelle = new System.Windows.Forms.TextBox();
            this.sydowhDataSet = new FORMA.sydowhDataSet();
            this.formationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formationTableAdapter = new FORMA.sydowhDataSetTableAdapters.formationTableAdapter();
            this.tableAdapterManager = new FORMA.sydowhDataSetTableAdapters.TableAdapterManager();
            this.domaineTableAdapter = new FORMA.sydowhDataSetTableAdapters.domaineTableAdapter();
            this.domaineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_intitule = new System.Windows.Forms.Label();
            this.txt_niveau = new System.Windows.Forms.TextBox();
            this.lbl_niveau = new System.Windows.Forms.Label();
            this.lbl_objectif = new System.Windows.Forms.Label();
            this.rtxt_objectif = new System.Windows.Forms.RichTextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.code_dom = new System.Windows.Forms.ComboBox();
            this.associationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.associationTableAdapter = new FORMA.sydowhDataSetTableAdapters.associationTableAdapter();
            lIBELLE_DOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sydowhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domaineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lIBELLE_DOMLabel
            // 
            lIBELLE_DOMLabel.AutoSize = true;
            lIBELLE_DOMLabel.Location = new System.Drawing.Point(68, 52);
            lIBELLE_DOMLabel.Name = "lIBELLE_DOMLabel";
            lIBELLE_DOMLabel.Size = new System.Drawing.Size(49, 13);
            lIBELLE_DOMLabel.TabIndex = 9;
            lIBELLE_DOMLabel.Text = "Domaine";
            // 
            // txt_libelle
            // 
            this.txt_libelle.Location = new System.Drawing.Point(71, 89);
            this.txt_libelle.Name = "txt_libelle";
            this.txt_libelle.Size = new System.Drawing.Size(200, 20);
            this.txt_libelle.TabIndex = 0;
            // 
            // sydowhDataSet
            // 
            this.sydowhDataSet.DataSetName = "sydowhDataSet";
            this.sydowhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formationBindingSource
            // 
            this.formationBindingSource.DataMember = "formation";
            this.formationBindingSource.DataSource = this.sydowhDataSet;
            // 
            // formationTableAdapter
            // 
            this.formationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.associationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.domaineTableAdapter = this.domaineTableAdapter;
            this.tableAdapterManager.formationTableAdapter = this.formationTableAdapter;
            this.tableAdapterManager.intervenantTableAdapter = null;
            this.tableAdapterManager.intervientTableAdapter = null;
            this.tableAdapterManager.participeTableAdapter = null;
            this.tableAdapterManager.sessionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FORMA.sydowhDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // domaineTableAdapter
            // 
            this.domaineTableAdapter.ClearBeforeFill = true;
            // 
            // domaineBindingSource
            // 
            this.domaineBindingSource.DataMember = "domaine";
            this.domaineBindingSource.DataSource = this.sydowhDataSet;
            // 
            // lbl_intitule
            // 
            this.lbl_intitule.AutoSize = true;
            this.lbl_intitule.Location = new System.Drawing.Point(68, 73);
            this.lbl_intitule.Name = "lbl_intitule";
            this.lbl_intitule.Size = new System.Drawing.Size(38, 13);
            this.lbl_intitule.TabIndex = 3;
            this.lbl_intitule.Text = "Intitulé";
            // 
            // txt_niveau
            // 
            this.txt_niveau.Location = new System.Drawing.Point(71, 128);
            this.txt_niveau.Name = "txt_niveau";
            this.txt_niveau.Size = new System.Drawing.Size(200, 20);
            this.txt_niveau.TabIndex = 4;
            // 
            // lbl_niveau
            // 
            this.lbl_niveau.AutoSize = true;
            this.lbl_niveau.Location = new System.Drawing.Point(71, 112);
            this.lbl_niveau.Name = "lbl_niveau";
            this.lbl_niveau.Size = new System.Drawing.Size(41, 13);
            this.lbl_niveau.TabIndex = 6;
            this.lbl_niveau.Text = "Niveau";
            // 
            // lbl_objectif
            // 
            this.lbl_objectif.AutoSize = true;
            this.lbl_objectif.Location = new System.Drawing.Point(68, 151);
            this.lbl_objectif.Name = "lbl_objectif";
            this.lbl_objectif.Size = new System.Drawing.Size(48, 13);
            this.lbl_objectif.TabIndex = 7;
            this.lbl_objectif.Text = "Objectifs";
            // 
            // rtxt_objectif
            // 
            this.rtxt_objectif.Location = new System.Drawing.Point(71, 167);
            this.rtxt_objectif.Name = "rtxt_objectif";
            this.rtxt_objectif.Size = new System.Drawing.Size(200, 57);
            this.rtxt_objectif.TabIndex = 8;
            this.rtxt_objectif.Text = "";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(108, 230);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(118, 41);
            this.btn_ajouter.TabIndex = 9;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // code_dom
            // 
            this.code_dom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.domaineBindingSource, "LIBELLE_DOM", true));
            this.code_dom.DataSource = this.domaineBindingSource;
            this.code_dom.DisplayMember = "LIBELLE_DOM";
            this.code_dom.FormattingEnabled = true;
            this.code_dom.Location = new System.Drawing.Point(126, 49);
            this.code_dom.Name = "code_dom";
            this.code_dom.Size = new System.Drawing.Size(145, 21);
            this.code_dom.TabIndex = 10;
            this.code_dom.ValueMember = "CODE_DOM";
            // 
            // associationBindingSource
            // 
            this.associationBindingSource.DataMember = "association";
            this.associationBindingSource.DataSource = this.sydowhDataSet;
            // 
            // associationTableAdapter
            // 
            this.associationTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Ajout_Formation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 319);
            this.Controls.Add(lIBELLE_DOMLabel);
            this.Controls.Add(this.code_dom);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.rtxt_objectif);
            this.Controls.Add(this.lbl_objectif);
            this.Controls.Add(this.lbl_niveau);
            this.Controls.Add(this.txt_niveau);
            this.Controls.Add(this.lbl_intitule);
            this.Controls.Add(this.txt_libelle);
            this.Name = "Form_Ajout_Formation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout de formation";
            this.Load += new System.EventHandler(this.Form_Ajout_Formation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sydowhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domaineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_libelle;
        private sydowhDataSet sydowhDataSet;
        private System.Windows.Forms.BindingSource formationBindingSource;
        private sydowhDataSetTableAdapters.formationTableAdapter formationTableAdapter;
        private sydowhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private sydowhDataSetTableAdapters.domaineTableAdapter domaineTableAdapter;
        private System.Windows.Forms.BindingSource domaineBindingSource;
        private System.Windows.Forms.Label lbl_intitule;
        private System.Windows.Forms.TextBox txt_niveau;
        private System.Windows.Forms.Label lbl_niveau;
        private System.Windows.Forms.Label lbl_objectif;
        private System.Windows.Forms.RichTextBox rtxt_objectif;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.ComboBox code_dom;
        private System.Windows.Forms.BindingSource associationBindingSource;
        private sydowhDataSetTableAdapters.associationTableAdapter associationTableAdapter;
    }
}