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

        public int DefenseBonus => Equipped.Where(i => i is Armor).Select(i => ((Armor) i).Defense).Sum();
        public DiceRoll[] AttackBonus => Equipped.Where(i => i is Weapon).Select(i => ((Weapon) i).Strength).ToArray();

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
