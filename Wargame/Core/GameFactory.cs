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
                },
            };

        }
    }
}
