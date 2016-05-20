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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ouvre le panel des formations
        /// </summary>
        private void btn_formation_Click(object sender, EventArgs e)
        {
            PanelFormation panelFormation = new PanelFormation();
            panelFormation.Show();
        }
        /// <summary>
        /// Ouvre le panel des domaines
        /// </summary>
        private void btn_domaine_Click(object sender, EventArgs e)
        {
            PanelDomaine panelDomaine = new PanelDomaine();
            panelDomaine.Show();
        }
        /// <summary>
        /// Ouvre le panel des utilisateurs
        /// </summary>
        private void btn_utilisateur_Click(object sender, EventArgs e)
        {
            PanelUtilisateur panelUtilisateur = new PanelUtilisateur();
            panelUtilisateur.Show();

        }
        /// <summary>
        /// Fermeture totale de l'application
        /// </summary>
        private void Panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
