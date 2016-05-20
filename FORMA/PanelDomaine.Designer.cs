namespace FORMA
{
    partial class PanelDomaine
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
            this.list_domaines = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sydowhDataSet = new FORMA.sydowhDataSet();
            this.domaineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domaineTableAdapter = new FORMA.sydowhDataSetTableAdapters.domaineTableAdapter();
            this.tableAdapterManager = new FORMA.sydowhDataSetTableAdapters.TableAdapterManager();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sydowhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domaineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // list_domaines
            // 
            this.list_domaines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list_domaines.Location = new System.Drawing.Point(13, 13);
            this.list_domaines.Name = "list_domaines";
            this.list_domaines.Size = new System.Drawing.Size(540, 185);
            this.list_domaines.TabIndex = 0;
            this.list_domaines.UseCompatibleStateImageBehavior = false;
            this.list_domaines.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Intitulé";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 0;
            // 
            // sydowhDataSet
            // 
            this.sydowhDataSet.DataSetName = "sydowhDataSet";
            this.sydowhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // domaineBindingSource
            // 
            this.domaineBindingSource.DataMember = "domaine";
            this.domaineBindingSource.DataSource = this.sydowhDataSet;
            // 
            // domaineTableAdapter
            // 
            this.domaineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.associationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.domaineTableAdapter = this.domaineTableAdapter;
            this.tableAdapterManager.formationTableAdapter = null;
            this.tableAdapterManager.intervenantTableAdapter = null;
            this.tableAdapterManager.intervientTableAdapter = null;
            this.tableAdapterManager.participeTableAdapter = null;
            this.tableAdapterManager.sessionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FORMA.sydowhDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(107, 219);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(88, 40);
            this.btn_modifier.TabIndex = 1;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(13, 219);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(88, 40);
            this.btn_ajouter.TabIndex = 2;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(201, 219);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(88, 40);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // PanelDomaine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 281);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.list_domaines);
            this.Name = "PanelDomaine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel d\'administration - Domaine";
            this.Load += new System.EventHandler(this.PanelDomaine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sydowhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domaineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_domaines;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private sydowhDataSet sydowhDataSet;
        private System.Windows.Forms.BindingSource domaineBindingSource;
        private sydowhDataSetTableAdapters.domaineTableAdapter domaineTableAdapter;
        private sydowhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_supprimer;
    }
}