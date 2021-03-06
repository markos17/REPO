﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch8GoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;
        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = Name;
            this.cards = new Deck(new Card[] { });
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            textBoxOnForm.Text += name + " has just joined the hame " + Environment.NewLine;

            // The constructor for the Player class initializes four private fields, and then
            // adds a line to the TextBox control on the form that says, "Joe has just
            // joined the game"—but use the name in the private field, and don't forget to
            // add a line break at the end of every line you add to the TextBox.
        }
        public IEnumerable<Value> PullOutBooks()
        {
            List<Value> books = new List<Value>();
            for (int i = 1; i <= 13; i++)
            {
                Value value = (Value)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }

        public Value GetRandomValue()
        {
            // This method gets a random value—but it has to be a value that's in the deck!
            return cards.Peek(random.Next(cards.Count)).Value;
        }
        public Deck DoYouHaveAny(Value value)
        {
            // This is where an opponent asks if I have any cards of a certain value
            // Use Deck.PullOutValues() to pull out the values. Add a line to the TextBox
            // that says, "Joe has 3 sixes"—use the new Card.Plural() static method
            Deck cardsIHave = cards.PullOutValues(value);
            textBoxOnForm.Text = Name + " has " + cardsIHave.Count + " " + Card.Plural(value) + Environment.NewLine;
            return cardsIHave;
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            // Here's an overloaded version of AskForACard()—choose a random value
            // from the deck using GetRandomValue() and ask for it using AskForACard()
            //AskForACard(players, myIndex, stock, GetRandomValue());
            if(stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.Add(stock.Deal());
                Value randomValue = GetRandomValue();
                AskForACard(players, myIndex, stock, randomValue);
                if (stock.Count > 0 && players[0].CardCount == 0)
                    players[0].cards.Add(stock.Deal());
            }
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Value value)
        {
            // Ask the other players for a value. First add a line to the TextBox: "Joe asks
            // if anyone has a Queen". Then go through the list of players that was passed in
            // as a parameter and ask each player if he has any of the value (using his
            // DoYouHaveAny() method). He'll pass you a deck of cards—add them to my deck.
            // Keep track of how many cards were added. If there weren't any, you'll need
            // to deal yourself a card from the stock (which was also passed as a parameter),
            // and you'll have to add a line to the TextBox: "Joe had to draw from the stock"
            textBoxOnForm.Text = name + " asks if anyone has a " + value + Environment.NewLine;
            int totalCardGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck cardGiven = player.DoYouHaveAny(value);
                    totalCardGiven += cardGiven.Count;
                    while (cardGiven.Count > 0)
                        cards.Add(cardGiven.Deal());
                }
            }

            if (totalCardGiven == 0 && stock.Count > 0)
            {
                textBoxOnForm.Text = name + " must draw from the stock " + Environment.NewLine;
                cards.Add(stock.Deal());
            }
        }
        // Here's a property and a few short methods that were already written for you
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardsNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
}
