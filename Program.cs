using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string PlayerInput;
            string CPUInput;
            int randomInt;
            int scoreCPU = 0;
            int scorePlayer = 0;
            bool playAgain = true;

            while (playAgain)
            {

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.WriteLine("Choose between ROCK, PAPER, SCISSOR:    ");
                    PlayerInput = Console.ReadLine();
                    PlayerInput = PlayerInput.ToUpper();

                    Random random = new Random();

                    randomInt = random.Next(1, 4);


                    switch (randomInt)
                    {

                        case 1:
                            CPUInput = "ROCK";
                            Console.WriteLine("Computer chooses ROCK");
                            if (CPUInput == PlayerInput)
                                Console.WriteLine("Its a DRAW!!");

                            else if (PlayerInput == "PAPER")
                            {
                                Console.WriteLine("You Won");
                                scorePlayer++;
                            }

                            else if (PlayerInput == "SCISSOR")
                            {
                                Console.WriteLine("You loose");
                                scoreCPU++;
                            }



                            break;

                        case 2:
                            CPUInput = "PAPER";

                            Console.WriteLine("Computer chooses PAPER");
                            if (CPUInput == PlayerInput)
                                Console.WriteLine("Its a DRAW!!");

                            else if (PlayerInput == "SCISSOR")
                            {
                                Console.WriteLine("You Won");
                                scorePlayer++;
                            }

                            else if (PlayerInput == "ROCK")
                            {
                                Console.WriteLine("You loose");
                                scoreCPU++;
                            }


                            break;

                        case 3:
                            CPUInput = "SCISSOR";
                            Console.WriteLine("Computer chooses SCISSOR");
                            if (CPUInput == PlayerInput)
                                Console.WriteLine("Its a DRAW!!");

                            else if (PlayerInput == "ROCK")
                            {
                                Console.WriteLine("You Won");
                                scorePlayer++;
                            }

                            else if (PlayerInput == "PAPER")
                            {
                                Console.WriteLine("You loose");
                                scoreCPU++;
                            }

                            else
                            {
                                Console.WriteLine("Invalid Entry");
                            }


                            break;

                        default:
                            Console.WriteLine("Invalid Entry");

                            break;
                    }

                    Console.WriteLine($"Player Score: {scorePlayer} \t Computer Score: {scoreCPU}");

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON");
                }

                else if (scoreCPU == 3)
                {
                    Console.WriteLine("Computer WON");
                }

                Console.WriteLine("Do You want to Play Again (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }

                else if (loop == "n")
                {
                    playAgain = false;
                }

                else
                {
                    playAgain = false;
                }
                    
            }
        }

    }
}