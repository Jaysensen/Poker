using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Dealer
    {
        /// <summary>
        /// Deck containing all of the cards
        /// </summary>
        public Card[] Deck;

        public Dealer()
        {
            int iterator = 0;
            for (int i = 0; i <= 12; i++)
            {
                Card temp1 = new Card('S', (i + 2));
                Deck[iterator] = temp1;
                iterator++;
                Card temp2 = new Card('H', (i + 2));
                Deck[iterator] = temp2;
                iterator++;
                Card temp3 = new Card('D', (i + 2));
                Deck[iterator] = temp3;
                iterator++;
                Card temp4 = new Card('C', (i + 2));
                Deck[iterator] = temp4;
                iterator++;

            }
        }
    }
}