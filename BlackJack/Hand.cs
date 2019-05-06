using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Hand
    {
        List<Card> m_cards;
        int m_handValue;
        bool m_ace;
        bool m_needRefresh;

        public Card this[int index]
        {
            get { return m_cards[index]; }
            set { m_cards.Add(value); }
        }
        public bool NeedRefresh {
            get { return m_needRefresh; }
            set { m_needRefresh = value; }
        }

        public List<Card> Cards
        {
            get { return this.m_cards; }
            set { this.m_cards = value; }
        }

        public Hand()
        {
            this.m_cards = new List<Card>();
            m_handValue = 0;
            m_ace = false;
            m_needRefresh = true;
        }
        public int HandValue {
            get { return m_handValue; }
            set { m_handValue = value; }
        }
        public void calculateHandValue() {
            for (int i = 0; i < m_cards.Count; i++)
            {
                if (!m_ace && m_cards[i].Value == 1)
                {
                     m_ace = true;
                }
                m_handValue += m_cards[i].Value;
            }
            if (m_handValue +10 <= 21 && m_ace)
            {
                m_handValue += 10;
                m_ace = false;
            }
        }

        public void addCard(Card receivedCard)
        {
            m_cards.Add(receivedCard);
            m_handValue += receivedCard.Value;
            if (receivedCard.Value == 1)
            {
                if (m_handValue + 10 <= 21)
                {
                    m_handValue += 10;
                    m_ace = true;
                }
            }
            if (m_ace && m_handValue - 10 <= 21 && m_handValue > 21)
            {
                m_handValue -= 10;
                m_ace = false;
            }
           
            
        }
    }
}
