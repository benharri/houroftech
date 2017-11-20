using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargame.Vendor.Items
{
    class HealingPotion : Item
    {
        internal int HealingAmount;
        public HealingPotion(string name, int price = 20, int healingAmount = 2)
        {
            Name = name;
            Price = price;
            HealingAmount = healingAmount;

        }

        public override string ToString() => $"{Name}: [HealingAmount: {HealingAmount}]";
    }
}