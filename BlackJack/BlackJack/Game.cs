using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace BlackJack
{
    public class Game
    {
        GameForm m_gameForm;
        Shoe m_shoe;
        List<Player> m_player;
        Dealer m_dealer;
        int m_turn;
        bool m_betTurn;

        public int Turn
        {
            get { return m_turn; }
            set { m_turn = value; }
        }
        public Dealer Dealer
        {
            get { return m_dealer; }
            set { m_dealer = value; }
        }
        public Player this[int i]
        {
            get { return m_player[i]; }
            set { m_player[i] = value; }
        }

        public int playerCount() {
            return m_player.Count;
        }
        public Game(int nbPlayer)
        {
            this.m_gameForm = new GameForm(this);
            this.m_shoe = new Shoe(3);
            this.m_player = new List<Player>();
            this.m_betTurn = true;
            for (int i = 0; i < nbPlayer; i++)
            {
                this.m_player.Add(new Player(i));
            }

            this.m_turn = 0;


            foreach (Card c in m_shoe.Cards)
            {
                System.Diagnostics.Debug.WriteLine(c.Name);
            }

            this.m_dealer = new Dealer();

            m_gameForm.setNbPlayer(nbPlayer);


            m_gameForm.Show();
            m_gameForm.setPlayerName();
            m_gameForm.betTurn(m_player[0].Name);

        }
        public string getPlayerName(int id) {
            return m_player[id].Name;
        }
        public bool BetTurn {
            get { return m_betTurn; }
            set { m_betTurn = value; }
        }
        public void distributeCard()
        {
            
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < m_player.Count(); i++)
                {
                    Thread.Sleep(350);
                    giveCard(m_player[i]);
                    
                    m_gameForm.refreshHand();
                }
                giveCard(this.m_dealer);
                m_gameForm.refreshHand();
            }

        }
        public bool getPlayerHasBet(int playerId) {
            return m_player[playerId].HasBet;
        }
        public void setPlayerHasBet(int playerId,bool hasBet)
        {
            m_player[playerId].HasBet = hasBet;
        }
        public void checkForWin() {
            m_gameForm.showDealerHiddenCard();

            if (m_dealer.getHandValue() <= 21)
            {
                for (int i = 0; i < m_player.Count ; i++)
                {

                    if (m_player[i].getHandValue() > m_dealer.getHandValue() && m_player[i].getHandValue() <= 21)
                    {
                        m_gameForm.setInfoLblString("Le joueur: " + m_player[i].Name + " gagne sa mise");
                        Thread.Sleep(1500);
                    }
                    
                }
            }
            
        }
        public bool lastPlayerHasPlayed() {
            if (m_player[m_player.Count -1].HasBet)
            {
                return true;
            }
            return false;
        }
        public void switchTurns()
        {
            switch (m_turn)
            {
                case 0:
                    
                    if (m_player.Count == 1)
                    {
                        m_gameForm.betTurn(m_player[0].Name);
                        m_gameForm.uncolorLabel(0);
                        if (!m_betTurn)
                        {
                            dealerTurn();
                        }
                        
                        m_turn = 0;
                        m_gameForm.colorLabel(0);
                        
                    }
                    else if(m_player.Count == 2)  
                    {
                        m_gameForm.betTurn(m_player[1].Name);
                        m_gameForm.uncolorLabel(2);
                        m_turn = 1;
                        m_gameForm.colorLabel(0);
                    }
                    else
                    {
                        m_gameForm.uncolorLabel(1);
                        m_gameForm.betTurn(m_player[1].Name);
                        m_turn = 1;
                        m_gameForm.colorLabel(2);
                    }
                   
                    break;
                case 1:
                    
                    if (m_player.Count == 2)
                    {
                        m_gameForm.betTurn(m_player[0].Name);
                        m_gameForm.uncolorLabel(0);
                        if (!m_betTurn)
                        {
                            dealerTurn();
                        }
                        m_turn = 0;
                        m_gameForm.colorLabel(2);
                    }
                    else
                    {
                        m_gameForm.betTurn(m_player[2].Name);
                        m_gameForm.uncolorLabel(2);
                        m_turn = 2;
                        m_gameForm.colorLabel(0);
                    }

                    break;
                case 2:
                    
                    m_gameForm.uncolorLabel(0);
                    if (m_player.Count == 3)
                    {
                        m_gameForm.betTurn(m_player[0].Name);
                        if (!m_betTurn)
                        {
                            dealerTurn();
                        }
                        m_turn = 0;
                        m_gameForm.colorLabel(1);
                    }
                    else
                    {
                        m_gameForm.betTurn(m_player[3].Name);
                        m_turn = 3;
                        m_gameForm.colorLabel(3);
                    }

                    break;
                case 3:
                    
                    m_gameForm.uncolorLabel(3);
                    if (m_player.Count == 4)
                    {
                        m_gameForm.betTurn(m_player[0].Name);
                        if (!m_betTurn)
                        {
                            dealerTurn();
                        }
                        m_turn = 0;
                        m_gameForm.colorLabel(1);
                    }
                    else
                    {
                        m_gameForm.betTurn(m_player[4].Name);
                        m_turn = 4;
                        m_gameForm.colorLabel(4);
                    }
                    
                    break;
                case 4:
                    m_gameForm.betTurn(m_player[0].Name);
                    m_gameForm.uncolorLabel(4);
                    if (!m_betTurn)
                    {
                        dealerTurn();
                    }
                    m_turn = 0;
                    m_gameForm.colorLabel(1);
                   
                    break;
                default:
                    break;
            }
        }
        public void dealerTurn()
        {
            //m_dealer.CurrentHand.calculateHandValue();
            while (m_dealer.CurrentHand.HandValue < 17)
            {
                giveCard(m_dealer);
                //m_dealer.CurrentHand.calculateHandValue();
                m_gameForm.refreshHand();
            }
            checkForWin();
        }
        public int dealerHandValue()
        {
            return m_dealer.getHandValue();
        }
        public int playerHandValue(int playerId)
        {
            return m_player[playerId].getHandValue();
        }
        public void giveCard(Player receiver)
        {
            if (receiver.getHandValue() < 21)
            {
                Card pickedCard = m_shoe.pickCard();
                receiver.addCard(pickedCard);
                receiver.setNeedRefresh(true);
            }
           
        }

        public void setPlayerRefresh(int id,bool needRefresh) {
            m_player[id].setNeedRefresh(needRefresh);
        }
        public void setDealerRefresh(bool needRefresh)
        {
            m_dealer.setNeedRefresh(needRefresh);
        }
        public bool getPlayerRefresh(int id)
        {
           return m_player[id].needRefresh();
        }
        public bool getDealerRefresh()
        {
           return m_dealer.needRefresh();
        }
        public void giveCard(Dealer receiver)
        {
            Card pickedCard = m_shoe.pickCard();
            receiver.addCard(pickedCard);
            receiver.setNeedRefresh(true);
        }
        public void setPlayerToken(int playerId, int tokenSpent) {
            m_player[playerId].Token -= tokenSpent ;
        }
        public int getPlayerToken(int playerId) {
            return m_player[playerId].Token;
        }
        public List<Card> getCards(Player player)
        {
            return player.getHand();
        }

        public List<Card> getCards(Dealer dealer)
        {
            return dealer.getHand();
        }
    }
}
