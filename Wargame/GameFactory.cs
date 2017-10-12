using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargame
{
    class GameFactory
    {
        public GameData CreateNewGame()
        {
            var data = new GameData();
            var cf = new CharacterFactory();
            data.Team1.Add(cf.GetCharacter("Geralt"));
            data.Team1.Add(cf.GetCharacter("Magnus Faulkenheim"));
            data.Team2.Add(cf.GetCharacter("Imlerith"));
            data.Team2.Add(cf.GetCharacter("Sir Lancealot"));
            return data;
        }
    }
}
