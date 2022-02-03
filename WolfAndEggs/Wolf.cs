using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfAndEggs.Properties;
using System.Drawing;

namespace WolfAndEggs
{
    public class Wolf
    {
        private Sprite[] wolfSprite { get; } = new Sprite[4];
        private Sprite[] basketSprite { get; } = new Sprite[4];
        public int Pos_wolf { get; set; }
        public int Pos_basket { get; set; }
        public int Lives { get; set; }
        public int Score { get; set; }
        public Wolf()
        {
            Pos_wolf = 0;
            Pos_basket = 0;
            Lives = 3;
            Score = 0;
            wolfSprite[0] = new Sprite(177, 165, Resources.wolf_p_0);
            wolfSprite[1] = new Sprite(177, 165, Resources.wolf_p_0);
            wolfSprite[2] = new Sprite(297, 165, Resources.wolf_p_1);
            wolfSprite[3] = new Sprite(297, 165, Resources.wolf_p_1);
            basketSprite[0] = new Sprite(122, 235, Resources.basket_p_0_0);
            basketSprite[1] = new Sprite(125, 155, Resources.basket_p_0_1);
            basketSprite[3] = new Sprite(370, 165, Resources.basket_p_1_1);
            basketSprite[2] = new Sprite(360, 240, Resources.basket_p_1_0);
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(wolfSprite[Pos_wolf].Picture, wolfSprite[Pos_wolf].X, wolfSprite[Pos_wolf].Y);
            g.DrawImage(basketSprite[Pos_basket].Picture, basketSprite[Pos_basket].X, basketSprite[Pos_basket].Y);
        }
        public void DrawLives(Graphics g)
        {
            switch (Lives)
            {
                case 2:
                    g.DrawImage(Resources._1chicken, 325, 115);
                    break;
                case 1:
                    g.DrawImage(Resources._2lives, 325, 115);
                    break;
                case 0:
                    g.DrawImage(Resources.loss, 325, 115);
                    break;
            }
        }
        public void Move(int pos_wolf,int pos_basket)
        {
            Pos_wolf = pos_wolf;
            Pos_basket = pos_basket;
        }
    }
}
