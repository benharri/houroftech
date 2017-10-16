using System.Collections.Generic;

namespace Wargame
{
    class CharacterInventory
    {
        public List<Item> inventory;
        public List<Item> equipped;

        public CharacterInventory()
        {
            inventory = new List<Item>();
            equipped = new List<Item>();
        }
    }
}
