using System.Collections.Generic;
using System.ComponentModel;

namespace Wargame
{
    class CharacterInventory
    {
        public BindingList<Item> inventory;
        public BindingList<Item> equipped;

        public CharacterInventory()
        {
            inventory = new BindingList<Item>();
            equipped = new BindingList<Item>();
        }
    }
}
