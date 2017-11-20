using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Wargame.Characters;
using Wargame.Vendor;

namespace Wargame.Core
{
    public class GameData
    {
        public int RoundNumber { get; set; }
        public Stack<Character> RoundOrder;
        public readonly BindingList<Character> Team1 = new BindingList<Character>();
        public readonly BindingList<Character> Team2 = new BindingList<Character>();
        internal BindingList<Character> AvailableCharacters = new BindingList<Character>();
        public BindingList<Item> Vendor = new BindingList<Item>();
        public readonly BindingList<Item> PlayerInventory = new BindingList<Item>();
        public int PlayerGold = 100;
        private IEnumerable<Character> AllCharacters => Team1.Concat(Team2);
        private IEnumerable<Character> LivingCharacters => AllCharacters.Where(c => c.Alive).OrderBy(c => c.Initiative);
        internal bool GameOver => !LivingCharacters.Any();
        private const int TeamSize = 5;
        public bool TeamsFull => Team1.Count == TeamSize && Team2.Count == TeamSize;

        public GameData() { }

        internal string InitiativeList()
        {
            var initiativeList = new StringBuilder();
            foreach (var c in RoundOrder)
            {
                initiativeList.AppendLine($"{c.Initiative}: {c.Name}");
            }
            return initiativeList.ToString();
        }

        internal void StartRound(bool firstRound = false)
        {
            if (firstRound)
            {
                RoundNumber = 1;
                foreach (var c in AllCharacters) c.CurrentHp = c.MaxHp;
            }
            else
                RoundNumber++;

            foreach (var c in LivingCharacters) c.RollInitiative();
            RoundOrder = new Stack<Character>(LivingCharacters);
        }

        internal string TeamRoster(int team = 1)
        {
            var roster = new StringBuilder();
            foreach (var c in team == 1 ? Team1 : Team2)
            {
                roster.AppendLine($"{c}");
            }
            return roster.ToString();
        }

        internal void SaveGameStateToFile()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            File.WriteAllText("C:\\wargamestate.json", json);
        }
    }
}
