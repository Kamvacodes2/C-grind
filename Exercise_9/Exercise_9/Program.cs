using System;

namespace ReturnoftheSith
{
    class Program
    {
        static void Main()
        {
            GetName();
        }

        static void SayHi(string name, double age)
        {
            var final = Convert.ToString(($"Hi {name}, you are {age}"));
            Console.WriteLine(final);
            return;
        }

        static void GetName()
        {
            Console.WriteLine("Please enter your name ");
            var userName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter your age ");
            var age = Convert.ToDouble(Console.ReadLine());

            if (userName == null)
            {
                Console.WriteLine("You did not enter a valid name");
                return;
            }
            SayHi(userName, age);
        }
    }
}
