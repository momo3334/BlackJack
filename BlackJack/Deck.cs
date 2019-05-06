using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        Card[] m_cards = new Card[52];



        public Card[] Cards
        {
            get { return m_cards; }
            set { m_cards = value;  }
        }


        public Deck()
        {
            String[] suits = { "Carreau", "Coeur", "Pique", "Trefle" };
            for (int i = 0; i < 52; i += 4)
            {
                int value = (i / 4) + 1;
                for (int j = 0; j < 4; j++)
                {
                    if (value == 1)
                    {
                        m_cards[i + j] = new Card("A" + suits[j], 1);
                    }
                    else if (value < 11 && value > 1)
                    {
                        m_cards[i + j] = new Card(value + suits[j], value);
                    }
                    else if (value == 11)
                    {
                        m_cards[i + j] = new Card("J" + suits[j], 10);
                    }
                    else if(value == 12)
                    {
                        m_cards[i + j] = new Card("Q" + suits[j], 10);
                    }
                    else if(value == 13)
                    {
                        m_cards[i + j] = new Card("K" + suits[j], 10);
                    }
                }
            }
        }





    }
}
