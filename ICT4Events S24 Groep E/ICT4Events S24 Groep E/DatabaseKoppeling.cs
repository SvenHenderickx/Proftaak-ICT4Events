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
        string user = "dbi318713"; //Dit is de gebruikersnaam
        string pw = "V7brKp3nww"; //Dit is het wachtwoord
        private static Administratie administratie = new Administratie();

        //Constructor
        public DatabaseKoppeling()
        {
            conn = new OracleConnection();
            command = conn.CreateCommand();
            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" + "//192.168.15.50:1521/fhictora" + ";";
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
        // IK WERK HIER NOG AAN
        public List<Plaats> HaalPlaatsenOp()
        {
            List<Plaats> plaatsen = new List<Plaats>();
            try
            {              
                conn.Open();
                // query van alle plaatsen met de eventueel bijbehorende
                // hoofdboekers
                string query = "SELECT * FROM PLAATS pl LEFT JOIN RESERVERING r ON pl.Reservering_ID = r.ID";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                // dataReader gaat record voor record omlaag totdat 
                // er niets meer is.
                while(dataReader.Read())
                {
                    // getal tussen haakjes is de gewenste kolom :D
                    int prijs = Convert.ToInt32(dataReader["Prijs"]);
                    int aantalPersonen = Convert.ToInt32(dataReader["Aantalpersonen"]);
                    int geluidsOverlast = Convert.ToInt32(dataReader["Geluidsoverlast"]);
                    string hbRFID = Convert.ToString(dataReader["Hoofdboeker_RFID"]);
                    string locatienummer = Convert.ToString(dataReader["Locatienummer"]);
                    bool overlast = false;
                    if(geluidsOverlast == 0)
                    {
                        overlast = false;
                    }
                    else
                    {
                        overlast = true;
                    }
                    bool verhuurd;
                    if (Convert.ToInt32(dataReader["Verhuurd"]) == 0)
                    {
                        verhuurd = false;
                    }
                    else
                    {
                        verhuurd = true;
                    }
                    // als een plaats nog niet in een reservering zit 
                    // dan moet er bij beheerder niets worden meegegeven
                    // anders moet er een nieuwe beheerder worden aangemaakt
                    // om mee te geven aan de plaats
                    // hier is dus een hoofdboeker
                    // andere query schrijven voor de informatie van deze hoofdboeker 
                    
                    // hoofdboeker wordt hier nog niet aan toegevoegd!
                    Plaats p = new Plaats(prijs, null, overlast, aantalPersonen, verhuurd, locatienummer);
                    plaatsen.Add(p);                                    
                }
                return plaatsen;
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

        public List<Persoon> HaalPersonenOp(string eventNaam)
        {
            // in deze methode doen we nog niets met RFID
            List<Persoon> personen = new List<Persoon>();
            try
            {
                conn.Open();
                // met deze query krijg je alle hoofdboekers
                // in de where staat nu 'SME' dit moet veranderen in de variabele van huidigevent
                
                // geef alle hoofdboekers van het !!!SME event!!!
                string query = "SELECT * FROM PERSOON p, HOOFDBOEKER h, BEZOEKER b WHERE p.RFID = h.RFID and h.RFID = b.RFID and p.Event_ID = (SELECT ID FROM EVENT WHERE naam = '" + eventNaam + "')";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int anwezig = Convert.ToInt32(dataReader["Aanwezig"]);
                    bool aanwezig = false;
                    if(anwezig == 0)
                    {
                        aanwezig = false;
                    }
                    else
                    {
                        aanwezig = true;
                    }
                    personen.Add(new Hoofdboeker(Convert.ToString(dataReader["Gebruikersnaam"]), Convert.ToString(dataReader["Wachtwoord"]), Convert.ToDateTime(dataReader["Geboortedatum"]), Convert.ToString(dataReader["Reknr"]), Convert.ToString(dataReader["Naam"]), Convert.ToString(dataReader["Achternaam"]), aanwezig, Convert.ToString(dataReader["rfid"])));
                }

                //geef alle controleurs van het SME event
                query = "SELECT * FROM PERSOON p, CONTROLEUR c WHERE p.RFID = c.RFID and p.Event_id = (Select ID FROM EVENT WHERE naam = '" + eventNaam + "')";
                command = new OracleCommand(query, conn);
                dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    personen.Add(new Controleur(Convert.ToString(dataReader["Gebruikersnaam"]), Convert.ToString(dataReader["Wachtwoord"]), Convert.ToDateTime(dataReader["Geboortedatum"]), Convert.ToString(dataReader["Naam"]), Convert.ToString(dataReader["Achternaam"]), Convert.ToString(dataReader["rfid"])));
                }

                // geef alle beheerders van het SME event
                query = "SELECT * FROM PERSOON p, Beheerder b WHERE p.RFID = b.RFID and p.Event_id = (Select ID FROM EVENT WHERE naam = '" + eventNaam + "')";
                command = new OracleCommand(query, conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    personen.Add(new Beheerder(Convert.ToString(dataReader["Gebruikersnaam"]), Convert.ToString(dataReader["Wachtwoord"]), Convert.ToDateTime(dataReader["Geboortedatum"]), Convert.ToString(dataReader["Naam"]), Convert.ToString(dataReader["Achternaam"]), Convert.ToString(dataReader["rfid"])));
                }

                // geef alle bezoekers van het SME event
                query = "SELECT * FROM PERSOON p, Bezoeker b WHERE p.RFID = b.RFID and p.Event_id = (Select ID FROM EVENT WHERE naam = '" + eventNaam + "')";
                command = new OracleCommand(query, conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int anwezig = Convert.ToInt32(dataReader["Aanwezig"]);
                    bool aanwezig = false;
                    if(anwezig == 0)
                    {
                        aanwezig = false;
                    }
                    else
                    {
                        aanwezig = true;
                    }
                    personen.Add(new Bezoeker(Convert.ToString(dataReader["Gebruikersnaam"]), Convert.ToString(dataReader["Wachtwoord"]), Convert.ToDateTime(dataReader["Geboortedatum"]), Convert.ToString(dataReader["Naam"]), Convert.ToString(dataReader["Achternaam"]), aanwezig, Convert.ToString(dataReader["rfid"])));
                }
                return personen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return null;
        }


        public List<Huuritem> HaalHuuritemsOp()
        {
            List<Huuritem> tempHuuritem = new List<Huuritem>();
            try
            {
                conn.Open();
                //Deze query haalt alle huuritems op
                string query = "SELECT * FROM HUURITEM";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string naam = Convert.ToString(dataReader["Naam"]);
                    string type = Convert.ToString(dataReader["Type"]);
                    int prijs = Convert.ToInt32(dataReader["Prijs"]);
                    int verhuurd = Convert.ToInt32(dataReader["Verhuurd"]);
                    bool gehuurd = false;
                    if (verhuurd == 0)
                    {
                        gehuurd = false;
                    }
                    else
                    {
                        gehuurd = true;
                    }
                    Huuritem h = new Huuritem(naam, type, prijs, gehuurd);
                    tempHuuritem.Add(h);
                }
                return tempHuuritem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public List<Event> HaalAlleEvenementen()
        {
            List<Event> tempEvent = new List<Event>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM Event";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string naam = Convert.ToString(dataReader["NAAM"]);
                    DateTime beginDatum = Convert.ToDateTime(dataReader["BEGINDATUM"]);
                    DateTime eindDatum = Convert.ToDateTime(dataReader["EINDDATUM"]);
                    string plaats = Convert.ToString(dataReader["PLAATS"]);
                    string adres = Convert.ToString(dataReader["ADRES"]);
                    tempEvent.Add(new Event(naam, beginDatum, eindDatum, plaats, adres));
                }
                return tempEvent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public bool CheckInOut(string rfid)
        {
            foreach (Persoon p in HaalPersonenOp(administratie.HuidigEvent.Naam))
            {
                if (p is Bezoeker)
                {
                    Bezoeker b = p as Bezoeker;
                    if (b.Aanwezig && b.RfidCode == rfid)
                    {
                        try
                        {
                            conn.Open();
                            string query = "UPDATE BEZOEKER SET AANWEZIG = 0 WHERE RFID = " + rfid;
                            command = new OracleCommand(query, conn);
                            command.ExecuteNonQuery();
                            return true;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                        finally
                        {
                            conn.Close();
                        }                      
                    }
                    else if(b.RfidCode == rfid)
                    {
                        try
                        {
                            conn.Open();
                            string query = "UPDATE BEZOEKER SET AANWEZIG = 1 WHERE RFID = " + rfid ;
                            command = new OracleCommand(query, conn);
                            command.ExecuteNonQuery();
                            return true;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                        finally
                        {
                            conn.Close();
                        }
                        
                    }
                }
            }
            return false;
        }

        public List<Bericht> VraagBerichtenOpVanEvent(string eventNaam)
        {
            List<Bericht> tempList = new List<Bericht>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM bericht WHERE event_id = (SELECT id FROM event WHERE naam = '" + eventNaam + "')";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string persoonRfid = Convert.ToString(dataReader["persoon_rfid"]);
                    DateTime date = Convert.ToDateTime(dataReader["plaatsdatum"]);
                    int id = Convert.ToInt32(dataReader["id"]);
                    string tekst = Convert.ToString(dataReader["bericht"]);
                    int berichtSoort = Convert.ToInt32(dataReader["berichtsoort"]);
                    tempList.Add(new Bericht(tekst, administratie.HuidigEvent.CheckGebruikersNaamRfid(persoonRfid), date, berichtSoort, id));
                }
                return tempList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }
}
