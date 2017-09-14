using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargame
{
    class GameData
    {
        public int RoundNuber { get; set; }
        public Stack<Character> RoundOrder = new Stack<Character>();
        public List<Character> Team1 = new List<Character>();
        public List<Character> Team2 = new List<Character>();
    }
}