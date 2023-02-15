using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Poker
{
    internal class Club : BaseCard 
    {
        /// <summary>
        /// Will be used in cases of a tie, larger number wins
        /// </summary>
        /// <value></value>
        public override ushort Precedence { get; set; } = 1;

        public int Value { get; set; }
        public Club(int val)
        {
            Value = val;
        }

    }
}
