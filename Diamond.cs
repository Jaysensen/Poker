using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker 
{
    internal class Diamond : BaseCard 
    {
        /// <summary>
        /// Will be used in cases of a tie, larger number wins
        /// </summary>
        /// <value></value>
        public override ushort Precedence { get; set; } = 2;
        public int Value { get; set; }
        public Diamond(int val)
        {
            Value = val;
        }
    }
}
