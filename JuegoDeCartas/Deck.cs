using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal abstract class Deck
    {
        public int CardsPerRound;
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

        public abstract void CheckWinners(List<Player> PlayerList);
        public Card GiveCard()
        {
            for(int i = 0; i < Cards.Count; i++)
            {
                if (Cards[i] != null)
                {
                    Card chosenCard = Cards[i];
                    Cards[i] = null;
                    return chosenCard;
                }
            }
            throw new Exception("Deck is empty");
        }
    }
}
