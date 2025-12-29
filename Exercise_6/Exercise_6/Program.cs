using System;

namespace Madlib
{
    class Program
    {
        static void Main()
        {
            //“I never expected to see a (color) (noun) signed by (celebrity) sitting in my kitchen.”

            Console.WriteLine("Please enter a color ");
            var color = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Now write any noun ");
            var noun = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Lastly write the name of any celebrity first and last name please ");
            var celeb = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Say the magic words...it starts with P");
            Console.ReadLine();
            Console.WriteLine($"I never expected to see a {color} {noun} signed by {celeb} sitting in my kitchen.");
        }
    }
}
