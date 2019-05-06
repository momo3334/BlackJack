using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer
    {
        String m_name;
        Hand m_hand;

        public String Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public Dealer()
        {
            this.m_name = "Croupier";
            this.m_hand = new Hand();
        }
        public bool needRefresh()
        {
            return m_hand.NeedRefresh;
        }
        public void setNeedRefresh(bool needRefresh)
        {
            m_hand.NeedRefresh = needRefresh;
        }
        public Hand CurrentHand {
            get { return m_hand; }
            set { m_hand = value; }
        }

        public void addCard(Card receivedCard)
        {
            m_hand.addCard(receivedCard);
        }
        public int getHandValue() {
            return m_hand.HandValue;
        }

        public List<Card> getHand()
        {
            return m_hand.Cards;
        }
    }
}
