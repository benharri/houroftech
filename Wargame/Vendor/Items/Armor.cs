using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargame
{
    class Armor : Item
    {
        public int Defense { get; set; }
        public int StrengthModifer { get; set; }


        public Armor(int id, string name, int defense, int strengthmodifier, int price, string itemtype) : base(id, name, price, itemtype)
        {
            Defense = defense;
            StrengthModifer = strengthmodifier;
        }
    }
}