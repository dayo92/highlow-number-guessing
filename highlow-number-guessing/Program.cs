﻿using System;

namespace highlow_number_guessing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int maxGuess = 5;
            
            Console.WriteLine("Welcome to the High/Low number guessing game");
            Console.WriteLine($"The rules are you have a total of {maxGuess} guesses to find the correct random number between 1 and 100.");
            
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            
            for (int i = maxGuess; i > 0; i--)
            {
                Console.Write("Enter your guess: ");
                string guessedNumber = Console.ReadLine();
                
                if(!int.TryParse(guessedNumber, out int playerNumber))
                {
                    Console.WriteLine("Please use NUMBERS not LETTERS.");
                    i++; 
                    continue;
                }

                if (playerNumber < randomNumber)
                {
                    Console.WriteLine("Too low.");
                    maxGuess--;
                }
                if (playerNumber > randomNumber)
                {
                    Console.WriteLine("Too high.");
                    maxGuess--;
                }
                if (playerNumber == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the secret number.");

                }
                Console.WriteLine("number of guesses left: "+maxGuess);
                
                if (maxGuess == 0)
                {
                    Console.WriteLine("GAME OVER!!! You have no guesses left");
                    Console.WriteLine($"The random number was {randomNumber}.");

                }

       
            }
            
        }
    }
}