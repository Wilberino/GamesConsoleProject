using System;

namespace GamesConsoleProject
{
    public interface IGame
    {
        bool PlayCheck();

        void Play(double move);
    }
}