using System;

namespace guessGame
{
    class Program 
    {

        static Random random = new Random();
        static void Main()
        {
            string secretWord = "Special";
            string userGuess = "";

            if (secretWord == null || userGuess == null)
            {
                return;
            }
            while (userGuess != secretWord)
            {

                Console.WriteLine("Try to guess the secret word");

                List<string> words = new List<string> { $"Its a {secretWord.Length} letter word", $"The word ends with {secretWord[secretWord.Length - 1]}", $"The word starts with {secretWord[0]}" };

                Random random = new Random();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(words[random.Next(words.Count)]);
                    userGuess = Console.ReadLine();
                    if (userGuess != secretWord)
                    {
                        Console.WriteLine("Try again");
                    }
                    else
                    {

                        Console.WriteLine("Well done you guessed it!");
                        return;
                    }
                }
                Console.WriteLine($"You qualify for an extra tip the second letter of this word is {secretWord[2]}");
            }
        }
        
    }
}
