using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTricks
{
    class Swap_numbers_
    {
        static void Main()
        {
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("Before swapping numbers are {0} {1}", num1,num2);

            num1 = num1 + num2; //num1 = 10+20=30
            num2 = num1 - num2; //num2 = 30-20=10
            num1 = num1 - num2; //num1 = 30-10=20

            Console.WriteLine("After swapping numbers are {0} {1}" , num1, num2);
        }
    }
}
