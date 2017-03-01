using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    class Connexion
    {
        String login;
        String mdp;

        public Connexion (String login, String mdp)
        {
            this.login = login;
            this.mdp = mdp;
            this.TestInfoConnexion(login, mdp);
        }

        private void TestInfoConnexion(String login,String mdp)
        {
            DAOConnexion monDAOConnexion = new DAOConnexion(login, mdp);
            monDAOConnexion.testInfoConnexion(login, mdp);
            
        }

    }
}
