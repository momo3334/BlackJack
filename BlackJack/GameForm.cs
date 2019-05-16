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
    public partial class GameForm : Form
    {
        Game m_game;
        Timer m_slideCardTimer;


        public GameForm(Game game)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.m_game = game;
            this.m_slideCardTimer = new Timer();
            disableHitStandButton();
            
            
        }
        public void setNbPlayer(int nbPlayer)
        {
            //Setting highlight on current player label
            if (m_game.playerCount() == 1)
            {
                lblPlayer0.BackColor = Color.DodgerBlue;
            }
            else if (m_game.playerCount() == 2)
            {
                lblPlayer2.BackColor = Color.DodgerBlue;
            }
            else
            {
                lblPlayer1.BackColor = Color.DodgerBlue;
            }

            localHand0.Visible = true;
            if (nbPlayer >= 2)
            {
                localHand2.Visible = true;
                if (nbPlayer >= 3)
                {
                    localHand1.Visible = true;
                    if (nbPlayer >= 4)
                    {
                        localHand3.Visible = true;
                        if (nbPlayer >= 5)
                        {
                            localHand4.Visible = true;
                        }
                    }
                }
            }

        }

        public void testimer(Object myObject, EventArgs myEventArgs) {

        }
        public void refreshHand()
        {
            int playerId;
            int dealerId;
            dealerId = m_game.getDealerId();
            if (m_game.getDealer(dealerId) != null && m_game.getDealerRefresh(dealerId))
            {
                List<Card> playerCard = m_game.getDealer(dealerId).getHand();
                
                for (int i = 0; i < playerCard.Count; i++)
                {
                    Card card = playerCard[i];

                    if (i == 0)
                    {
                            dealerHand0.Image = Image.FromFile(@"..\..\Resources\" + "cardbackblue" + ".png");
                    }
                    else if (i == playerCard.Count - 1)
                    {
                        this.Controls.Add(new PictureBox { Name = "dealerHand" + i, Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png"), Location = new Point(514 + (i * 20), 96), Size = dealerHand0.Size, BackgroundImage = Image.FromFile(@"..\..\Resources\backGroundCards.png"), BackgroundImageLayout = ImageLayout.Stretch, SizeMode = dealerHand0.SizeMode, BackColor = Color.Transparent });
                        this.Controls[this.Controls.Count - 1].BringToFront();
                    }
                }
                //lblDealerHandValue.Text = m_game.dealerHandValue().ToString();
                //FileStream fs = new System.IO.FileStream(@"Images\a.bmp", FileMode.Open, FileAccess.Read);
                //pictureBox1.Image = Image.FromStream(fs);
                //fs.Close();
                m_game.setDealerRefresh(false);
            }
            if (m_game.playerCount() + m_game.botCount() >= 1)
            {
                if (m_game.playerCount() == 1)
                {
                    playerId = 0;
                }
                else if (m_game.playerCount() == 2)
                {
                    playerId = 1;
                }
                else
                {
                    playerId = 2;
                }
                
                if (m_game.getPlayerRefresh(playerId))
                {
                    //si le player id est plus grand ou = a la grosseur de liste de player then vas chercher la hand du bot a l'index (playerLenght - playerId)
                    List<Card> playerCard;
                    playerCard = m_game[playerId].getHand();

                    for (int i = 0; i < playerCard.Count; i++)
                    {
                        Card card = playerCard[i];
                        if (i == 0)
                        {
                            localHand0.Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png");// x : 440 y : 386

                        }
                        else if (i == playerCard.Count - 1)
                        {
                            this.Controls.Add(new PictureBox { Name = "localHand0" + i, Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png"), Location = new Point(514 + (i * 20), 441), Size = dealerHand0.Size, BackgroundImage = Image.FromFile(@"..\..\Resources\backGroundCards.png"), BackgroundImageLayout = ImageLayout.Stretch, SizeMode = dealerHand0.SizeMode, BackColor = Color.Transparent });
                            this.Controls[this.Controls.Count - 1].BringToFront();
                        }
                    }
                    m_game.setPlayerRefresh(playerId, false);
                }
                lblHandValue0.Text = m_game.playerHandValue(playerId).ToString();
            }
            if (m_game.playerCount() + m_game.botCount() >= 2)
            {
                if (m_game.playerCount() == 2)
                {
                    playerId = 0;
                }
                else
                {
                    playerId = 1;
                }
                if (m_game.getPlayerRefresh(playerId))
                {
                    List<Card> playerCard;
                    playerCard = m_game[playerId].getHand();

                    for (int i = 0; i < playerCard.Count; i++)
                    {
                        Card card = playerCard[i];
                        if (i == 0)
                        {
                            localHand2.Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png");
                        }
                        else if (i == playerCard.Count - 1)
                        {
                            this.Controls.Add(new PictureBox { Name = "localHand2" + i, Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png"), Location = new Point(767 + (i * 20), 419), Size = dealerHand0.Size, BackgroundImage = Image.FromFile(@"..\..\Resources\backGroundCards.png"), BackgroundImageLayout = ImageLayout.Stretch, SizeMode = dealerHand0.SizeMode, BackColor = Color.Transparent });
                            this.Controls[this.Controls.Count - 1].BringToFront();
                        }
                    }
                    m_game.setPlayerRefresh(playerId, false);
                }
                lblHandValue2.Text = m_game.playerHandValue(playerId).ToString();
            }
            if (m_game.playerCount() + m_game.botCount() >= 3)
            {


                if (m_game.getPlayerRefresh(0))
                {
                    List<Card> playerCard = m_game[0].getHand();

                    for (int i = 0; i < playerCard.Count; i++)
                    {
                        Card card = playerCard[i];
                        if (i == 0)
                        {
                            localHand1.Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png");
                        }
                        else if (i == playerCard.Count - 1)
                        {
                            this.Controls.Add(new PictureBox { Name = "localHand1" + i, Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png"), Location = new Point(973 + (i * 20), 344), Size = dealerHand0.Size, BackgroundImage = Image.FromFile(@"..\..\Resources\backGroundCards.png"), BackgroundImageLayout = ImageLayout.Stretch, SizeMode = dealerHand0.SizeMode, BackColor = Color.Transparent });
                            this.Controls[this.Controls.Count - 1].BringToFront();
                        }
                    }
                    m_game.setPlayerRefresh(0, false);
                }
                lblHandValue1.Text = m_game.playerHandValue(0).ToString();
            }
            if (m_game.playerCount() + m_game.botCount() >= 4)
            {
                if (m_game.getPlayerRefresh(3))
                {
                    List<Card> playerCard = m_game[3].getHand();

                    for (int i = 0; i < playerCard.Count; i++)
                    {
                        Card card = playerCard[i];
                        if (i == 0)
                        {
                            localHand3.Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png");
                        }
                        else if (i == playerCard.Count - 1)
                        {
                            this.Controls.Add(new PictureBox { Name = "localHand1" + i, Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png"), Location = new Point(252 + (i * 20), 419), Size = dealerHand0.Size, BackgroundImage = Image.FromFile(@"..\..\Resources\backGroundCards.png"), BackgroundImageLayout = ImageLayout.Stretch, SizeMode = dealerHand0.SizeMode, BackColor = Color.Transparent });
                            this.Controls[this.Controls.Count - 1].BringToFront();
                        }
                    }
                    m_game.setPlayerRefresh(3, false);
                }
                lblHandValue3.Text = m_game.playerHandValue(3).ToString();
            }
            if (m_game.playerCount() + m_game.botCount() >= 5)
            {
                if (m_game.getPlayerRefresh(4))
                {
                    List<Card> playerCard = m_game[4].getHand();

                    for (int i = 0; i < playerCard.Count; i++)
                    {
                        Card card = playerCard[i];
                        if (i == 0)
                        {
                            localHand4.Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png");
                        }
                        else if (i == playerCard.Count - 1)
                        {
                            this.Controls.Add(new PictureBox { Name = "localHand3" + i, Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png"), Location = new Point(41 + (i * 20), 344), Size = dealerHand0.Size, BackgroundImage = Image.FromFile(@"..\..\Resources\backGroundCards.png"), BackgroundImageLayout = ImageLayout.Stretch, SizeMode = dealerHand0.SizeMode, BackColor = Color.Transparent });
                            this.Controls[this.Controls.Count - 1].BringToFront();
                        }
                    }
                    m_game.setPlayerRefresh(4,false);
                }
                lblHandValue4.Text = m_game.playerHandValue(4).ToString();
            }
            this.Refresh();
        }

        public void setPlayerInfo(string playerName, int playerStack) {
            lblCurrentPlayerName.Text = playerName;
            lblCurrentPlayerStack.Text = playerStack.ToString();
        }

        public void betTurn(string playerName)
        {
            if (m_game.BetTurn)
            {
                lblBetTurn.Text = "Au tour du joueur: " + playerName + " de miser"; //// stu correct?
            }
            else
            {
                lblBetTurn.Text = "Au tour du joueur: " + playerName + " de jouer";
            }
           
        }
        public void setInfoLblString(string toShow) {
            lblBetTurn.Text = toShow;
            this.Refresh();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            m_game.giveCard(m_game[m_game.Turn]);// falloir le sortir de la UML
            refreshHand();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            m_game.switchTurns();
        }

        public void setPlayerName() {
            if (m_game.playerCount() == 1)
            {
                                                            //m_game[0].Name
                lblPlayer0.Text = m_game.getPlayerName(0); // demander a charles si c'est correct de faire ca
            }
            else if (m_game.playerCount() == 2)
            {
                lblPlayer0.Text = m_game.getPlayerName(1);
                lblPlayer2.Text = m_game.getPlayerName(0);
            }

            else if (m_game.playerCount() >= 3)
            {
                lblPlayer0.Text = m_game.getPlayerName(2);
                lblPlayer1.Text = m_game.getPlayerName(0);
                lblPlayer2.Text = m_game.getPlayerName(1);
                if (m_game.playerCount() >= 4)
                {
                    lblPlayer3.Text = m_game.getPlayerName(3);
                }
                if (m_game.playerCount() == 5)
                {
                    lblPlayer4.Text = m_game.getPlayerName(4);
                }
            }
        }
        public void setPlayerBet(int turn, int betting) {
            btnConfirmBet.Visible = true;
            btnConfirmBet.Enabled = true;
            if (m_game.playerCount() == 1)
            {
                lblBet0.Text = (Convert.ToInt32(lblBet0.Text) + betting).ToString(); 
            }
            else if (m_game.playerCount() == 2)
            {
                switch (turn)
                {
                    case 0:
                        lblBet2.Text = (Convert.ToInt32(lblBet2.Text) + betting).ToString();
                        break;
                    case 1:
                        lblBet0.Text = (Convert.ToInt32(lblBet0.Text) + betting).ToString();
                        break;
                    default:
                        break;
                }
            }

            else if (m_game.playerCount() >= 3)
            {
                switch (turn)
                {
                    case 0:
               
                        lblBet1.Text = (Convert.ToInt32(lblBet1.Text) + betting).ToString();
                        break;
                    case 1:
                        lblBet2.Text = (Convert.ToInt32(lblBet2.Text) + betting).ToString();
                        break;
                    case 2:
                        lblBet0.Text = (Convert.ToInt32(lblBet0.Text) + betting).ToString();
                        break;
                    case 3:
                        lblBet3.Text = (Convert.ToInt32(lblBet3.Text) + betting).ToString();
                        break;
                    case 4:
                        lblBet4.Text = (Convert.ToInt32(lblBet4.Text) + betting).ToString();
                        break;
                    default:
                        break;
                }
                
            }
        }
        public void colorLabel(int id)
        {
            switch (id)
            {
                case 0:
                    lblPlayer0.BackColor = Color.DodgerBlue;
                    break;
                case 1:
                    lblPlayer1.BackColor = Color.DodgerBlue;
                    break;
                case 2:
                    lblPlayer2.BackColor = Color.DodgerBlue;
                    break;
                case 3:
                    lblPlayer3.BackColor = Color.DodgerBlue;
                    break;
                case 4:
                    lblPlayer4.BackColor = Color.DodgerBlue;
                    break;
                default:
                    break;
            }
        }

        public void uncolorLabel(int id)
        {
            switch (id)
            {
                case 0:
                    lblPlayer0.BackColor = Color.Transparent;
                    break;
                case 1:
                    lblPlayer1.BackColor = Color.Transparent;
                    break;
                case 2:
                    lblPlayer2.BackColor = Color.Transparent;
                    break;
                case 3:
                    lblPlayer3.BackColor = Color.Transparent;
                    break;
                case 4:
                    lblPlayer4.BackColor = Color.Transparent;
                    break;
                default:
                    break;
            }
        }

        public void reset() {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (this.Controls[0].Name.StartsWith("dealerHand") || this.Controls[0].Name.StartsWith("localHand"))
                {
                    if (this.Controls[0].Name != "dealerHand0" && this.Controls[0].Name != "localHand0")
                    {
                        Controls.Remove(this.Controls[0]);
                    }
                }
            }

            

        }
        private void btnBet1_MouseDown(object sender, MouseEventArgs e)
        {
            bool possible;
            btnBet1.BackgroundImage = Properties.Resources.whiteBet1Pressed;
            possible = m_game.setPlayerToken(m_game.Turn, 1);
            if (possible)
            {
                setPlayerBet(m_game.Turn, 1);
                m_game.setPlayerBet(m_game.Turn, 1);
            }

            lblCurrentPlayerStack.Text = m_game.getPlayerToken(m_game.Turn).ToString();
        }

        private void btnBet1_MouseUp(object sender, MouseEventArgs e)
        {
            btnBet1.BackgroundImage = Properties.Resources.whiteBet1;
        }

        private void btnBet10_MouseDown(object sender, MouseEventArgs e)
        {
            bool possible;
            btnBet10.BackgroundImage = Properties.Resources.redBet10Pressed;
            possible = m_game.setPlayerToken(m_game.Turn, 10);
            if (possible)
            {
                setPlayerBet(m_game.Turn, 10);
                m_game.setPlayerBet(m_game.Turn, 10);
            }

            lblCurrentPlayerStack.Text = m_game.getPlayerToken(m_game.Turn).ToString();
        }

        private void btnBet10_MouseUp(object sender, MouseEventArgs e)
        {
            btnBet10.BackgroundImage = Properties.Resources.redBet10;
        }

        private void btnBet50_MouseDown(object sender, MouseEventArgs e)
        {
            bool possible;
            btnBet50.BackgroundImage = Properties.Resources.greenBet50Pressed;
            possible = m_game.setPlayerToken(m_game.Turn, 50);
            if (possible)
            {
                setPlayerBet(m_game.Turn, 50);
                m_game.setPlayerBet(m_game.Turn, 50);
            }

            lblCurrentPlayerStack.Text = m_game.getPlayerToken(m_game.Turn).ToString();
        }

        private void btnBet50_MouseUp(object sender, MouseEventArgs e)
        {
            btnBet50.BackgroundImage = Properties.Resources.greenBet50;
        }

        private void btnBet100_MouseDown(object sender, MouseEventArgs e)
        {
            bool possible;
            btnBet100.BackgroundImage = Properties.Resources.blackBet100Pressed;
            possible = m_game.setPlayerToken(m_game.Turn, 100);
            if (possible)
            {
                setPlayerBet(m_game.Turn, 100);
                m_game.setPlayerBet(m_game.Turn, 100);
            }

            lblCurrentPlayerStack.Text = m_game.getPlayerToken(m_game.Turn).ToString();
        }

        private void btnBet100_MouseUp(object sender, MouseEventArgs e)
        {
            btnBet100.BackgroundImage = Properties.Resources.blackBet100;
        }

        private void btnBet250_MouseDown(object sender, MouseEventArgs e)
        {
            bool possible;
            btnBet250.BackgroundImage = Properties.Resources.yellowBet250Pressed;
            possible = m_game.setPlayerToken(m_game.Turn, 250);
            if (possible)
            {
                setPlayerBet(m_game.Turn, 250);
                m_game.setPlayerBet(m_game.Turn, 250);
            }
            
            lblCurrentPlayerStack.Text = m_game.getPlayerToken(m_game.Turn).ToString();
        }

        private void btnBet250_MouseUp(object sender, MouseEventArgs e)
        {
            btnBet250.BackgroundImage = Properties.Resources.yellowBet250;
        }

        private void btnBetMouseHover(object sender, EventArgs e)
        {

        }

        private void btnBetMouseLeave(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            String name = button.Name;
            int width = button.Width;
            int height = button.Height;
            switch (name)
            {
                case "btnBet1":
                    btnBet1.Width -= 4;
                    btnBet1.Height -= 4;
                    break;
                case "btnBet10":
                    btnBet10.Width -= 4;
                    btnBet10.Height -= 4;
                    break;
                case "btnBet50":
                    btnBet50.Width -= 4;
                    btnBet50.Height -= 4;
                    break;
                case "btnBet100":
                    btnBet100.Width -= 4;
                    btnBet100.Height -= 4;
                    break;
                case "btnBet250":
                    btnBet250.Width -= 4;
                    btnBet250.Height -= 4;
                    break;
                case "btnHit":
                    btnHit.Width -= 4;
                    btnHit.Height -= 4;
                    break;
                case "btnStand":
                    btnStand.Width -= 4;
                    btnStand.Height -= 4;
                    break;
                default:
                    break;
            }
        }

        private void btnBetMouseEnter(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            String name = button.Name;
            int width = button.Width;
            int height = button.Height;
            switch (name)
            {
                case "btnBet1":
                    btnBet1.Width += 4;
                    btnBet1.Height += 4;
                    break;
                case "btnBet10":
                    btnBet10.Width += 4;
                    btnBet10.Height += 4;
                    break;
                case "btnBet50":
                    btnBet50.Width += 4;
                    btnBet50.Height += 4;
                    break;
                case "btnBet100":
                    btnBet100.Width += 4;
                    btnBet100.Height += 4;
                    break;
                case "btnBet250":
                    btnBet250.Width += 4;
                    btnBet250.Height += 4;
                    break;
                case "btnHit":
                    btnHit.Width += 4;
                    btnHit.Height += 4;
                    break;
                case "btnStand":
                    btnStand.Width += 4;
                    btnStand.Height += 4;
                    break;
                default:
                    break;
            }
        }

        private void btnHit_MouseDown(object sender, MouseEventArgs e)
        {
            btnHit.BackgroundImage = Properties.Resources.btnHitPressed;
        }

        private void btnHit_MouseUp(object sender, MouseEventArgs e)
        {
            btnHit.BackgroundImage = Properties.Resources.btnHit;
        }

        private void btnStand_MouseDown(object sender, MouseEventArgs e)
        {
            btnStand.BackgroundImage = Properties.Resources.btnStandPressed;
        }

        private void btnStand_MouseUp(object sender, MouseEventArgs e)
        {
            btnStand.BackgroundImage = Properties.Resources.btnStand;
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            

        }



        private void btnStartRound_Click(object sender, EventArgs e)
        {

        }

        private void disableHitStandButton() {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            
        }
        private void disableBetButton() {
            btnBet1.Enabled = false;
            btnBet10.Enabled = false;
            btnBet100.Enabled = false;
            btnBet250.Enabled = false;
            btnBet50.Enabled = false;
        }

        private void enableHitStandButton()
        {
            btnHit.Enabled = true;
            btnStand.Enabled = true;

        }
        private void disableBetButtons() {
            btnBet1.Enabled = true;
            btnBet10.Enabled = true;
            btnBet100.Enabled = true;
            btnBet250.Enabled = true;
            btnBet50.Enabled = true;
        }
        public void showDealerHiddenCard() {
            int dealerId;
            dealerId = m_game.getDealerId();
            List<Card> playerCard = m_game.getDealer(dealerId).getHand();
            Card card = playerCard[0];
            dealerHand0.Image = Image.FromFile(@"..\..\Resources\" + card.Name + ".png");
        }
        private void btnConfirmBet_Click(object sender, EventArgs e)
        {
            btnConfirmBet.Visible = false;
            btnConfirmBet.Enabled = false;
            m_game.setPlayerHasBet(m_game.Turn, true);
            if (m_game.lastPlayerHasPlayed())
            {
                m_game.distributeCard();
                enableHitStandButton();
                disableBetButton();
            }
            m_game.switchTurns();
            
            if (m_game.lastPlayerHasPlayed())
            {
                m_game.BetTurn = false;
            }
            betTurn(m_game.getPlayerName(m_game.Turn));
        }
    }
    //public static Bitmap RotateImage(Image image, PointF offset, float angle)
    //{
    //    if (image == null)
    //        throw new ArgumentNullException("image");

    //    //create a new empty bitmap to hold rotated image
    //    Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
    //    rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

    //    //make a graphics object from the empty bitmap
    //    Graphics g = Graphics.FromImage(rotatedBmp);

    //    //Put the rotation point in the center of the image
    //    g.TranslateTransform(offset.X, offset.Y);

    //    //rotate the image
    //    g.RotateTransform(angle);

    //    //move the image back
    //    g.TranslateTransform(-offset.X, -offset.Y);

    //    //draw passed in image onto graphics object
    //    g.DrawImage(image, new PointF(0, 0));

    //    return rotatedBmp;
    //}
}
