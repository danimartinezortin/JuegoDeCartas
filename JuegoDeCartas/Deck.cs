using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal class Deck
    {
        public List<Card> Cards = new List<Card>();
        public void ShuffleDeck()
        {
            Random rnd = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int n = rnd.Next(0, Cards.Count - 1);
                Card swap = Cards[n];
                Cards[n] = Cards[i];
                Cards[i] = swap;
            }
        }
    }
}
