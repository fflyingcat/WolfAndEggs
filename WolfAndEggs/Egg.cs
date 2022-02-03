using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfAndEggs.Properties;
using System.Drawing;

namespace WolfAndEggs
{
    public class Egg
    {
        private static Sprite[,] Rails { get; set; } = new Sprite[4, 10];
        private static Random rnd { get; } = new Random();
        public static int MaxDelay = 5;
        public static int Delay = MaxDelay;
        public int RailNum { get; }
        public int Step { get; set; } = 0;//Шаг яйца
        static Egg()
        {
            //Левая нижняя лестница
            Rails[0, 0] = new Sprite(47 ,192, Resources.egg0_0);
            Rails[0, 1] = new Sprite(59, 202, Resources.egg0_1);
            Rails[0, 2] = new Sprite(77, 212, Resources.egg0_2);
            Rails[0, 3] = new Sprite(94, 222, Resources.egg0_3);
            Rails[0, 4] = new Sprite(108, 232, Resources.egg0_4);
            Rails[0, 5] = new Sprite(97, 305, Resources.egg_left0);
            Rails[0, 6] = new Sprite(85, 279, Resources.egg_left1);
            Rails[0, 7] = new Sprite(62, 295, Resources.egg_left2);
            Rails[0, 8] = new Sprite(33, 298, Resources.egg_left3);
            Rails[0, 9] = new Sprite(12, 298, Resources.egg_left4);
            //Левая верхняя лестница
            Rails[1, 0] = new Sprite(47, 122, Resources.egg1_0);
            Rails[1, 1] = new Sprite(59, 132, Resources.egg1_1);
            Rails[1, 2] = new Sprite(77, 142, Resources.egg1_2);
            Rails[1, 3] = new Sprite(94, 152, Resources.egg1_3);
            Rails[1, 4] = new Sprite(109, 158, Resources.egg1_4);
            Rails[1, 5] = new Sprite(97, 305, Resources.egg_left0);
            Rails[1, 6] = new Sprite(85, 279, Resources.egg_left1);
            Rails[1, 7] = new Sprite(62, 295, Resources.egg_left2);
            Rails[1, 8] = new Sprite(33, 298, Resources.egg_left3);
            Rails[1, 9] = new Sprite(12, 298, Resources.egg_left4);
            //Правая нижняя лестница
            Rails[2, 0] = new Sprite(508, 195, Resources.egg2_0);
            Rails[2, 1] = new Sprite(490, 205, Resources.egg2_1);
            Rails[2, 2] = new Sprite(470, 212, Resources.egg2_2);
            Rails[2, 3] = new Sprite(454, 222, Resources.egg2_3);
            Rails[2, 4] = new Sprite(441, 234, Resources.egg2_4);
            Rails[2, 5] = new Sprite(403, 307, Resources.egg_right0);
            Rails[2, 6] = new Sprite(463, 280, Resources.egg_right1);
            Rails[2, 7] = new Sprite(486, 295, Resources.egg_right2);
            Rails[2, 8] = new Sprite(514, 298, Resources.egg_right3);
            Rails[2, 9] = new Sprite(544, 298, Resources.egg_right4);
            //Правая верхняя лестница
            Rails[3, 0] = new Sprite(507, 122, Resources.egg3_0);
            Rails[3, 1] = new Sprite(490, 132, Resources.egg3_1);
            Rails[3, 2] = new Sprite(470, 140, Resources.egg3_2);
            Rails[3, 3] = new Sprite(457, 149, Resources.egg3_3);
            Rails[3, 4] = new Sprite(441, 160, Resources.egg3_4);
            Rails[3, 5] = new Sprite(403, 307, Resources.egg_right0);
            Rails[3, 6] = new Sprite(463, 280, Resources.egg_right1);
            Rails[3, 7] = new Sprite(486, 295, Resources.egg_right2);
            Rails[3, 8] = new Sprite(514, 298, Resources.egg_right3);
            Rails[3, 9] = new Sprite(544, 298, Resources.egg_right4);
        }
        public Egg()
        {
            RailNum = rnd.Next(4);
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(Rails[RailNum, Step].Picture, Rails[RailNum, Step].X, Rails[RailNum, Step].Y);
        }
    }
}
