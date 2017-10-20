using System.Collections.Generic;
using System.ComponentModel;
using Wargame.Characters.Classes;
using Wargame.Core;

namespace Wargame
{
    class GameFactory
    {
        public GameData CreateNewGame()
        {
            return new GameData()
            {
                AvailableCharacters = new BindingList<Character>
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
                    new Mage("Josh"),
                    new Thief("Dave"),
                    new Assassin("Ezio"),
                    new Barbarian("Fred"),
                    new Bard("Dandelion"),
                    new Druid("Ermion"),
                    new Hunter("Ragnar"),
                    new Mage("Keira Metz"),
                    new Priest("John Paul"),
                    new Soldier("Ves"),
                    new Thief("Bootblack"),
                },

                Vendor = new BindingList<Item>
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


