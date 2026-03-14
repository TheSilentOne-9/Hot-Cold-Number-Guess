using System;

namespace HotColdGame
{
    class Program
    {
        // Instantiating Random at the class level to ensure true randomness
        static readonly Random rnd = new Random();

        static void Main(string[] args)
        {
            bool playAgain = true;

            Console.WriteLine("Welcome to the Hot & Cold Number Guessing Game!");
            Console.WriteLine("I have picked a number between 1 and 100. You have 5 attempts to find it.\n");

            do
            {
                int targetNumber = rnd.Next(1, 101);
                int attemptsLeft = 9;
                bool hasWon = false;

                // Using a while loop is much cleaner for condition-based countdowns
                while (attemptsLeft > 0)
                {
                    Console.Write($"\nEnter your guess (Attempts left: {attemptsLeft}): ");
                    string input = Console.ReadLine();

                    // int.TryParse prevents the application from crashing if the user enters letters or symbols
                    if (int.TryParse(input, out int guess))
                    {
                        // Validating the input range strictly between 1 and 100
                        if (guess < 1 || guess > 100)
                        {
                            Console.WriteLine("Invalid input. Please enter a number strictly between 1 and 100.");
                            continue; // Skips the rest of the loop without consuming an attempt
                        }

                        // Win condition
                        if (guess == targetNumber)
                        {
                            Console.WriteLine("Bravo! You guessed it right. You win!");
                            hasWon = true;
                            break;
                        }

                        // Calculating the absolute difference to provide Hot/Cold feedback
                        int diff = Math.Abs(guess - targetNumber);

                        if (diff <= 5)
                        {
                            Console.WriteLine("VERY HOT! You are extremely close.");
                        }
                        else if (diff <= 10)
                        {
                            Console.WriteLine("HOT! You are getting closer.");
                        }
                        else if (diff <= 20)
                        {
                            Console.WriteLine("COLD! You are a bit far.");
                        }
                        else
                        {
                            Console.WriteLine("VERY COLD! You are way off.");
                        }

                        // Decrement attempts only after a valid, incorrect guess
                        attemptsLeft--;
                    }
                    else
                    {
                        Console.WriteLine("Invalid format. Please enter a valid numerical integer.");
                    }
                }

                // Checking the lose condition
                if (!hasWon)
                {
                    Console.WriteLine($"\nYou lost the game. The correct number was {targetNumber}.");
                }

                Console.WriteLine("\nPlay Again? (Enter '1' to play again, any other key to exit)");
                string choice = Console.ReadLine();
                playAgain = (choice == "1");

            } while (playAgain);

            Console.WriteLine("Thanks for playing! Goodbye.");
        }
    }
}