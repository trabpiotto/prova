using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class frmCarRacing : Form
    {
        int gamespeed = 0;

        public frmCarRacing()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            moveLine(5);
            enemy(2);
        }

        void enemy(int speed)
        {
            Random rnd = new Random();
            int rand = rnd.Next(3, 7);
            int rand2 = rnd.Next(15, 360);

            if (enemy1.Top >= 500)
            {
                enemy1.Top = 0;
                enemy1.Left = rand2;
            }
            else
            {
                enemy1.Top += rand + 2;
            }

            if (enemy2.Top >= 500)
            {
                enemy2.Top = 0;
                enemy2.Left = rand2;
            }
            else
            {
                enemy2.Top += rand;
            }

            if (enemy3.Top >= 500)
            {
                enemy3.Top = 0;
                enemy3.Left = rand2;
            }
            else
            {
                enemy3.Top += rand + 1;
            }
        }

        void moveLine(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }

        private void FrmCarRacing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {

                if (car.Left > 20)
                {
                    car.Left += -10;
                }

            }

            if (e.KeyCode == Keys.D)
            {
                if (car.Right < 370)
                {
                    car.Left += 10;
                }

            }

            /*if(e.KeyCode == Keys.Up)
            {
                if(gamespeed < 21)
                {
                    gamespeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 5)
                {
                    gamespeed--;
                }
            }*/
        }
    }
}
