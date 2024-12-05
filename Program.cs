namespace Lektion4A;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Generate a random number
            Random rnd = new Random();
            int theNumber = rnd.Next(0, 10);

            // Prompt the user to guess
            Console.WriteLine("Let's play a game! I've guessed a number between 0 and 10. Enter a number, and let's see if you guess correctly!");
            int gamerInput;
            while (true) // Loop until valid input is provided
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out gamerInput) && gamerInput >= 0 && gamerInput <= 10)
                {
                    break; // Valid input, exit the loop
                }
                Console.WriteLine("Invalid input! Please enter a number between 0 and 10.");
            }

            // Check the guess
            if (gamerInput == theNumber)
            {
                Console.WriteLine($"Bravo! Your answer {theNumber} was correct! Do you want to continue or exit the game? To continue, press 'c'. To exit, press 'x'.");

                // Get the user's decision
                var key = Console.ReadLine()!;
                if (key.ToLower() == "x") // Exit game
                {
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    Environment.Exit(0);
                }
                else if (key.ToLower() == "c") // Continue playing
                {
                    Console.WriteLine("Great! Let's play again!");
                }
                else
                {
                    Console.WriteLine("Invalid input. Continuing by default.");
                }
            }
            else
            {
                Console.WriteLine($"Oops! You entered the wrong number. The correct number was {theNumber}. Do you want to give it another try or exit the game? For another try, press 'a'. To exit, press 'x'.");

                // Get the user's decision
                var key = Console.ReadLine()!;
                if (key.ToLower() == "x") // Exit game
                {
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    Environment.Exit(0);
                }
                else if (key.ToLower() == "a") // Try again
                {
                    Console.WriteLine("Okay, let's try again!");
                }
                else
                {
                    Console.WriteLine("Invalid input. Continuing by default.");
                }
            }
        }
    }
}
