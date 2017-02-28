using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GSB
{
    class DAOFactory
    {
        private MySqlConnection connection;

       public DAOFactory()
        {
            this.Connexion();
        }

        public void Connexion()
        {
            string connexion = "SERVER=127.0.0.1; DATABASE=gsb_c#; UID=root; PASSWORD=root";
            this.connection = new MySqlConnection(connexion);
            Console.Write("On est co à la base");
        }

        public void Deconnexion()
        {
            this.connection.Close();
        }

        public void ExecSqlRead(String req)
        {  //à remplir 
            try
            {

            }
            catch
            {

            }
        }

    }
}
