using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargame
{
    class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description => ToString();

        public override string ToString() => $"{Name} {GetType().Name} {Price}";
    }
}
