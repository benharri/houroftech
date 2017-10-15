using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargame
{
    public class Item
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Price { get; set; }
        public string ItemType { get; set; }

        public Item(int id, string name, int price, string itemtype)
        {
            ID = id;
            Name = name;
            Price = price;
            ItemType = itemtype;
        }
    }
}
