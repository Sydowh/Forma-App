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
    public partial class Form_Mod_Formation : Form
    {
        public Form_Mod_Formation()
        {
            InitializeComponent();
        }

        private void Form_Mod_Formation_Load(object sender, EventArgs e)
        {
            string libFormation = PanelFormation.libelle;
            string libNiveau = PanelFormation.niveau;
            string libObjectifs = PanelFormation.objectif;

            txt_intitule.Text = libFormation;
            txt_niveau.Text = libNiveau;
            rtxt_objectifs.Text = libObjectifs;
        }
        /// <summary>
        /// Envoie la requête de mise à jour de formation sur la base de données
        /// </summary
        private void btn_valider_Click(object sender, EventArgs e)
        {
            string idFormation = PanelFormation.id;
            // Création de la requête
            string query = "UPDATE formation SET LIBELLE_FORM ='" + txt_intitule.Text + "',NIVEAU_FORM='" + txt_niveau.Text + "',OBJECTIFS ='" + rtxt_objectifs.Text + "' WHERE CODE_FORM ='" + idFormation + "'";
            DBConnect bd = new DBConnect();
            try
            {
                bd.Update(query);
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
