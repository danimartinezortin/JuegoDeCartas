using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal interface IDeckCreator
    {
        public List<Card> CreateDeck(string[] suit, int[] numbers);
    }
}
