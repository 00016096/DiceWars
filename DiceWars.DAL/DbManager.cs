using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWars.DAL
{
    public class DbManager
    {
        protected SQLiteConnection Connection
        {
            get
            {
                return new SQLiteConnection(ConfigurationManager.ConnectionStrings["DiceWars"].ConnectionString);
            }
        }
    }
}
