namespace Draw_poker.Core.CardsLogic
{
    public class Card
    {
        public CardValue Value { get; }
        public CardSuit Suit { get; }
        public Card(CardValue cardValue, CardSuit cardSuit)
        {
            Value = cardValue;
            Suit = cardSuit;
        }
    }
}


