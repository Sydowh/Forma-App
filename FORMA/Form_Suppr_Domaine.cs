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
    public partial class Form_Suppr_Domaine : Form
    {
        public Form_Suppr_Domaine()
        {
            InitializeComponent();
        }

        private void Form_Suppr_Domaine_Load(object sender, EventArgs e)
        {
            lbl_domaine.Text = PanelDomaine.libelle;
        }
        /// <summary>
        /// Envoie les requêtes en cascade de suppression de domaine
        /// </summary
        private void btn_valider_Click(object sender, EventArgs e)
        {
            string idDomaine = PanelDomaine.id;
            string queryDeleteParticipe = "delete from participe where CODE_DOM= '" + idDomaine + "'";
            string queryDeleteInterv = "delete from intervient where CODE_DOM= '" + idDomaine + "'";
            string queryDeleteSession = "delete from session where CODE_DOM= '" + idDomaine + "'";
            string queryDeleteForm = "delete from formation where CODE_DOM= '" + idDomaine + "'";
            string query = "delete from domaine where CODE_DOM ='" + idDomaine + "'";
            DBConnect bd = new DBConnect();
            try
            {
                bd.Delete(queryDeleteParticipe);
                bd.Delete(queryDeleteInterv);
                bd.Delete(queryDeleteSession);
                bd.Delete(queryDeleteForm);
                bd.Delete(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ((PanelDomaine)Owner).RefreshWork();
            this.Close();
        }
        /// <summary>
        /// Ferme le formulaire et annule la demande
        /// </summary
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
