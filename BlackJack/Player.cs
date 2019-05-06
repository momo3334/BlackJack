using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        String m_name;
        Hand m_hand;
        int m_playerId;
        int m_token;
        bool m_hasBet;
        public bool HasBet {
            get { return m_hasBet; }
            set { m_hasBet = value; }
        }
        public String Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public int Token {
            get { return m_token; }
            set { m_token = value; }
        }
        public Player(int playerId, String name = "Inconnu")
        {
            this.m_name = name + playerId;
            this.m_hand = new Hand();
            this.m_playerId = playerId;
            this.m_token = 1000;
        }
        public bool needRefresh() {
           return m_hand.NeedRefresh;
        }

        public void setNeedRefresh(bool needRefresh) {
            m_hand.NeedRefresh = needRefresh;
        }
        public int getHandValue()
        {
            return m_hand.HandValue;
        }
        public void addCard(Card receivedCard)
        {
            m_hand.addCard(receivedCard);
        }

        public List<Card> getHand()
        {
            return m_hand.Cards;
        }
    }
}
