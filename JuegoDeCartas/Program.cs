using JuegoDeCartas;

SpanishDeck deck= new SpanishDeck();
foreach(Card c in deck.Cards)
{
    Console.WriteLine(c.ToString());
}

deck.ShuffleDeck();
foreach (Card c in deck.Cards)
{
    Console.WriteLine(c.ToString());
}