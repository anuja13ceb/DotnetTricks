using System;

namespace DotnetTricks
{
    class variable
    {

        static void Main()
        {
            int num = 10;
            object obj = num;
            int num2 = (int)obj;
            string str = "Anuja";
            bool flag = true;
            char ch = 'a';
            var num1 = 'a';
            num1 = 'b';
            //System.Console.WriteLine(num1);

            string str1 = "10";
            //int str2 = Convert.ToInt32(str1);
            int str2 = int.Parse(str1);
            //Console.WriteLine(str1);

            int number = 12;
            double d = number; //implicit conversion
            int number1 = (int)d; //explicit conversion
            Console.WriteLine(d);
   

        }

        
    }
}
