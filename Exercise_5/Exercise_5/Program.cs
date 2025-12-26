using System;

namespace BasicCalc
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first number ");
            double firstNumb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kindly enter the second number ");
            double secondNumb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(firstNumb + secondNumb);
        }
    }
}