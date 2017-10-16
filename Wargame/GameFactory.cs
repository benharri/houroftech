using System.Collections.Generic;

namespace Wargame
{
    class GameFactory
    {
        public GameData CreateNewGame()
        {
            var data = new GameData();

            data.Team1 = new List<Character>
            {
                new Character("Geralt"),
                new Character("Ciri"),
                new Character("Vesemir"),
                new Character("Lambert"),
                new Character("Eskel"),
            };

            data.Team2 = new List<Character>
            {
                new Character("Eredin"),
                new Character("Imlerith"),
                new Character("Caranthir"),
                new Character("Ge'els"),
                new Character("Avallac'h"),
            };

            data.Vendor = new List<Item>
            {
                //Weapon designer
                new Weapon(1, "Sword", 1, 4, 4, "Weapon"),
                new Weapon(2, "Rolling Pin", 0, 1, 1, "Weapon"),
                //Armor designer
                new Armor(3, "Light Armor", 2, 3, 3, "Armor"),
                new Armor(4, "Heavy Armor", 4, 3, 4, "Armor"),
            };

            return data;
        }
    }
}
