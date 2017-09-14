using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wargame
{
    class GridCell : PictureBox
    {
        public int GridX { get; set; }
        public int GridY { get; set; }
    }
}