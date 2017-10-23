using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Wargame.Vendor;
using Wargame.Vendor.Items;

namespace Wargame.Characters
{
    class CharacterInventory
    {
        public BindingList<Item> Inventory;
        public BindingList<Item> Equipped;
        public BindingList<Item> All => new BindingList<Item>(Inventory.Concat(Equipped).ToList());

        public IEnumerable<Item> Weapons => Equipped.Where(i => i is Weapon);
        public IEnumerable<Item> Armor => Equipped.Where(i => i is Armor);

        public int DefenseBonus => Armor.Sum(i => ((Armor) i).Defense);

        public CharacterInventory()
        {
            Inventory = new BindingList<Item>();
            Equipped = new BindingList<Item>();
        }

        public void Equip(Item item)
        {
            if (!Inventory.Contains(item))
            {
                MessageBox.Show($"player doesn't have {item}");
                return;
            }
            Inventory.Remove(item);
            Equipped.Add(item);
        }

        public void Unequip(Item item)
        {
            if (!Equipped.Contains(item))
            {
                MessageBox.Show($"{item} not equipped.");
                return;
            }
            Equipped.Remove(item);
            Inventory.Add(item);
        }
    }
}
