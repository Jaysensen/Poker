using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Spade : BaseCard 
    {
        public override ushort Precedence { get; set; } = 4;

        public override int Value { get; set ;}
        public Spade(int val)
        {
            Value = val;
        }
    }
}