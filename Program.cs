using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;
using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Program
    {
        static void Main()
        {
            Spade s1 = new Spade(1);
            Heart h1 = new Heart(2);
            Club c1 = new Club(3);
            Diamond d1 = new Diamond(4);
            Console.WriteLine(s1.Value);
            Console.WriteLine(h1.Value);
            Console.WriteLine(c1.Value);
            Console.WriteLine(d1.Value);
        }
    }
}

