using System.Collections.Generic;
using Wargame.Characters.Classes;

namespace Wargame
{
    class GameFactory
    {
        public GameData CreateNewGame()
        {
            return new GameData()
            {
                Team1 = new List<Character>
                {
                    new Witcher("Geralt"),
                    new Mage("Triss"),
                    new Priest("Ermion"),
                    new Thief("Dudu"),
                    new Soldier("Vernon"),
                },

                Team2 = new List<Character>
                {
                    new Soldier("Eredin"),
                    new Mage("Imlerith"),
                    new Priest("Caranthir"),
                    new Thief("Ge'els"),
                    new Witcher("Lambert"),
                },

                Vendor = new List<Item>
                {
                    //Weapon designer
                    new Weapon(1, "Sword", 1, 4, 4),
                    new Weapon(2, "Rolling Pin", 0, 1, 1),
                    //Armor designer
                    new Armor(3, "Light Armor", 2, 3, 3),
                    new Armor(4, "Heavy Armor", 4, 3, 4),
                },
            };

        }
    }
}
