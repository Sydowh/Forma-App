using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FORMA;

namespace FORMA
{
    public partial class PanelFormation : Form
    {
        public static string id;
        public static string libelle;
        public static string niveau;
        public static string objectif;
        public PanelFormation()
        {
            InitializeComponent();
        }
        private void PanelFormation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'sydowhDataSet.domaine'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.domaineTableAdapter.Fill(this.sydowhDataSet.domaine);
            // TODO: cette ligne de code charge les données dans la table 'sydowhDataSet.formation'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.formationTableAdapter.Fill(this.sydowhDataSet.formation);
            DBConnect bd = new DBConnect();
            string query = "SELECT * FROM formation";
            bd.listViewFormation(query, list_formations);
        }
        /// <summary>
        /// Rafraichissement du formulaire de formation
        /// </summary>
        public void RefreshWork()
        {
            DBConnect bd = new DBConnect();
            string query = "SELECT * FROM formation";
            bd.listViewFormation(query, list_formations);
        }
        /// <summary>
        /// Créer et ouvre une form d'ajoût de formation
        /// </summary>
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Form_Ajout_Formation FormAjoutFormation = new Form_Ajout_Formation();
            FormAjoutFormation.Owner = this;
            FormAjoutFormation.Show();
        }
        /// <summary>
        /// Créer et ouvre une form de modification de formation
        /// </summary
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (list_formations.SelectedItems.Count > 0)
            {
                ListViewItem item = list_formations.SelectedItems[0];
                PanelFormation.id = item.SubItems[3].Text;
                PanelFormation.libelle = item.SubItems[0].Text;
                PanelFormation.niveau = item.SubItems[1].Text;
                PanelFormation.objectif = item.SubItems[2].Text;
                Form_Mod_Formation modFormation = new Form_Mod_Formation();
                modFormation.Owner = this;
                modFormation.Show();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne à modifier.", "Erreur", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Créer et ouvre une form de suppresion de formation
        /// </summary
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (list_formations.SelectedItems.Count > 0)
            {
                ListViewItem item = list_formations.SelectedItems[0];
                PanelFormation.id = item.SubItems[3].Text;
                PanelFormation.libelle = item.SubItems[0].Text;
                Form_Suppr_Formation supprFormation = new Form_Suppr_Formation();
                supprFormation.Owner = this;
                supprFormation.Show();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne à modifier.", "Erreur!", MessageBoxButtons.OK);
            }
        }
    }
}
