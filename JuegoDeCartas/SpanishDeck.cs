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
        public int CardsPerRound = 4;
        private string[] ValidSuit = { "Bastos", "Copas", "Oro", "Espadas" };
        private int[] ValidNumber = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        public Player?[] Winners = { null, null, null, null};
        public SpanishDeck(DeckCreator deckCreator)
        {
            Cards = deckCreator.CreateDeck(ValidSuit, ValidNumber);
        }
        
        public override void CheckWinners(List<Player> PlayerList)
        {
            CheckKings(PlayerList);
            CheckAs(PlayerList);
        }
        public void CheckAs(List<Player> PlayerList)
        {
            Player actualWinner = new Player("");
            foreach (Player p in PlayerList)
            {
                if (p.CardPack.Where(c => c.Number == 1 || c.Number == 2).Count() > actualWinner.CardPack.Where(c => c.Number == 1 || c.Number == 2).Count()) actualWinner = p;
                else if (p.CardPack.Where(c => c.Number == 1 || c.Number == 2).Count() == actualWinner.CardPack.Where(c => c.Number == 1 || c.Number == 2).Count())
                {
                    actualWinner = CheckSmall(actualWinner, p, 3);
                }
            }
            Winners[1] = actualWinner;
            Console.WriteLine("Pequeñas: " + actualWinner.Name);
        }
        public Player CheckSmall(Player p1, Player p2, int n)
        {
            int p1Size = p1.CardPack.Where(c => c.Number == n).Count();
            int p2Size = p2.CardPack.Where(c => c.Number == n).Count();

            if (p1Size == p2Size && n < 12)
            {
                return CheckBig(p1, p2, n + 1);
            }
            else if (n == 1)
            {
                return p1;
            }
            else
            {
                return p1Size < p2Size ? p1 : p2;
            }
        }
        public Player CheckBig(Player p1, Player p2, int n)
        {
            int p1Size = p1.CardPack.Where(c => c.Number == n).Count();
            int p2Size = p2.CardPack.Where(c => c.Number == n).Count();
            
            if (p1Size == p2Size && n > 1)
            {
                return CheckBig(p1, p2, n-1);
            } else if (n == 1) {
                return p1;
            } else
            {
                return p1Size > p2Size ? p1 : p2;
            }
        }
        public void CheckGame(List<Player> PlayerList)
        {

        }

        public void CheckKings(List<Player> PlayerList)
        {
            Player actualWinner = new Player("");
            foreach(Player p in PlayerList)
            {
                if (p.CardPack.Where(c => c.Number == 12 || c.Number == 3).Count() > actualWinner.CardPack.Where(c => c.Number == 12 || c.Number == 3).Count()) actualWinner = p;
                else if (p.CardPack.Where(c => c.Number == 12 || c.Number == 3).Count() == actualWinner.CardPack.Where(c => c.Number == 12 || c.Number == 3).Count())
                {
                    actualWinner = CheckBig(actualWinner, p, 11);
                }
            }
            Winners[0] = actualWinner;
            Console.WriteLine("Reyes: " + actualWinner.Name);
        }

    }
}
