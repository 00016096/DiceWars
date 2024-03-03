using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceWars.DAL;
using System.Windows.Forms;


namespace DiceWars
{
    public class Player
    {
        private string name;

        public int Id { get; set; }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Player's name cannot be empty");
                }
                name = value;
            }
        }
        public int IsPvPEnabled { get; set; }
        public DateTime LastGameDate { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
