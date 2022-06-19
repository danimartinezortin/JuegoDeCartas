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
        public T Deck { get; set; }

        public Game(List<Player> playerList, T deck)
        {
            PlayerList = playerList;
            Deck = deck;
        }
    }
}
