using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolfAndEggs.Properties;
using System.IO;


namespace WolfAndEggs
{
    public partial class Form1 : Form
    {
        public Wolf wolf = new Wolf();
        public List<Egg> eggs = new List<Egg>();
        public bool answer = false;
        public bool loss = false;
        public bool win = false;
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }
        public void RestartGane()
        {
            timer1.Stop();
            wolf = new Wolf();
            eggs = new List<Egg>();
            Egg.Delay = 0;
            Egg.MaxDelay = 5;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (answer == true)
            {
                foreach (Egg egg in eggs)
                {
                    egg.Draw(e.Graphics);
                }
                wolf.Draw(e.Graphics);
                wolf.DrawLives(e.Graphics);
                e.Graphics.DrawString(wolf.Score.ToString(), new Font("digital-7", 72), Brushes.Black, 315, 25);
            }
            else if (win == true)
            {
                pictureBox1.Image = Resources.WinBG;
                pictureBox1.Invalidate();
            }
            else if (loss == true)
            {
                pictureBox1.Image = Resources.LossBG;
                pictureBox1.Invalidate();
            }
            else if (answer == false)
            {
                pictureBox1.Image = Resources.StartBG;
                pictureBox1.Invalidate();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    wolf.Move(0, 0);
                    break;
                case Keys.Q:
                    wolf.Move(1, 1);
                    break;
                case Keys.E:
                    wolf.Move(3, 3);
                    break;
                case Keys.D:
                    wolf.Move(2, 2);
                    break;
                case Keys.Enter:
                    if (answer == false)
                    {
                        pictureBox1.Image = Resources.game_bg;
                        timer1.Start();
                        loss = false;
                        win = false;
                        answer = true;
                    }
                    break;
            }
            pictureBox1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Egg> temp = new List<Egg>();
            Egg.Delay++;
            if(Egg.Delay >= Egg.MaxDelay)
            {
                eggs.Add(new Egg());
                Egg.Delay = 0;
            }
            if (wolf.Lives==0)
            {
                loss = true;
                answer = false;
                RestartGane();
            }
            foreach (Egg egg in eggs)
            {
                if (egg.Step == 5)
                {
                    wolf.Lives--;
                }
                else if (egg.Step == 9)
                    continue;
                if ((egg.RailNum == wolf.Pos_wolf && egg.RailNum == wolf.Pos_basket) && egg.Step == 4)
                {
                    wolf.Score++;
                    if (wolf.Score >= 1000)
                    {
                        win = true;
                        answer = false;
                        RestartGane();
                    }
                    if (wolf.Score % 50 == 0 && Egg.Delay < Egg.MaxDelay)
                    {
                        Egg.MaxDelay--;
                    }
                    continue;
                }
                egg.Step++;
                temp.Add(egg);
            }
            eggs = temp;
            pictureBox1.Invalidate();
        }
    }
}
