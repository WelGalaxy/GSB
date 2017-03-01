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
        private MySqlConnection connectionBDD;

       public DAOFactory()
        {
            this.InitConnexion();
        }

        public void InitConnexion()
        {

            string connexion = "SERVER=127.0.0.1; DATABASE=gsb_c#; UID=root; PASSWORD=root";
            this.connectionBDD = new MySqlConnection(connexion);
        }

        private bool OpenConnection()
        {
            try
            {
                connectionBDD.Open();
                return true;
            }

            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid UserName/Password");
                        break;
                }

                return false;
            }
        }

        public void deconnexion()
        {
            this.connectionBDD.Close();
        }

        public void execSqlRead(String req)
        {  //à remplir 
            this.OpenConnection();
            MySqlCommand cmd = this.connectionBDD.CreateCommand(); 
            //Création d'une commande SQL en fonction de l'objet connection

            
            cmd.CommandText = req; //on entre la req sql
            MySqlDataReader monResult = cmd.ExecuteReader();
            Console.WriteLine("Req Select = " + monResult);

            this.deconnexion();
            
        }

        public void execSqlWrite(String req)
        {
            this.OpenConnection();
            MySqlCommand cmd = this.connectionBDD.CreateCommand();
            //Création d'une commande SQL en fonction de l'objet connection
            cmd.CommandText = req; //on entre la req sql
            cmd.ExecuteNonQuery(); //on ex la req
            this.deconnexion();
        }

    }
}
