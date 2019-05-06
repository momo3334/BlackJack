using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        String m_name;
        int m_value;

        public String Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public int Value
        {
            get { return m_value; }
            set { m_value = value; }
        }

        public Card(String name, int value)
        {
            this.m_name = name;
            this.m_value = value;
        }

     
    }
}
