using System;

namespace TallandName
{
    class Program
    {
        static void Main()
        {
            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("This is a male and he is tall");
            }
            else if (isMale)
            {
                Console.WriteLine("He short");
            }
            else if(isTall)
            {
                Console.WriteLine("She is tall");
            }
            else
            {
                Console.WriteLine("She is short");
            }
        }
    }
}
