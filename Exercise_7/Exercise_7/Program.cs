using System;

namespace Lists
{
    class Program
    {
        static void Main()
        {
            int[] luckyNumbers = { 4, 8, 90, 55, 45, 30, 2 };
            luckyNumbers[2] = 1000;

            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[2]);
            Console.WriteLine(luckyNumbers[1]);
        }
    }
}