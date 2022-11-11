using System;

namespace Binary_to_HexDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binaryNum = 111111;
            Console.WriteLine(BinaryToDec(binaryNum));
            
        }
        static int BinaryToDec(long binaryNum)
        {
            double result = 0;
            string sNum = binaryNum.ToString();
            int length = sNum.Length;
            for (int i = 0; i < length; i++)
            {
                result += (sNum[i] - '0') * Math.Pow(2, length - i - 1);
            }
            return (int)result;
        }
    }

}

