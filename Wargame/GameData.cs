using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            messages.AppendLine("\r\nTeam 1:");
            foreach (var c in Team1) messages.AppendLine($"  {c.ToString()}");
            messages.AppendLine("\r\nTeam 2:");
            foreach (var c in Team2) messages.AppendLine($"  {c.ToString()}");

            messages.AppendLine($"\r\nRound {RoundNumber}\r\nInitiative:");
            foreach (var c in RoundOrder) messages.AppendLine($"  {c.Initiative}: {c.Name}");

            return messages.ToString();
        }
    }
}
