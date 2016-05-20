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
    public partial class Form_Ajout_Domaine : Form
    {
        public Form_Ajout_Domaine()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Envoie la requête d'insertion de domaine dans la base de données
        /// </summary
        private void btn_valider_Click(object sender, EventArgs e)
        {
            DBConnect bd = new DBConnect();
            // Ajout dans la base de données
            // Récupération des données 
            string libelleDom = txt_domaine.Text;
            string query = "INSERT INTO domaine(LIBELLE_DOM) VALUES('" + libelleDom + "')";
            try
            {
                bd.Insert(query);
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
