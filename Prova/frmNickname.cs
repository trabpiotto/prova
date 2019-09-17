﻿using System;
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
    public partial class frmNickname : Form
    {
        public static string nick;
        public frmNickname()
        {
            InitializeComponent();
        }

        

        public string recuperaNick() {
            return nick;
        }

        private void BtnComecar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            frmCarRacing carGame = new frmCarRacing();
            frmPong pong = new frmPong();
            
            nick = txtNick.Text;

            if (menu.recuperaGame() == 3) {
                carGame.ShowDialog();
            }
            if (menu.recuperaGame() == 2) {
                pong.ShowDialog();
            }
            if (menu.recuperaGame() == 1) {

            }
            this.Close();
        }
    }
}
