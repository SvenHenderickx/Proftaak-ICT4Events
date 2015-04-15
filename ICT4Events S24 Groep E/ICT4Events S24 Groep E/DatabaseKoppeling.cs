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
        private OracleConnection conn;
        private OracleCommand command;

        public DatabaseKoppeling()
        {
            conn = new OracleConnection();
            command = conn.CreateCommand();

            string user = "dbi318713";
            string pw = "V7brKp3nww";
            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" + "//192.168.15.50:1521/fhictora" + ";";
            try
            {
                conn.Open();
                MessageBox.Show("Connectie gelukt!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connectie mislukt");
            }
        }
    }
}
