namespace Lektion4A;

class Program
{
    static void Main()
    {
        while (true)
        {
            Random rnd = new Random();
            int theNumber = rnd.Next(0, 10);
            int attempts = 3; // Allow only 3 attempts

            Console.WriteLine("Guess the number between 0 and 10. You have 3 attempts!");

            bool guessedCorrectly = false;
            for (int i = 1; i <= attempts; i++)
            {
                int gamerInput = GetValidNumber();

                if (gamerInput == theNumber)
                {
                    Console.WriteLine($"Bravo! You guessed correctly in {i} attempt(s)!");
                    guessedCorrectly = true;
                    break;
                }
                else
                {
                    Console.WriteLine($"Wrong guess! You have {attempts - i} attempt(s) left.");
                }
            }

            if (!guessedCorrectly)
            {
                Console.WriteLine($"Game over! The correct number was {theNumber}.");
            }

            Console.WriteLine("Do you want to play again? (y/n)");
            if (Console.ReadLine()?.ToLower() != "y") break;
        }
    }
    static int GetValidNumber()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number >= 0 && number <= 10)
            {
                return number; // Return the valid number
            }
            Console.WriteLine("Invalid input! Please enter a number between 0 and 10.");
        }
    }
}
