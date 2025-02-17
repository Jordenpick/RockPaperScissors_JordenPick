namespace RockPaperScissors_Jorden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] options = { "Rock", "Paper", "Scissors" };
            int rounds = 5;
            bool gameIsRunning = true;
            while (gameIsRunning)
            {
                Console.WriteLine("Please enter either Rock, Paper, Scissors, Spock, or Lizard");
                Console.WriteLine("The computer will also pick one.");
                Console.WriteLine("Whoever gets to five wins, win the whole game.");
                string? userInput = Console.ReadLine();
                Random random = new Random();
                int computer = random.Next(1, 3);
                switch (computer)
                {
                    case 1:

                        Console.WriteLine("The computer has chosen Rock");
                        if (userInput == options[0])
                        {
                            Console.WriteLine("You tied.");
                        }
                        else if (userInput == options[1])
                        {
                            Console.WriteLine("You won this round.");
                        }
                        else
                        {
                            Console.WriteLine("You lost.");
                        }
                        break;
                    case 2:

                        Console.WriteLine("The computer has chosen Paper");
                        if (userInput == options[0])
                        {
                            Console.WriteLine("You lost.");
                        }
                        else if (userInput == options[1])
                        {
                            Console.WriteLine("You tied");
                        }
                        else
                        {
                            Console.WriteLine("You won this round");
                        }
                        break;
                    case 3:
                        Console.WriteLine("The computer has chosen Scissors");
                        if (userInput == options[0])
                        {
                            Console.WriteLine("You won this round");
                        }
                        else if (userInput == options[1])
                        {
                            Console.WriteLine("You lost.");
                        }
                        else
                        {
                            Console.WriteLine("You tied");
                        }
                        break;
                    default:
                        Console.WriteLine("Invaild");
                        break;
                }
            }
        }
    }
}
