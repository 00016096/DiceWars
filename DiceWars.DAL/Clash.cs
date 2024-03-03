﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceWars.DAL;
using System.Windows.Forms;


namespace DiceWars
{
    public class Clash
    {
        private Player player2;
        private Player player1;

        public int Id { get; set; }
        public Player Player1
        {
            get
            {
                return player1;
            }

            set
            {
                player1 = value;
            }
        }
        public Player Player2
        {
            get
            {
                return player2;
            }

            set
            {
                player2 = value;
            }
        }
        public DateTime Date { get; set; }
        public int Outcome { get; set; }
    }
}
