using System;
using System.Xml.Linq;

namespace Funkshins
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Please enter your name ");
            var name1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter your age as well");
            var age1 = Convert.ToDouble(Console.ReadLine());

            if (name1 == null)
            {
                Console.WriteLine("Kindly enter a valid name please ");
                return;
            }

            SayHi(name1,age1);
        }

        static void SayHi(string name, double age)
        {
            Console.WriteLine($"Hello there {name}, you are {age}");
        }
    }


}