using System;
using System.Collections.Generic;

namespace GamesConsoleProject
{
    public class BlackjackCard
    {
        public CardSuit Suit { get; }
        public CardFace Face { get; }
        public int CardValue { get; set; }

        public BlackjackCard(CardSuit suit, CardFace face)
        {
            Suit = suit;
            Face = face;

            switch (Face)
            {
                case CardFace.Ten:
                case CardFace.Jack:
                case CardFace.Queen:
                case CardFace.King:
                    CardValue = 10;
                    break;
                case CardFace.Ace:
                    CardValue = 1;
                    break;
                default:
                    CardValue = (int)Face + 1;
                    break;
            }
        }

        public void CardDescription()
        {
            Console.WriteLine($"{Face} of {Suit}");
        }
    }
}