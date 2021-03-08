using System;

namespace GamesConsoleProject
{
    public abstract class Game : IGame
    {
        public static string userName { get; set; }
        public string gameName { get; set; }
        public int userScore { get; set; }
        public int computerScore { get; set; }
        public Game(string name)
        {
            userName = name;
        }
        public virtual void Play(double move)
        {
            throw new NotImplementedException();
        }

        public virtual bool PlayCheck()
        {
            Console.WriteLine($"You want to play {gameName}? (Yes / No)");
            var checkInput = Console.ReadLine();
            if (string.Equals(checkInput, "Yes", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else if (string.Equals(checkInput, "No", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}