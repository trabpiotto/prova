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
        }


        void moveLine(int speed)
        {
            if(pictureBox1.Top >= 500)
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
                if(gamespeed != 0)
                {
                    if (car.Left > 20)
                    {
                        car.Left += -10;
                    }
                }
            }

            if (e.KeyCode == Keys.D)
            {
                if (gamespeed != 0)
                {
                    if (car.Right < 370)
                    {
                        car.Left += 10;
                    }
                }
            }

            if(e.KeyCode == Keys.Up)
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
            }
        }
    }
}
