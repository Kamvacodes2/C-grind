using System;

namespace CondtionalConvo
{
    class Program
    {
        static void Main()
        {
            bool begin = true;

            if (begin)
            {
                Console.WriteLine("Hi there whats your name? ");
                var name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Are you a man or woman? ");
                var gender = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Are you a tall? ");
                var height = Convert.ToString(Console.ReadLine());

                if (name == null)
                {
                    return;
                }

                if (gender == null ||  height == null)
                {
                    Console.WriteLine("Please enter valid info ");
                    return;
                }
                else if (gender == "man" && height == "yes")
                {
                    Console.WriteLine($"{name} you are a tall man");
                }
                else if (gender == "man" && height == "no")
                {
                    Console.WriteLine($"{name} you are not a tall man");
                }
                else if (gender == "woman" && height == "yes")
                {
                    Console.WriteLine($"{name} you are a tall woman");
                    
                }
                else if (gender == "woman" && height == "no" )
                {
                    Console.WriteLine($"{name} you are not a tall woman");
                }

            }
            return;
        }
    }
}