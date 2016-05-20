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
    public partial class Form_Suppr_Utilisateur : Form
    {
        public Form_Suppr_Utilisateur()
        {
            InitializeComponent();
        }

        private void Form_Suppr_Utilisateur_Load(object sender, EventArgs e)
        {
            lbl_utilisateur.Text = PanelUtilisateur.email;
        }
        /// <summary>
        /// Envoie les requêtes en cascade de suppression d'utilisateur
        /// </summary
        private void btn_valider_Click(object sender, EventArgs e)
        {
            string idUtil = PanelUtilisateur.id;
            string queryDeleteParticipe = "delete from participe where CODE_UTIL= '" + idUtil + "'";
            string query = "delete from utilisateur where CODE_UTIL='" + idUtil + "'";
            DBConnect bd = new DBConnect();
            try
            {
                bd.Delete(queryDeleteParticipe);
                bd.Delete(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ((PanelUtilisateur)Owner).RefreshWork();
            this.Close();
        }
        /// <summary>
        /// Ferme le formulaire et annule la demande
        /// </summary
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
