using System.Collections.Generic;
using Wargame.Characters.Classes;

namespace Wargame
{
    class GameFactory
    {
        public GameData CreateNewGame()
        {
            var data = new GameData();


            data.Team2 = new List<Character>
            {
            };

            data.AvailableCharacters = new List<Character>
            {
                new Character("Eredin"),
                new Character("Imlerith"),
                new Character("Caranthir"),
                new Character("Ge'els"),
                new Character("Avallac'h"),
                new Character("Geralt"),
                new Character("Ciri"),
                new Character("Vesemir"),
                new Character("Lambert"),
                new Character("Eskel"),
            };


            data.Vendor = new List<Item>
                {
                    //Weapon designer
                    new Weapon("Sword")
                    {
                        Price = 5,
                        Strength = new DiceRoll(sides: 8),
                    },
                    new Weapon("Rolling Pin")
                    {
                        Price = 1,
                        Strength = new DiceRoll(sides: 1),
                    },

                    //Armor designer
                    new Armor("Light Armor")
                    {
                        Price = 3,
                    },
                    new Armor("Heavy Armor")
                    {
                        Price = 10,
                        Defense = 10,
                        StrengthModifer = -2,
                    },
                };
            return data;

    }
    }
}


