using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Class for the cards
/// </summary>
namespace Poker
{
    public class Card
    {
        /// <summary>
        /// Value for the card i.e: 2-13
        /// </summary>
        /// <value></value>
        public int Value { get; set; }
        
        /// <summary>
        /// Suit for the card i.e: Spade, Heart, etc...
        /// </summary>
        /// <value></value>
        public char Suit { get; set; }

        

        /// <summary>
        /// Basic Constructor
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="value"></param>
        public Card(char suit, int value)
        {
            Value = value;
            Suit = suit;
        }

    }
}
