using System.Drawing;

Random rnd = new Random();
int correctNum = rnd.Next(1, 101);
bool playAgain = false;
int attempts = 0;
Console.WriteLine(correctNum);
while (playAgain = true)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Guess a number (1-100): ");
    string input = Console.ReadLine();
    bool isValid = int.TryParse(input, out int playerNumber);
    attempts++;
    Console.ResetColor();

    if (isValid)
    {
        if (playerNumber == correctNum)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You guessed it with {attempts} attempts!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Do you want to play again? Press [Y] to restart the game and [N] to exit!");
            Console.ForegroundColor = ConsoleColor.Black;
            char restart = char.Parse(Console.ReadLine());   // determines whether to restart the game or not
            while ((restart != 'y' || restart != 'Y') && (restart != 'n' || restart != 'N'))
            {
                Console.ResetColor();
                switch (restart)
                {
                    case 'y':
                    case 'Y':
                        playAgain = true;
                        break;
                    case 'n':
                    case 'N':
                        playAgain = false;
                        Console.WriteLine("See you soon! :)");
                        return;
                    default:
                        Console.Write("Try again...");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }
                if (playAgain == true)   // brakes the while loop after the player press [y] and startin a new game
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                }
            }
        }
        else if (playerNumber > correctNum)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Too High");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Too Low");
        }

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input.");
    }
}
