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
    public partial class Form_Mod_Domaine : Form
    {
        public Form_Mod_Domaine()
        {
            InitializeComponent();
        }

        private void Form_Mod_Domaine_Load(object sender, EventArgs e)
        {
            string libDomaine = PanelDomaine.libelle;
            txt_intitule.Text = libDomaine;
        }
        /// <summary>
        /// Envoie la requête de mise à jour de domaine
        /// </summary
        private void btn_valider_Click(object sender, EventArgs e)
        {
            string idDomaine = PanelDomaine.id;
            // Création de la requête
            string query = "UPDATE domaine SET LIBELLE_DOM ='" + txt_intitule.Text + "' WHERE CODE_DOM ='" + idDomaine + "'";
            DBConnect bd = new DBConnect();
            try
            {
                bd.Update(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ((PanelDomaine)Owner).RefreshWork();
            this.Close();
        }
    }
}
