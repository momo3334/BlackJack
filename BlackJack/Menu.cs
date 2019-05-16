using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Menu : Form
    {
        BlackJack m_blackJack;
        public Menu(BlackJack blackJack)
        {
            InitializeComponent();
            this.m_blackJack = blackJack;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            btnOnline.Visible = false;
            btnReglage.Visible = false;
            btnLocal.Visible = false;

            lblAddPlayer.Visible = true;
            UDnbHotseatPlayer.Visible = true;
            lblAddPlayer.Visible = true;
            lblPlayer1.Visible = true;
            txbPlayer0.Visible = true;
            chbBot1.Visible = true;

            btnStartLocal.Visible = true;
            //m_blackJack.newGame();
        }

        private void UDnbHotseatPlayer_ValueChanged(object sender, EventArgs e)
        {
            switch (UDnbHotseatPlayer.Value)
            {
                case 1:
                    lblPlayer1.Visible = true;
                    txbPlayer0.Visible = true;

                    lblPlayer2.Visible = false;
                    txbPlayer1.Visible = false;

                    chbBot1.Visible = true;
                    chbBot2.Visible = false;
                    break;
                case 2:

                    lblPlayer2.Visible = true;
                    txbPlayer1.Visible = true;

                    lblPlayer3.Visible = false;
                    txbPlayer2.Visible = false;

                    chbBot2.Visible = true;
                    chbBot3.Visible = false;
                    break;
                case 3:
                    lblPlayer3.Visible = true;
                    txbPlayer2.Visible = true;

                    lblPlayer4.Visible = false;
                    txbPlayer3.Visible = false;

                    chbBot3.Visible = true;
                    chbBot4.Visible = false;
                    break;
                case 4:
                    lblPlayer4.Visible = true;
                    txbPlayer3.Visible = true;

                    lblPlayer5.Visible = false;
                    txbPlayer4.Visible = false;

                    chbBot4.Visible = true;
                    chbBot5.Visible = false;
                    break;
                case 5:
                    lblPlayer5.Visible = true;
                    txbPlayer4.Visible = true;
                    chbBot5.Visible = true;
                    break;
                default:
                    break;
            }

        }

        private void btnStartLocal_Click(object sender, EventArgs e)
        {
            m_blackJack.newGame(Convert.ToInt32(UDnbHotseatPlayer.Value) - countBot(), countBot());
        }

        private int countBot()
        {
            int botCount = 0;

            if (chbBot1.Checked)
            {
                botCount++;
            }
            if (chbBot2.Checked)
            {
                botCount++;
            }
            if (chbBot3.Checked)
            {
                botCount++;
            }
            if (chbBot4.Checked)
            {
                botCount++;
            }
            if (chbBot5.Checked)
            {
                botCount++;
            }
            return botCount;
        }
    }
}
