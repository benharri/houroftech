using System.Collections.Generic;
using System.ComponentModel;
using Wargame.Characters.Classes;

namespace Wargame
{
    class GameFactory
    {
        public GameData CreateNewGame()
        {
            var data = new GameData();


            //data.Team2 = new List<Character>
            //{
            //};

            data.AvailableCharacters = new BindingList<Character>
            {
                new Mage("Eredin"),
                new Priest("Imlerith"),
                new Soldier("Caranthir"),
                new Thief("Ge'els"),
                new Mage("Avallac'h"),
                new Witcher("Geralt"),
                new Thief("Ciri"),
                new Soldier("Vesemir"),
                new Witcher("Lambert"),
                new Witcher("Eskel"),
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


