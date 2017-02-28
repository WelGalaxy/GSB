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
            this.InitConnexion();
        }

        public void InitConnexion()
        {
            string connexion = "SERVER=127.0.0.1; DATABASE=gsb_c#; UID=root; PASSWORD=root";
            this.connection = new MySqlConnection(connexion);
            Console.Write("On est co à la base");
            this.execSqlWrite("INSERT INTO `comptes` (`ID`, `Login`, `Mdp`, `Type`) VALUES(NULL, 'admin', 'admin', 'admin')");
        }

        public void deconnexion()
        {
            this.connection.Close();
        }

        public void execSqlRead(String req)
        {  //à remplir 

            MySqlCommand cmd = this.connection.CreateCommand(); 
            //Création d'une commande SQL en fonction de l'objet connection
            cmd.CommandText = req; //on entre la req sql
            cmd.ExecuteNonQuery(); //on ex la req

            this.deconnexion();
            
        }

        public void execSqlWrite(String req)
        {
            MySqlCommand cmd = this.connection.CreateCommand();
            //Création d'une commande SQL en fonction de l'objet connection
            cmd.CommandText = req; //on entre la req sql
            cmd.ExecuteNonQuery(); //on ex la req

            this.deconnexion();
        }

    }
}
