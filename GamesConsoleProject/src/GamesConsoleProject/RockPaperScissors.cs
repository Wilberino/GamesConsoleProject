using System;

namespace GamesConsoleProject
{
    public class RockPaperScissors : Game
    {
        public RockPaperScissors(string name) : base(name) 
        {
            gameName = "Rock Paper Scissors";
        }

        public override void Play(double wantsToPlay)
        {
            Random randomNum = new Random();
            string computerMove;
            string userMove;
            userScore = 0;
            computerScore = 0;

            while (true)
            {
                Console.WriteLine($"Current Score - {userName}: {userScore}, Computer: {computerScore}.");
                Console.WriteLine("Please choose a move by inputting its corresponding number, or the character 'q' to quit:\n1. Rock\n2. Paper\n3. Scissors");
                var userMoveInt = Console.ReadLine();

                if (int.TryParse(userMoveInt, out int result))
                {
                    while (true)
                    {
                        var computerMoveInt = randomNum.Next(1, 4);
                        if (result == 1)
                        {
                            userMove = "Rock";
                            if (computerMoveInt == 1)
                            {
                                computerMove = "Rock";
                                Console.WriteLine($"You played {userMove}. Computer plays {computerMove}. It's a draw!");
                                break;
                            }
                            else if (computerMoveInt == 2)
                            {
                                computerMove = "Paper";
                                Console.WriteLine($"You played {userMove}. Computer plays {computerMove}. You lose!");
                                computerScore++;
                                break;
                            }
                            else if (computerMoveInt == 3)
                            {
                                computerMove = "Scissors";
                                Console.WriteLine($"You played {userMove}. Computer plays {computerMove}. You win!");
                                userScore++;
                                break;
                            }
                        }
                        else if (result == 2)
                        {
                            userMove = "Paper";
                            if (computerMoveInt == 1)
                            {
                                computerMove = "Rock";
                                Console.WriteLine($"You played {userMove}. Computer plays {computerMove}. You win!");
                                userScore++;
                                break;
                            }
                            else if (computerMoveInt == 2)
                            {
                                computerMove = "Paper";
                                Console.WriteLine($"You played {userMove}. Computer plays {computerMove}. It's a draw!");
                                break;
                            }
                            else if (computerMoveInt == 3)
                            {
                                computerMove = "Scissors";
                                Console.WriteLine($"You played {userMove}. Computer plays {computerMove}. You lose!");
                                computerScore++;
                                break;
                            }
                        }
                        else if (result == 3)
                        {
                            userMove = "Scissors";
                            if (computerMoveInt == 1)
                            {
                                computerMove = "Rock";
                                Console.WriteLine($"You played {userMove}. Computer plays {computerMove}. You lose!");
                                computerScore++;
                                break;
                            }
                            else if (computerMoveInt == 2)
                            {
                                computerMove = "Paper";
                                Console.WriteLine($"You played {userMove}. Computer plays {computerMove}. You win!");
                                userScore++;
                                break;
                            }
                            else if (computerMoveInt == 3)
                            {
                                computerMove = "Scissors";
                                Console.WriteLine($"You played {userMove}. Computer plays {computerMove}. It's a draw!");
                                break;
                            }
                        }
                    }
                }
                else if (string.Equals(userMoveInt, "q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}