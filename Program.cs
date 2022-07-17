﻿namespace ClassesAndObjects
{
    class Program
    {

        static void Main(string[] args)
        {
            string secretWord = "Taqi";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter guess:");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }else
            {
                Console.WriteLine("You Win!");
            }
            Console.ReadLine();
        }
    }
}
