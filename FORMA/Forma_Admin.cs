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
    public partial class Forma_Admin : Form
    {
        public Forma_Admin()
        {
            InitializeComponent();
            AcceptButton = btn_connexion;

        }

        private void Forma_Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            DBConnect bd  = new DBConnect();
            string email = txtb_id.Text;
            string mdp = txtb_mdp.Text;
            string query = "SELECT COUNT(*) FROM utilisateur WHERE EMAIL_UTIL = '" + email + "' AND MDP_UTIL = '" + mdp + "'";  
            if(bd.Count(query) == 1)
            {
                Panel panel = new Panel();
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erreur dans l'identifiant ou le mot de passe", "Recommencer", MessageBoxButtons.OK);
            }

        }

        private void Forma_Admin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
