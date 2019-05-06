using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Shoe
    {
        List<Card> m_cards;
        int m_deckNumber;
        int deckIndex = 0;

        public List<Card> Cards
        {
            get { return m_cards; }
            set { m_cards = value;  }
        }

        public Shoe(int deckNumber)
        {
            this.m_cards = new List<Card>();
            this.m_deckNumber = deckNumber;
            List<Deck> decks = new List<Deck>();

            for (int i = 0; i < deckNumber; i++)
            {
                Deck tempDeck = new Deck();
                for (int j = 0; j < tempDeck.Cards.Length; j++)
                {
                    m_cards.Add(tempDeck.Cards[j]);
                }
            }

            scramble();
        }

        public Card pickCard()
        {
            if (deckIndex < (m_deckNumber * 52) -1)
            {
                deckIndex++;
            }
            else
            {
                deckIndex = 0;
                scramble();
            }

            return m_cards[deckIndex];
        }

        public void scramble()
        {
            Random rdn = new Random();

            for (int i = 0; i < m_cards.Count; i++)
            {
                int r = i + rdn.Next(m_cards.Count - i);
                swap(i, r);
            }
        }

        public void swap(int a, int b)
        {
            Card temp = m_cards[a];
            m_cards[a] = m_cards[b];
            m_cards[b] = temp;
        }
    }
}
  