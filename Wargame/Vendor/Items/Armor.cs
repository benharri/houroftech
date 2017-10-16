using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargame
{
    class Armor : IItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ItemType { get; set; }
        public int Defense { get; set; }
        public int StrengthModifer { get; set; }


        public Armor(int id, string name, int defense, int strengthmodifier, int price, string itemtype)
        {
            ID = id;
            Name = name;
            Price = price;
            ItemType = itemtype;
            Defense = defense;
            StrengthModifer = strengthmodifier;
        }
    }
}