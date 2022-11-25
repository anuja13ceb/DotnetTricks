using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTricks
{
    class SumOfNumber
    {
        static void Main()
        {
            int FourDigitNumber = 1234;
            int sum = 0;
            int m;

            while(FourDigitNumber>0)
            {
                m = FourDigitNumber % 10;
                sum = sum + m;
                FourDigitNumber = FourDigitNumber / 10;
            }
            Console.WriteLine("Sum is=" + sum);


        }
    }
}
