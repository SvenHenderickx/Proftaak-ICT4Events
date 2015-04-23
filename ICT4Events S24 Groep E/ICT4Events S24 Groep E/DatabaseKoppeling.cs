using System;
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

        // Frank: Deze methode werkt er moet in de database alleen nog kijken hoe we dit met de hoofdboeker moeten doen. 
        public List<Plaats> HaalPlaatsenOp(Hoofdboeker hoofdboeker)
        {
            List<Plaats> tempPlaatsen = new List<Plaats>();
            try
            {
                
                
                conn.Open();
                string query = "SELECT * FROM CAMPINGPLAATS";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                // dataReader gaat record voor record omlaag totdat 
                // er niets meer is.
                while(dataReader.Read())
                {
                    // getal tussen haakjes is de gewenste kolom :D
                    int prijs = Convert.ToInt32(dataReader[3]);
                    int aantalPersonen = Convert.ToInt32(dataReader[4]);
                    bool geluidsOverlast = true;
                    Plaats p = new Plaats(prijs, hoofdboeker, geluidsOverlast, aantalPersonen);
                    tempPlaatsen.Add(p);
                }
                return tempPlaatsen;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public List<Bericht> BerichtenOphalenVanEvent(Event evenement)
        {
            return null;
        }



    }
}
