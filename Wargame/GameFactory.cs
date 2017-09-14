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
            data.Team2.Add(cf.GetCharacter("Imlerith"));
            return data;
        }
    }
}
