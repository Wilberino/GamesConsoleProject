using System;

namespace GamesConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Games Den!\nWhat's your name?");
                var userName = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Hi {userName}! Please choose a game from the list below by providing its respective number, or the character 'q' to quit!");
                        Console.WriteLine("1. Rock Paper Scissors.\n2. Deathroll.\n3. Blackjack.");
                        var input = Console.ReadLine();

                        if (int.TryParse(input, out int result))
                        {
                            while (true)
                            {
                                if (result == 1)
                                {
                                    var game = new RockPaperScissors(userName);
                                    try
                                    {
                                        var wantsToPlay = game.PlayCheck();
                                        if (!wantsToPlay)
                                        {
                                            Console.WriteLine("Chickened out huh? Smart choice!");
                                            break;
                                        }
                                        else
                                        {
                                            game.Play(result);
                                            break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        Console.WriteLine("Oops, sorry I didn't quite catch that - could you try again?");
                                        break;
                                    }
                                }
                                else if (result == 2)
                                {
                                    var game = new Deathroll(userName);
                                    try
                                    {
                                        var wantsToPlay = game.PlayCheck();
                                        if (!wantsToPlay)
                                        {
                                            Console.WriteLine("Chickened out huh? Smart choice!");
                                            break;
                                        }
                                        else
                                        {
                                            game.Play(result);
                                            break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        Console.WriteLine("Oops, sorry I didn't quite catch that - could you try again?");
                                        break;
                                    }
                                }
                                else if (result == 3)
                                {
                                    var game = new Blackjack(userName);
                                    try
                                    {
                                        var wantsToPlay = game.PlayCheck();
                                        if (!wantsToPlay)
                                        {
                                            Console.WriteLine("Chickened out huh? Smart choice!");
                                            break;
                                        }
                                        else
                                        {
                                            game.Play(result);
                                            break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        Console.WriteLine("Oops, sorry I didn't quite catch that - could you try again?");
                                        break;
                                    }
                                }
                                else
                                {
                                    throw new ArgumentException();
                                }
                            }
                        }
                        else if (string.Equals(input, "q", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("We hope you had fun! See you again soon!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            throw new ArgumentException();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Oops, sorry I didn't quite catch that - could you try again?");
                        continue;
                    }
                }
            }
        }
    }
}



