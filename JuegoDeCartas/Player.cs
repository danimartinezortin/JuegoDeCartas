using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal class Player
    {
        public string Name { get; set; }
        public List<Card> CardPack = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }
    }
}
