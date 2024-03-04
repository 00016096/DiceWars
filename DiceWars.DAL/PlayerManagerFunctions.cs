using DiceWars.DAL.Entities;

namespace DiceWars.DAL
{
    partial class PlayerManager
    {
        public async Task<List<Player>> SortAsync(ByAttribute attribute)
        {
            var players = await GetAllAsync();
            switch (attribute)
            {
                case ByAttribute.Name:
                    players.Sort(new ByNameComparer());
                    return players;
                case ByAttribute.Champions:
                    return players.Where(a => a.Score > 0).ToList();
                case ByAttribute.Losers:
                    return players.Where(a => a.Score <= 0).ToList();
                default:
                    return [];
            }

        }

        private class ByNameComparer : IComparer<Player>
        {
            public int Compare(Player? x, Player? y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }




        public async Task<List<Player>> SearchAsync(ByAttribute attribute, string searchTerm)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return (await GetAllAsync()).Where(a => a.Name.Contains(searchTerm, StringComparison.CurrentCultureIgnoreCase)).ToList();
                default:
                    return [];
            }

        }
    }
}
