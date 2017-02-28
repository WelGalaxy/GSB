using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB
{
    public partial class GSBFormConnexion : Form
    {
        public GSBFormConnexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = txbLogin.Text;
            String mdp = txbMdp.Text;
            Console.WriteLine("Login = " + login);
            Console.Write("Mdp = " + mdp);

            Connexion maConnexion = new Connexion(txbLogin.Text, txbMdp.Text);

        }
    }
}
