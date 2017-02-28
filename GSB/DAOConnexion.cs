using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    class DAOConnexion
    {
       String login;
        String mdp;

        public DAOConnexion(String login,String mdp)
        {
            this.login = login;
            this.mdp = mdp;
        }

        public void testInfoConnexion(String login, String mdp)
        {
            Console.WriteLine("on crée un objet dao factory");
            DAOFactory objet = new DAOFactory();
            
        }
    }
}
