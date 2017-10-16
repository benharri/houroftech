using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargame
{
    public class Weapon : IItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ItemType { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, int minimumDamage, int maximumDamage, int price, string itemtype)
        {
            ID = id;
            Name = name;
            Price = price;
            ItemType = itemtype;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }

        public override string ToString()
        {
            return $"{Name}: [DMG: {MinimumDamage} - {MaximumDamage}] Price: {Price}";
        }
    }
}
