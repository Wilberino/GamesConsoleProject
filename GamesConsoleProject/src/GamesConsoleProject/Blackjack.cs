using System;
using System.Collections.Generic;

namespace GamesConsoleProject
{
    public class Blackjack : Game
    {
        
        // Here is where the game will be called and played.
        // Concept is generate the deck using a DeckGeneration method, which constructs cards into a deck from enums in Card class (Deck and Card classes handle this).
        // Blackjack class will handle playing the game - intialize the deck structure, deal a hand to player and CPU (dealer), and display their values and hand total.
        // Then, Blackjack class will handle the actual 'commands' - being able to hit or stay - and the results (in an enum?) i.e. WIN, BUST, BLACKJACK.

        // NOTE: Ace is handled as 1 in this first build - figure out how to prompt the player to select 1 or 11 later.

        // Things to do:
        // Create a Deck class which will handle creation of a deck of cards, and the order in which those cards appear are stored.
            // - Deck class needs a hand generation method, a 'hit' method (draw a card)
        // Create the actual Blackjack class that will handle playing the game.

        // Give the enums their own files.
        // ReplaceDeck inside the constructor 

        private static BlackjackDeck deck = new BlackjackDeck();
        private static BlackjackPlayer player = new BlackjackPlayer();

        public Blackjack(string name) : base(name) 
        {
            gameName = "Blackjack";
        }

        public override void Play(double wantsToPlay)
        {
            Console.WriteLine("Welcome to Blackjack!");
            deck.StartGame();
            player.Hand = deck.Deal();
            
            Console.WriteLine($"Your hand is:");
            foreach (BlackjackCard card in player.Hand)
            {
                card.CardDescription();
            }

        }
    }
}