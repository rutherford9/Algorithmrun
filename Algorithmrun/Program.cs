using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmrun
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLogic shoop = new MyLogic();
            Console.WriteLine(shoop.IsPalindrome(12321));
            Console.ReadLine();
        }
    }
}
