using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargame.Characters.Classes
{
    class Soldier : Character
    {
        public Soldier(string name, int maxHP = 20) : base(name, maxHP)
        {
        }
    }
}
