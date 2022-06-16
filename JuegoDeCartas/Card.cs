using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal class Card
    {
        public int Number { get; set; }
        public string Suit { get; set; }

        public Card(string suit, int number)
        {
            Number = number;
            Suit = suit;
        }

        public override string ToString()
        {
            return String.Join(" ", Number, Suit);
        }

        public override bool Equals(object? obj)
        {
            return obj is Card card &&
                   Number == card.Number;
        }
    }
}
