using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_tehtävä
{
    class YHDISTA
    {
        public string yhteyslause()
        {
            return "datasource=localhost; port=3306;username=root;password=;database=hotelli";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=opiskelijat");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        public void avaaYhteys()
        {
            if(yhteys.State == System.Data.ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        public void suljeYhteys()
        {
            if(yhteys.State == System.Data.ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
