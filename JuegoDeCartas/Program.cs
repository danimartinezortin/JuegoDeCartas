using JuegoDeCartas;

SpanishDeck deck= new SpanishDeck(new DeckCreator());
List<Player> players= new List<Player>();
for(int i = 0; i < 4; i++)
{
    
    players.Add(new Player("Player " + i));
}

Game<SpanishDeck> game = new Game<SpanishDeck>(players, deck);