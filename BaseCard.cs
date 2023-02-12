using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Poker 
{
    public abstract class BaseCard
    {
        public abstract int Value; { get; set; }

        public abstract ushort Precedence { get; set; }

    }
}
