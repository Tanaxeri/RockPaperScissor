using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = 10; // number of rounds to play
            int playerScore = 0;
            int computerScore = 0;
            int ties = 0;

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("You will be playing against the computer for " + rounds + " rounds.");
            Console.WriteLine("Please choose rock, paper, or scissors.");

            for (int i = 1; i <= rounds; i++)
            {
                Console.WriteLine("Round " + i + ":");
                string playerChoice = GetPlayerChoice();
                int computerChoice = GetComputerChoice();

                Console.WriteLine("Computer chooses " + GetChoiceName(computerChoice));

                int result = DetermineResult(playerChoice, computerChoice);

                if (result == 1)
                {
                    Console.WriteLine("You win!");
                    playerScore++;
                }
                else if (result == -1)
                {
                    Console.WriteLine("Computer wins!");
                    computerScore++;
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                    ties++;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Game over!");
            Console.WriteLine("You won " + playerScore + " times.");
            Console.WriteLine("The computer won " + computerScore + " times.");
            Console.WriteLine("There were " + ties + " ties.");

            if (playerScore > computerScore)
            {
                Console.WriteLine("Congratulations, you win!");
            }
            else if (playerScore < computerScore)
            {
                Console.WriteLine("Sorry, you lose!");
            }
            else
            {
                Console.WriteLine("It's a tie game!");
            }

            Console.ReadLine();
        }

        static string GetPlayerChoice()
        {
            while (true)
            {
                Console.Write("Enter your choice (rock, paper, scissors): ");
                string choice = Console.ReadLine();

                if (choice == "rock" || choice == "paper" || choice == "scissors")
                {
                    return choice;
                }

                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        static int GetComputerChoice()
        {
            Random random = new Random();
            return random.Next(3);
        }

        static string GetChoiceName(int choice)
        {
            switch (choice)
            {
                case 0:
                    return "rock";
                case 1:
                    return "paper";
                case 2:
                    return "scissors";
                default:
                    return "";
            }
        }

        static int DetermineResult(string playerChoice, int computerChoice)
        {
            if (playerChoice == "rock")
            {
                if (computerChoice == 0)
                {
                    return 0;
                }
                else if (computerChoice == 1)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else if (playerChoice == "paper")
            {
                if (computerChoice == 0)
                {
                    return 1;
                }
                else if (computerChoice == 1)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (computerChoice == 0)
                {
                    return -1;
                }
                else if (computerChoice == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
