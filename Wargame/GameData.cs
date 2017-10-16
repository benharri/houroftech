using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wargame
{
    class GameData
    {
        internal int RoundNumber { get; set; }
        internal Stack<Character> RoundOrder = new Stack<Character>();
        internal List<Character> Team1 = new List<Character>();
        internal List<Character> Team2 = new List<Character>();
        internal List<Character> LivingCharacters => Team1.Concat(Team2).Where(c => c.Alive).OrderBy(c => c.Initiative).ToList();
        internal bool GameOver => !LivingCharacters.Any();

        internal string InitiativeList()
        {
            StringBuilder initiativeList = new StringBuilder();
            foreach (var c in RoundOrder)
            {
                initiativeList.AppendLine($"{c.Initiative}: {c.Name}");
            }
            return initiativeList.ToString();
        }

        internal string TeamRoster(int team = 1)
        {
            StringBuilder roster = new StringBuilder();
            foreach (var c in team == 1 ? Team1 : Team2)
            {
                roster.AppendLine($"{c}");
            }
            return roster.ToString();
        }

        internal string PrintRoundInit()
        {
            return InitiativeList();
        }
    }
}
