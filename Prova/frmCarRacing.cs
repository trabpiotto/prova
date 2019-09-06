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
        static int vel = 5;
        int gamespeed = vel;
        int scoreCollected = 0;        
        bool pause = true;
        public frmCarRacing()
        {
            InitializeComponent();
            gameOver.Visible = false;
            lblPause.Visible = true;
            btnReiniciar.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gamespeed);
            score(gamespeed);
            enemy(2);
            fimJogo();
            pausar(pause);
            //scoreGame();
        }

        void pausar(bool pause)
        {
            this.pause = pause;

            if (pause == true)
            {
                gamespeed = 0;
                lblPause.Visible = true;
            }
            else
            {
                gamespeed = vel;
                lblPause.Visible = false;
            }
        }
        void enemy(int speed)
        {
            Random rnd = new Random();
            int rand = rnd.Next(3, 7);
            int rand2 = rnd.Next(25, 350);

            if (gamespeed != 0)
            {
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
        }

        void score(int speed)
        {
            if (point1.Top >= 500)
            {
                point1.Top = 0;

                scoreCollected++;
                lblScore.Text = "Score: " + scoreCollected.ToString();
            }
            else
            {
                point1.Top += speed;
            }

            if (point2.Top >= 500)
            {
                point2.Top = 0;

                scoreCollected++;
                lblScore.Text = "Score: " + scoreCollected.ToString();
            }
            else
            {
                point2.Top += speed;
            }
        }

        bool fimJogo()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds) || car.Bounds.IntersectsWith(enemy2.Bounds) || car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                gameOver.Visible = true;
                btnReiniciar.Visible = true;
                return true;
            }        
            return false;
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
            if (fimJogo())
            {
                gamespeed = 0;
            }

            if (e.KeyCode == Keys.A && gamespeed != 0)
            {

                if (car.Left > 20)
                {
                    car.Left += -10;
                }
            }
            
            if (e.KeyCode == Keys.D && gamespeed != 0)
            {
                if (car.Right < 370)
                {
                    car.Left += 10;
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if(pause == true)
                {
                    pause = false;
                }
                else
                {
                    pause = true;
                }
            }
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
