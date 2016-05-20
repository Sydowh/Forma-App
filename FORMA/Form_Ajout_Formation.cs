using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMA
{
    public partial class Form_Ajout_Formation : Form
    {
        public Form_Ajout_Formation()
        {
            InitializeComponent();
        }

        private void formationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.formationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sydowhDataSet);

        }

        private void Form_Ajout_Formation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'sydowhDataSet.association'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.associationTableAdapter.Fill(this.sydowhDataSet.association);
            // TODO: cette ligne de code charge les données dans la table 'sydowhDataSet.domaine'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.domaineTableAdapter.Fill(this.sydowhDataSet.domaine);
            // TODO: cette ligne de code charge les données dans la table 'sydowhDataSet.formation'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.formationTableAdapter.Fill(this.sydowhDataSet.formation);

        }
        /// <summary>
        /// Envoie la requête d'ajout de formation à la base de données
        /// </summary
        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect bd = new DBConnect();
            // Ajout dans la base de données
            // Récupération des données 
            string codeDom = code_dom.SelectedValue.ToString();
            string txtLibelle = txt_libelle.Text;
            string txtNiveau = txt_niveau.Text;
            string txtObjectifs = rtxt_objectif.Text;
            string query = "INSERT INTO formation(CODE_DOM, LIBELLE_FORM, NIVEAU_FORM, OBJECTIFS) VALUES('" + codeDom + "','" + txtLibelle + "','" + txtNiveau + "','" + txtObjectifs + "')";
            try
            {
                bd.Insert(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ((PanelFormation)Owner).RefreshWork();
            this.Close();
        }
    }
}
