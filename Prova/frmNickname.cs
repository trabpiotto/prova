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
    public partial class frmNickname : Form
    {
        public frmNickname()
        {
            InitializeComponent();
        }

        frmMenuPrincipal menu = new frmMenuPrincipal();

        private void BtnComecar_Click(object sender, EventArgs e)
        {
            frmCarRacing carGame = new frmCarRacing();

            MessageBox.Show("Game: " + menu.game);

            /*
             * frmPingPong ping = new frmPingPong();
             * frmFuja fuja = new frmFuja();
             */

            //Colocar condigão para abrir o jogo que foi selecionado passando o nickname como parametro
        }
    }
}
