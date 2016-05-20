namespace FORMA
{
    partial class PanelFormation
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
            this.list_formations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.sydowhDataSet = new FORMA.sydowhDataSet();
            this.formationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formationTableAdapter = new FORMA.sydowhDataSetTableAdapters.formationTableAdapter();
            this.tableAdapterManager = new FORMA.sydowhDataSetTableAdapters.TableAdapterManager();
            this.domaineTableAdapter = new FORMA.sydowhDataSetTableAdapters.domaineTableAdapter();
            this.formationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.domaineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.sydowhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domaineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // list_formations
            // 
            this.list_formations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list_formations.LabelEdit = true;
            this.list_formations.Location = new System.Drawing.Point(12, 12);
            this.list_formations.Name = "list_formations";
            this.list_formations.Size = new System.Drawing.Size(540, 185);
            this.list_formations.TabIndex = 0;
            this.list_formations.UseCompatibleStateImageBehavior = false;
            this.list_formations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Libellé";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Niveau";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Objectif";
            this.columnHeader3.Width = 200;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(13, 217);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(88, 40);
            this.btn_ajouter.TabIndex = 1;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(107, 217);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(88, 40);
            this.btn_modifier.TabIndex = 2;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(201, 217);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(88, 40);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
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
            // formationBindingSource1
            // 
            this.formationBindingSource1.DataMember = "formation";
            this.formationBindingSource1.DataSource = this.sydowhDataSet;
            // 
            // domaineBindingSource
            // 
            this.domaineBindingSource.DataMember = "domaine";
            this.domaineBindingSource.DataSource = this.sydowhDataSet;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "id";
            this.columnHeader4.Width = 0;
            // 
            // PanelFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 281);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.list_formations);
            this.Name = "PanelFormation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel d\'administration - Formation";
            this.Load += new System.EventHandler(this.PanelFormation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sydowhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domaineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_formations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private sydowhDataSet sydowhDataSet;
        private System.Windows.Forms.BindingSource formationBindingSource;
        private sydowhDataSetTableAdapters.formationTableAdapter formationTableAdapter;
        private sydowhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource formationBindingSource1;
        private sydowhDataSetTableAdapters.domaineTableAdapter domaineTableAdapter;
        private System.Windows.Forms.BindingSource domaineBindingSource;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}