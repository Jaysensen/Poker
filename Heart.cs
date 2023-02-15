using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker 
{
    internal class Heart : BaseCard 
    {
        /// <summary>
        /// Will be used in cases of a tie, larger number wins
        /// </summary>
        /// <value></value>
        public override ushort Precedence { get; set; } = 3;

        public int Value { get; set; }
        public Heart(int val)
        {
            Value = val;
        }
    }
}
