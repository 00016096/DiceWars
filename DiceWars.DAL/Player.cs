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
        public int Id { get; set; }
        public string Name { get; set; }
        public int IsPvPEnabled { get; set; }
        public DateTime LastGameDate { get; set; }
        public int Score { get; set; }
    }
}
