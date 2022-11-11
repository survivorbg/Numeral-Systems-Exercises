using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinToDec(1111010110011110));
        }
        static long BinToDec(long value)
        {
            double result = 0;
            string sValue = value.ToString();
            int length =sValue.Length;

            for (int i = 0; i < length; i++)
            {
                result += (sValue[i] - '0') * Math.Pow(2, length - i - 1);
            }
            return (long)result;
        }
    }
}
