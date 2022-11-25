using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTricks
{
    class SwapNumber_Variable
    {
        static void Main()
        {
            int num1 = 10;
            int num2 = 20;
            int temp = 0;
            Console.WriteLine("Before swapping numbers are {0} {1}", num1, num2);

            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping numbers are {0} {1}", num1, num2);
        }
    }
}
