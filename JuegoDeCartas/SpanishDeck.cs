using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuegoDeCartas;
namespace JuegoDeCartas
{
    internal class SpanishDeck : ISpanishDeck
    {
        public List<Card> Cards;
        private string[] ValidSuit = { "Bastos", "Copas", "Oro", "Espadas" };
        private int[] ValidNumber = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        private IDeckCreator DeckCreator;
        public SpanishDeck()
        {
            Cards = CreateDeck(ValidSuit, ValidNumber);

        }
        public void ShuffleDeck()
        {
            Random rnd = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int n = rnd.Next(0, Cards.Count-1);
                Card swap = Cards[n];
                Cards[n] = Cards[i];
                Cards[i] = swap;
            }
        }

        public List<Card> CreateDeck(string[] suit, int[] numbers)
        {
            List<Card> cards = new List<Card>();
            foreach (string s in suit)
            {
                foreach (int n in numbers) cards.Add(new Card(s, n));
            }
            return cards;
        }

    }
}
