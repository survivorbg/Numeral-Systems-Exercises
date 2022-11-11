using System;

namespace Decimal_to_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decNum = 13;
            Console.WriteLine(DecToBinary(decNum));

        }
        static string DecToBinary(int num)
        {
            string result = "";
            while(num>0) 
            {
                result = num % 2 + result;
                num /= 2;
            }
            return result;
        }
    }
}
