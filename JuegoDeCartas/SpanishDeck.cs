using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuegoDeCartas;
namespace JuegoDeCartas
{
    internal class SpanishDeck : Deck
    {
        private string[] ValidSuit = { "Bastos", "Copas", "Oro", "Espadas" };
        private int[] ValidNumber = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        public SpanishDeck(DeckCreator deckCreator)
        {
            Cards = deckCreator.CreateDeck(ValidSuit, ValidNumber);
        }
    }
}
