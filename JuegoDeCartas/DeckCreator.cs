using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal class DeckCreator : IDeckCreator
    {
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
