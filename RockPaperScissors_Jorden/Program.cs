namespace RockPaperScissors_Jorden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] options = { "Rock", "Paper", "Scissors", "Spock", "Lizard" };
            int playerRounds = 0;
            int computerRounds = 0;
            bool gameIsRunning = true;
            while (gameIsRunning)
            {
                while (playerRounds <= 5 && computerRounds <= 5)
                {
                    Console.WriteLine("Please type either Rock, Paper, Scissors, Spock, or Lizard");
                    Console.WriteLine("The computer will also pick one.");
                    Console.WriteLine("Whoever gets to five wins, win the whole game.");
                    string? userInput = Console.ReadLine();
                    Random random = new Random();
                    int computer = random.Next(1, 5);
                    switch (computer)
                    {
                        case 1:
                            Console.WriteLine("The computer has chosen Rock");
                            if (userInput == options[1] || userInput == options[3])
                            {
                                Console.WriteLine("You won this round.");
                                playerRounds++;
                                Console.WriteLine("User has won " + playerRounds + " round");
                            }
                            else if (userInput == options[2] || userInput == options[4])
                            {
                                Console.WriteLine("You lost.");
                                computerRounds++;
                                Console.WriteLine("Computer has won " + computerRounds + " round");
                            }
                            else
                            {
                                Console.WriteLine("You tied.");
                            }
                            break;
                        case 2:
                            Console.WriteLine("The computer has chosen Paper");
                            if (userInput == options[0] || userInput == options[3])
                            {
                                Console.WriteLine("You lost.");
                                computerRounds++;
                                Console.WriteLine("Computer has won " + computerRounds + " round");
                            }
                            else if (userInput == options[2] || userInput == options[4])
                            {
                                Console.WriteLine("You won this round");
                                playerRounds++;
                                Console.WriteLine("Player has won " + playerRounds + " round");
                            }
                            else
                            {
                                Console.WriteLine("You tied");
                            }
                            break;
                        case 3:
                            Console.WriteLine("The computer has chosen Scissors");
                            if (userInput == options[0] || userInput == options[3])
                            {
                                Console.WriteLine("You won this round");
                                playerRounds++;
                                Console.WriteLine("Player has won " + playerRounds + " round");
                            }
                            else if (userInput == options[1] || userInput == options[4])
                            {
                                Console.WriteLine("You lost.");
                                computerRounds++;
                                Console.WriteLine("Computer has won " + computerRounds + " round");
                            }
                            else
                            {
                                Console.WriteLine("You tied");
                            }
                            break;

                        case 4:
                            Console.WriteLine("The computer has chosen Spock");
                            if (userInput == options[0] || userInput == options[2])
                            {
                                Console.WriteLine("You lost");
                                computerRounds++;
                                Console.WriteLine("Computer has won " + computerRounds + " round");
                            }
                            else if (userInput == options[1] || userInput == options[4])
                            {
                                Console.WriteLine("You won this round");
                                playerRounds++;
                                Console.WriteLine("Player has won " + playerRounds + " round");
                            }
                            else
                            {
                                Console.WriteLine("You tied");
                            }
                            break;
                        case 5:
                            Console.WriteLine("The computer has chosen Lizard");
                            if (userInput == options[0] || userInput == options[2])
                            {
                                Console.WriteLine("You won this round");
                                playerRounds++;
                                Console.WriteLine("Player has won " + playerRounds + " round");
                            }
                            else if (userInput == options[1] || userInput == options[3])
                            {
                                Console.WriteLine("You lost");
                                computerRounds++;
                                Console.WriteLine("Computer has won " + computerRounds + " round");
                            }
                            else
                            {
                                Console.WriteLine("You tied");
                            }
                            break;
                        default:
                            Console.WriteLine("Invaild answer");
                            break;
                    }
                }
            }
        }
    }
}
