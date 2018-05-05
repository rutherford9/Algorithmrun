using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmrun
{
    class MyLogic
    {
        //bool for determining whether a given int is a palindrome
        public bool IsPalindrome(int x)
        {
            //initialize both variables
            int temp = x;
            int reverse = 0;
            //while loop that contains logic that will satisfy requirements in two lines of code
            while (temp != 0)
            {
                //this logic depends on the integer properties of c#, namely rounding ints <10 divided by ten to zero, 
                //as well as rounding modulus of ints <10 to 1. this loop keeps adjusting the values of reverse and temp, 
                //where temp eventually gets iterated through until it becomes zero, and reverse should produce the palindrome
                //of the initial input, in this case x.
                reverse = reverse * 10 + temp % 10;
                temp = temp / 10;
            }
            //x and reverse finally get compared, to see if they are equal. If they are, the input is a palindrome.
            //otherwise, they are not, and thus false is returned to the user. 
            return x == reverse;
        }
    }
}
