﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;

namespace ICT4Events_S24_Groep_E
{
    public class DatabaseKoppeling
    {
        //Fields
        private OracleConnection conn;
        private OracleCommand command;

        //Constructor
        public DatabaseKoppeling()
        {
            conn = new OracleConnection();
            command = conn.CreateCommand();
        }
        //Methodes
        public void Koppel()
        {
            string user = "dbi318713"; //Dit is de gebruikersnaam
            string pw = "V7brKp3nww"; //Dit is het wachtwoord
            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" + "//192.168.15.50:1521/fhictora" + ";";
            try
            {
                conn.Open();
                MessageBox.Show("Connectie gelukt!");
            }
            catch 
            {
                MessageBox.Show("Connectie mislukt");
            }
            finally
            {
                conn.Close();
            }
        }

        // Frank: deze werkt nog niet ben er mee bezig (afblijven)!
        public List<Plaats> HaalPlaatsenOp()
        {
            try
            {
                string user = "dbi318713"; //Dit is de gebruikersnaam
                string pw = "V7brKp3nww"; //Dit is het wachtwoord
                conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" + "//192.168.15.50:1521/fhictora" + ";";
                conn.Open();

                command.Connection = conn;
                command.CommandText = "Select Locatienummer From Campingplaats Where id = 1";
                OracleDataReader dr = command.ExecuteReader();
                dr.Read();
                MessageBox.Show(dr.GetString(0));
                conn.Dispose();
            }
            catch(Exception)
            {

            }
            return null;
        }



    }
}
