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
    public partial class PanelDomaine : Form
    {
        public static string id;
        public static string libelle;

        public PanelDomaine()
        {
            InitializeComponent();
        }

        private void PanelDomaine_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'sydowhDataSet.domaine'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.domaineTableAdapter.Fill(this.sydowhDataSet.domaine);
            DBConnect bd = new DBConnect();
            string query = "SELECT * FROM domaine";
            bd.listViewDomaine(query, list_domaines);
        }

        private void domaineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.domaineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sydowhDataSet);

        }
        /// <summary>
        /// Rafraichissement du formulaire de domaine
        /// </summary>
        public void RefreshWork()
        {
            DBConnect bd = new DBConnect();
            string query = "SELECT * FROM domaine";
            bd.listViewDomaine(query, list_domaines);
        }
        /// <summary>
        /// Créer et ouvre une form d'ajout de domaine
        /// </summary>
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Form_Ajout_Domaine addDomaine = new Form_Ajout_Domaine();
            addDomaine.Owner = this;
            addDomaine.Show();
        }
        /// <summary>
        /// Créer et ouvre une form de modification de domaine
        /// </summary>
        private void btn_select_Click(object sender, EventArgs e)
        {
            if (list_domaines.SelectedItems.Count > 0)
            {
                ListViewItem item = list_domaines.SelectedItems[0];
                PanelDomaine.id = item.SubItems[1].Text;
                PanelDomaine.libelle = item.SubItems[0].Text;
                Form_Mod_Domaine modDomaine = new Form_Mod_Domaine();
                modDomaine.Owner = this;
                modDomaine.Show();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne à modifier.", "Ok", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Créer et ouvre une form de suppression de domaine
        /// </summary>
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (list_domaines.SelectedItems.Count > 0)
            {
                ListViewItem item = list_domaines.SelectedItems[0];
                PanelDomaine.id = item.SubItems[1].Text;
                PanelDomaine.libelle = item.SubItems[0].Text;
                Form_Suppr_Domaine supprDomaine = new Form_Suppr_Domaine();
                supprDomaine.Owner = this;
                supprDomaine.Show();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne à supprimer.", "Ok", MessageBoxButtons.OK);
            }
        }
    }
}
