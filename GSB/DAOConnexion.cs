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
        String requeteSql;

        public DAOConnexion(String login,String mdp)
        {
            this.login = login;
            this.mdp = mdp;
        }

        public void testInfoConnexion(String login, String mdp)
        {
            requeteSql = "SELECT Mdp FROM comptes WHERE Login = '" + login+"'";
            DAOFactory monObjet = new DAOFactory();
            monObjet.execSqlRead(requeteSql);
            
        }
    }
}
