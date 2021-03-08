using System;
using System.Collections.Generic;

namespace GamesConsoleProject
{
    public class BlackjackDeck
    {
        private List<BlackjackCard> cards;

        public List<BlackjackCard> GenerateDeck()
        {
            List<BlackjackCard> newDeck = new List<BlackjackCard>();

            for (int face = 0; face < 13; face++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    newDeck.Add(new BlackjackCard((CardSuit)suit, (CardFace)face));
                }
            }

            return newDeck;
        }

        public void ShuffleDeck()
        {
            Random random = new Random();

            int count = cards.Count;

            while (count > 1)
            {
                count--;
                int i = random.Next(count + 1);
                BlackjackCard card = cards[i];
                cards[i] = cards[count];
                cards[count] = card;
            }          
        }

        public List<BlackjackCard> Deal()
        {
            List<BlackjackCard> hand = new List<BlackjackCard>();
            hand.Add(cards[0]);
            hand.Add(cards[1]);

            cards.RemoveRange(0, 2);
            return hand;
        }

        public BlackjackCard Hit()
        {
            BlackjackCard card = cards[0];
            cards.Remove(card);

            return card;
        }

        public void StartGame()
        {
            cards = GenerateDeck();
            ShuffleDeck();
        }

    }
}