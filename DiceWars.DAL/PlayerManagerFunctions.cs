using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiceWars.DAL.Entities;

namespace DiceWars.DAL
{
    partial class PlayerManager
    {
        public List<Player> Sort(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    var players = GetAll();
                    players.Sort(new ByNameComparer());
                    return players;
                case ByAttribute.Champions:
                    return GetAll().Where(a => a.Score > 0).ToList();
                case ByAttribute.Losers:
                    return GetAll().Where(a => a.Score <= 0).ToList();
            }

            return null;
        }

        private class ByNameComparer : IComparer<Player>
        {
            public int Compare(Player? x, Player? y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }




        public List<Player> Search(ByAttribute attribute, string searchTerm)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAll().Where(a => a.Name.ToLower().Contains(searchTerm.ToLower())).ToList();
            }

            return null;
        }
    }
}
