using System;

namespace highlow_number_guessing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int MAX_GUESSES = 5;
            const int MIN_GUESS_RANGE= 1;
            const int MAX_GUESS_RANGE= 101;
            
            Console.WriteLine("Welcome to the High/Low number guessing game");
            Console.WriteLine($"The rules are you have a total of {MAX_GUESSES} guesses to find the correct random number between {MIN_GUESS_RANGE} and {MAX_GUESS_RANGE}.");
            
            Random random = new Random();
            int randomNumber = random.Next(MIN_GUESS_RANGE, MAX_GUESS_RANGE);
            
            int leftGuess = MAX_GUESSES;
            
            while (leftGuess > 0)
            {
                Console.Write("Enter your guess: ");
                string guessedNumber = Console.ReadLine();
                
                if(!int.TryParse(guessedNumber, out int playerNumber))
                {
                    Console.WriteLine("Please use NUMBERS not LETTERS.");
                    continue;
                }
                if (playerNumber < randomNumber)
                {
                    Console.WriteLine("Too low.");
                }
                if (playerNumber > randomNumber)
                {
                    Console.WriteLine("Too high.");
                }
                if (playerNumber == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the random number.");
                    break;
                }

                leftGuess--;
                Console.WriteLine($"number of guesses left: {leftGuess}");
            }
            if (leftGuess == 0)
            {
                Console.WriteLine("GAME OVER!!! You have no guesses left");
                Console.WriteLine($"The random number was {randomNumber}.");

            }
            
        }
    }
}