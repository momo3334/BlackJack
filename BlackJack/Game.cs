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
        List<Dealer> m_dealer;
        int m_turn;
        bool m_betTurn;

        public int Turn
        {
            get { return m_turn; }
            set { m_turn = value; }
        }
        public Dealer getDealer(int i) {
            return m_dealer[i];
        }

        //public Dealer Dealer
        //{
        //    get { return m_dealer; }
        //    set { m_dealer = value; }
        //}
        public Player this[int i]
        {
            get { return m_player[i]; }
            set { m_player[i] = value; }
        }
        public int getDealerId() {
            return (m_dealer.Count - 1);
        }
        public int playerCount() {
            return m_player.Count;
        }
        public int botCount()
        {
            return m_dealer.Count - 1;
        }
        public Game(int nbPlayer, int nbBot)
        {
            this.m_gameForm = new GameForm(this);
            this.m_shoe = new Shoe(3);
            this.m_player = new List<Player>();
            this.m_dealer = new List<Dealer>();
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
            for (int i = 0; i < nbBot +1 ; i++)
            { 
                if (i < nbBot)
                {
                    this.m_dealer.Add(new Dealer("Ordinateur" + (i + 1)));
                }
                else
                {
                    this.m_dealer.Add(new Dealer());
                }
            }
            

            m_gameForm.setNbPlayer(nbPlayer);


            m_gameForm.Show();
            m_gameForm.setPlayerName();
            m_gameForm.betTurn(m_player[0].Name);
            m_gameForm.setPlayerInfo(m_player[m_turn].Name, m_player[m_turn].Token);
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
                // si c'est le delaer sinon c'est n bot faire une else
                for (int i = 0; i < m_dealer.Count - 1; i++)
                {
                    Thread.Sleep(350);
                    giveCard(this.m_dealer[i]);
                    m_gameForm.refreshHand();
                }
                giveCard(this.m_dealer[m_dealer.Count - 1]);
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

            for (int i = 0; i < m_player.Count ; i++)
            {
            
                if (m_player[i].getHandValue() > m_dealer[m_dealer.Count - 1].getHandValue() && m_player[i].getHandValue() <= 21)
                {
                    m_gameForm.setInfoLblString("Le joueur: " + m_player[i].Name + " gagne sa mise");
                    m_player[i].Token += (m_player[i].Bet * 2);
                    Thread.Sleep(1500);
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
        {////// mettre des if ici de si c'est un bot
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
            m_gameForm.setPlayerInfo(m_player[m_turn].Name, m_player[m_turn].Token);
        }
        public void dealerTurn()
        {
            //m_dealer.CurrentHand.calculateHandValue();
            while (m_dealer[m_dealer.Count - 1].CurrentHand.HandValue < 17)
            {
                giveCard(m_dealer[m_dealer.Count - 1]);
                //m_dealer.CurrentHand.calculateHandValue();
                m_gameForm.refreshHand();
            }
            checkForWin();
            reset();
        }
        public int dealerHandValue()
        {
            return m_dealer[m_dealer.Count - 1].getHandValue();
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
                if (receiver.getHandValue() > 21)
                {
                    switchTurns();
                }
            }
           
        }
        public int getPlayerBet(int id) {
            return m_player[id].Bet;
        }
        public void setPlayerBet(int id, int bet) {
            m_player[id].Bet = bet;
        }
        public void setPlayerRefresh(int id,bool needRefresh) {
            m_player[id].setNeedRefresh(needRefresh);
        }
        public void setDealerRefresh(bool needRefresh)
        {
            m_dealer[m_dealer.Count - 1].setNeedRefresh(needRefresh);
        }
        public bool getPlayerRefresh(int id)
        {
           return m_player[id].needRefresh();
        }
        public bool getDealerRefresh(int id)
        {
           return m_dealer[id].needRefresh();
        }
        public void giveCard(Dealer receiver)
        {
            Card pickedCard = m_shoe.pickCard();
            receiver.addCard(pickedCard);
            receiver.setNeedRefresh(true);
        }
        public bool setPlayerToken(int playerId, int tokenSpent) {
            if ((m_player[playerId].Token - tokenSpent) >= 0)
            {
                m_player[playerId].Token -= tokenSpent;
                return true;
            }
            return false;
        }
        public int getPlayerToken(int playerId) {

                return m_player[playerId].Token;
            

        }
        public List<Card> getCards(Player player)
        {
            return player.getHand();
        }
        public void reset() {
            getDealer(m_dealer.Count - 1).clearHand();
            for (int i = 0; i < m_player.Count - 1; i++)
            {
                m_player[i].Bet = 0;
                m_player[i].clearHand();

            }
            m_gameForm.reset();
        }
        public List<Card> getCards(Dealer dealer)
        {
            return dealer.getHand();
        }
    }
}
