using System;
using System.Collections.Generic;
using System.Text;

namespace Wargame
{
    class GameData
    {
        public int RoundNumber { get; set; }
        public Stack<Character> RoundOrder = new Stack<Character>();
        public List<Character> Team1 = new List<Character>();
        public List<Character> Team2 = new List<Character>();

        public override string ToString()
        {
            return InitiativeList();
        }

        internal string InitiativeList()
        {
            StringBuilder initiativeList = new StringBuilder();
            initiativeList.AppendLine($"Round {RoundNumber}\r\nInitiative:");
            foreach (var c in RoundOrder)
                initiativeList.AppendLine($"  {c.Initiative}: {c.Name}");
            return initiativeList.ToString();
        }

        internal string TeamRoster(int team = 1)
        {
            StringBuilder roster = new StringBuilder();
            roster.AppendLine($"Team {team}:");
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
