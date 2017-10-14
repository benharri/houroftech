using System;
using System.Collections.Generic;
using System.Text;

namespace Wargame
{
    class GameData
    {
        internal int RoundNumber { get; set; }
        internal Stack<Character> RoundOrder = new Stack<Character>();
        internal List<Character> Team1 = new List<Character>();
        internal List<Character> Team2 = new List<Character>();

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
                roster.Append(c);
                roster.AppendLine();
            }
            return roster.ToString();
        }

        internal string PrintRoundInit()
        {
            return InitiativeList();
        }
    }
}
