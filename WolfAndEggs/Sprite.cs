using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WolfAndEggs
{
    class Sprite
    {
        public int X { get; }
        public int Y { get; }
        public Bitmap Picture { get; }
        public Sprite(int x, int y, Bitmap picture)
        {
            X = x;
            Y = y;
            Picture = picture;
        }
    }
}
