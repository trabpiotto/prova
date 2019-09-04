using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            tm.Interval = 500;
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
        }
        Timer tm = new Timer();
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            int velocidade=9;

            if (e.KeyCode == Keys.Right) {
                if (x >= (panel1.Width - pictureBox1.Width))
                {
                    x += 0;
                }
                else
                {
                    x += velocidade;
                }

            }
            else if (e.KeyCode == Keys.Left) {
                if(x <= 0)
                {
                    x -= 0;
                }
                else
                {
                    x -= velocidade;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (y <= 0)
                {
                    y -= 0;
                }
                else
                {
                    y -= velocidade;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (y >= (panel1.Height - pictureBox1.Height))
                {
                    y += 0;
                }
                else
                {
                    y += velocidade;
                }
            }

            pictureBox1.Location = new Point(x, y);
        }
        int X = 0;
        int Y = 0;
        bool topo, esquerda;
        void tm_Tick(object sender, EventArgs e)
        {
            int x = pictureBox2.Location.X;
            int y = pictureBox2.Location.Y;
            bool irParaEsquerda, irParaDireita, descer, subir;

            X = ((int)(new Random().Next(-40 , -1)));
            Y = ((int)(new Random().Next(-40, 40)));

            if (x <= 0)
            {
                irParaEsquerda = false;
                irParaDireita = true;
                X = ((int)(new Random().Next(40)));
            }
            if(x >= panel1.Width)
            {
                irParaDireita = false;
                irParaEsquerda = true;
                X = ((int)(new Random().Next(-1, -40)));
            }
            if (y <= 0)
            {
                subir = false;
                descer = true;
                Y = ((int)(new Random().Next(1, 40)));
            }
            if (y >= panel1.Height)
            {
                descer = false;
                subir = true;
                Y = ((int)(new Random().Next(-1, -40)));
            }
            
















            
            pictureBox2.Location = new Point(X, Y);
        }
    }
}
