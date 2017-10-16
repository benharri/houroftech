using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargame
{
    interface IItem
    {
        string Name { get; set; }
        int ID { get; set; }
        int Price { get; set; }
        string ItemType { get; set; }
    }
}
