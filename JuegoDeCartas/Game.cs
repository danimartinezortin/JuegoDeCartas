using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal class Game<T>
    {
        public List<Player> PlayerList { get; set; }
        public Deck CardDeck { get; set; }

        public Game(List<Player> playerList, Deck deck)
        {
            PlayerList = playerList;
            CardDeck = deck;
            CardDeck.ShuffleDeck();
            Start();
        }

        public void Start()
        {

            GiveCards();

            CardDeck.CheckWinners(PlayerList);

            foreach (Player p in PlayerList)
            {
                foreach (Card c in p.CardPack)
                {
                    Console.WriteLine(p.Name + " " + c.ToString());
                }
            }
        }

        public void GiveCards()
        {
            for (int i = 0; i < 4; i++)
            {
                foreach (Player p in PlayerList)
                {
                    p.CardPack.Add(CardDeck.GiveCard());
                }
            }

        }
    }
}
