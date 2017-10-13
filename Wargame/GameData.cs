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
            StringBuilder messages = new StringBuilder();
            messages.AppendLine($"\r\nRound {RoundNumber}\r\nInitiative:");
            foreach (var c in RoundOrder) messages.AppendLine($"  {c.Initiative}: {c.Name}");

            return messages.ToString();
        }

        internal string printTeamRoster(int team)
        {
            StringBuilder roster = new StringBuilder();
            roster.AppendLine($"\r\nTeam {team}:" );
            foreach (var c in team == 1 ? Team1 : Team2) roster.AppendLine($"  {c.ToString()}");

            return roster.ToString();
        }
    }
}
