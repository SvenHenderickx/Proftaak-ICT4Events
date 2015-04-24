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
        public List<Plaats> HaalPlaatsenOp(Hoofdboeker hoofdboeker)
        {
            List<Plaats> tempPlaatsen = new List<Plaats>();
            try
            {              
                conn.Open();
                string query = "SELECT * FROM PLAATS";
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
                    bool overlast = false;
                    if(geluidsOverlast == 0)
                    {
                        overlast = false;
                    }
                    else
                    {
                        overlast = true;
                    }

                    // als een plaats nog niet in een reservering zit 
                    int reservering;
                    if(Convert.ToInt32(dataReader["Reservering_ID"]) != null)
                    {
                        reservering = Convert.ToInt32(dataReader["Reservering_ID"]);
                        //query = "SELECT"
                    }
                    else
                    {
                        
                        Plaats p = new Plaats(prijs, null, overlast, aantalPersonen);
                        tempPlaatsen.Add(p);
                    }                  
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

        public List<Persoon> HaalPersonenOp()
        {
            // in deze methode doen we nog niets met RFID
            List<Persoon> personen = new List<Persoon>();
            try
            {
                conn.Open();
                // met deze query krijg je alle hoofdboekers
                // in de where staat nu 'SME' dit moet veranderen in de variabele van huidigevent
                string eventnaam = administratie.HuidigEvent.Naam;
                
                // geef alle hoofdboekers van het !!!SME event!!!
                string query = "SELECT * FROM PERSOON p, HOOFDBOEKER h, BEZOEKER b WHERE p.RFID = h.RFID and h.RFID = b.RFID and p.Event_ID = (SELECT ID FROM EVENT WHERE naam = 'SME')";
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
                    personen.Add(new Hoofdboeker(Convert.ToString(dataReader["Gebruikersnaam"]), Convert.ToString(dataReader["Wachtwoord"]), Convert.ToDateTime(dataReader["Geboortedatum"]), Convert.ToString(dataReader["Reknr"]), Convert.ToString(dataReader["Naam"]), Convert.ToString(dataReader["Achternaam"]), aanwezig));
                }

                //geef alle controleurs van het SME event
                query = "SELECT * FROM PERSOON p, CONTROLEUR c WHERE p.RFID = c.RFID and p.Event_id = (Select ID FROM EVENT WHERE naam = 'SME')";
                command = new OracleCommand(query, conn);
                dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    personen.Add(new Controleur(Convert.ToString(dataReader["Gebruikersnaam"]), Convert.ToString(dataReader["Wachtwoord"]), Convert.ToDateTime(dataReader["Geboortedatum"]), Convert.ToString(dataReader["Naam"]), Convert.ToString(dataReader["Achternaam"])));
                }

                // geef alle beheerders van het SME event
                query = "SELECT * FROM PERSOON p, Beheerder b WHERE p.RFID = b.RFID and p.Event_id = (Select ID FROM EVENT WHERE naam = 'SME')";
                command = new OracleCommand(query, conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    personen.Add(new Beheerder(Convert.ToString(dataReader["Gebruikersnaam"]), Convert.ToString(dataReader["Wachtwoord"]), Convert.ToDateTime(dataReader["Geboortedatum"]), Convert.ToString(dataReader["Naam"]), Convert.ToString(dataReader["Achternaam"])));
                }

                // geef alle bezoekers van het SME event
                query = "SELECT * FROM PERSOON p, Bezoeker b WHERE p.RFID = b.RFID and p.Event_id = (Select ID FROM EVENT WHERE naam = 'SME')";
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
                    personen.Add(new Bezoeker(Convert.ToString(dataReader["Gebruikersnaam"]), Convert.ToString(dataReader["Wachtwoord"]), Convert.ToDateTime(dataReader["Geboortedatum"]), Convert.ToString(dataReader["Naam"]), Convert.ToString(dataReader["Achternaam"]), aanwezig));
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


        public List<Huuritem> HaalHuuritemOp()
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
    }
}
