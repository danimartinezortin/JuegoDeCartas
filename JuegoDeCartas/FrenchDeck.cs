using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuegoDeCartas;
namespace JuegoDeCartas
{
    internal class FrenchDeck : IFrenchDeck
    {
        public List<Card> Cards;
        public void ShuffleDeck()
        {
            Random rnd = new Random();
            Cards = (List<Card>)Cards.OrderBy(item => rnd.Next());
        }
    }
}
