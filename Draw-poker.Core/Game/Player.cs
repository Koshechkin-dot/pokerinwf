using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Core.Game
{
    public class Player
    {
        public const int MAX_CARDS_IN_HAND = 5;
        public int Cash { get; set; }
        private List<Card> cards;

        public Player(int cash)
        {
            cards = new List<Card>(MAX_CARDS_IN_HAND);
            this.Cash = cash;
        }
        public void AddCard(Card card)
        {
            if (cards.Count >= MAX_CARDS_IN_HAND)
            {
                throw new ArgumentOutOfRangeException("Can't add card to full hand");
            }
            cards.Add(card);
        }
        public List<Card> GetCards()
        {
            return new List<Card>(cards);
        }
        public List<CardValue> GetCardValues()
        {
            List<CardValue> values = new List<CardValue>();
            foreach (Card card in cards)
            {
                values.Add(card.Value);
            }
            return values;
        }
        public List<CardSuit> GetCardSuits()
        {
            List<CardSuit> suits = new List<CardSuit>();
            foreach (Card card in cards)
            {
                suits.Add(card.Suit);
            }
            return suits;
        }
    }
}
