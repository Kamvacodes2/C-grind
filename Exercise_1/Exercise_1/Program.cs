using System;

namespace Checker
{
    class Program
    {
        static void Main()
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale)
            {
                Console.WriteLine("This person is indeed a male");
            }
            else if (isTall)
            {
                Console.WriteLine("They are tall");
            }
            else
            {
                Console.WriteLine("They are neither tall or short");
            }
        }
    }
}