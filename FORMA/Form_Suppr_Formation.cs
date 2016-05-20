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
    public partial class Form_Suppr_Formation : Form
    {
        public Form_Suppr_Formation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Envoie les requêtes en cascade de suppression de formation
        /// </summary
        private void Form_Suppr_Formation_Load(object sender, EventArgs e)
        {
            lbl_formation.Text = PanelFormation.libelle;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string idFormation = PanelFormation.id;
            string queryDeleteParticipe = "delete from participe where CODE_FORM= '" + idFormation + "'";
            string queryDeleteInterv = "delete from intervient where CODE_FORM= '" + idFormation + "'";
            string queryDeleteSession = "delete from session where CODE_FORM= '" + idFormation + "'";
            string query = "delete from formation where CODE_FORM= '" + idFormation + "'";
            DBConnect bd = new DBConnect();
            try
            {
                bd.Delete(queryDeleteParticipe);
                bd.Delete(queryDeleteInterv);
                bd.Delete(queryDeleteSession);
                bd.Delete(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ((PanelFormation)Owner).RefreshWork();
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
