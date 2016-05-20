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
    public partial class PanelUtilisateur : Form
    {
        public static string id;
        public static string email;
        public PanelUtilisateur()
        {
            InitializeComponent();
        }

        private void PanelUtilisateur_Load(object sender, EventArgs e)
        {
            DBConnect bd = new DBConnect();
            string query = "SELECT * FROM utilisateur as u, association as a WHERE u.NUM_ICOM = a.NUM_ICOM";
            bd.listViewUtilisateur(query, list_utilisateur);
        }
        /// <summary>
        /// Rafraichissement du formulaire des utilisateurs
        /// </summary
        public void RefreshWork()
        {
            DBConnect bd = new DBConnect();
            string query = "SELECT * FROM utilisateur as u, association as a WHERE u.NUM_ICOM = a.NUM_ICOM";
            bd.listViewUtilisateur(query, list_utilisateur);
        }
        /// <summary>
        /// Créer et ouvre une form de suppresion de formation
        /// </summary
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (list_utilisateur.SelectedItems.Count > 0)
            {
                ListViewItem item = list_utilisateur.SelectedItems[0];
                PanelUtilisateur.id = item.SubItems[5].Text;
                PanelUtilisateur.email = item.SubItems[0].Text;
                Form_Suppr_Utilisateur supprUtilisateur = new Form_Suppr_Utilisateur();
                supprUtilisateur.Owner = this;
                supprUtilisateur.Show();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne à supprimer.", "Ok", MessageBoxButtons.OK);
            }
        }
    }
}
