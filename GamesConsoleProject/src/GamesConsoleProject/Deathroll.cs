using System;

namespace GamesConsoleProject
{
    public class Deathroll : Game
    {
        public Deathroll(string name) : base(name)
        {
            gameName = "Deathroll";
        }

        public override void Play(double wantsToPlay)
        {
            Random randomNum = new Random();
            userScore = 0;
            computerScore = 0;

            while (true)
            {
                Console.WriteLine($"Current Score - {userName}: {userScore}, Computer: {computerScore}.");
                Console.WriteLine("Please input the number at which you wish to start rolling down from, or the character 'q' to quit:");
                var deathrollStart = Console.ReadLine();

                if (int.TryParse(deathrollStart, out int result))
                {
                    if (result > 0)
                    {
                        Console.WriteLine($"Deathrolling between 1 - {result}.");
                        var playerStart = result;
                        var cpuStart = result;
                        int counter;

                        while (result >= 1)
                        {
                            counter = playerStart;
                            playerStart = randomNum.Next(1, playerStart + 1);
                            var playerCheck = playerStart;
                            Console.WriteLine($"{userName} rolls {playerCheck} (1 - {counter}).");
                            if (playerCheck == 1)
                            {
                                Console.WriteLine($"{userName} loses!");
                                computerScore++;
                                break;
                            }
                            counter = playerStart;
                            cpuStart = randomNum.Next(1, playerStart + 1);
                            var cpuCheck = cpuStart;
                            Console.WriteLine($"Computer rolls {cpuCheck} (1 - {counter}).");
                            if (cpuCheck == 1)
                            {
                                Console.WriteLine($"Computer loses!");
                                userScore++;
                                break;
                            }
                            playerStart = cpuStart;                           
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                else if (string.Equals(deathrollStart, "q", StringComparison.OrdinalIgnoreCase))
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