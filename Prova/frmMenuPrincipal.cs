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
    public partial class frmMenuPrincipal : Form
    {
        public int game = 0;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        public void recuperaGame()
        {
            if(btnCarRacing.Click == )
        }

        private void BtnCarRacing_Click(object sender, EventArgs e)
        {
            game = 3;
            frmNickname nick = new frmNickname();
            nick.ShowDialog();
                      
        }

        private void BtnPingPong_Click(object sender, EventArgs e)
        {
            game = 2;
        }

        private void BtnFuga_Click(object sender, EventArgs e)
        {
            game = 1;
        }
    }
}
