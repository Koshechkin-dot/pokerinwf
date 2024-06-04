namespace Draw_poker.Core.CardsLogic
{
    public class DeckOfCards
    {
        public const int MAX_CARDS_IN_DECK = 52;
        private List<Card> cards;
        private int topPointer;

        public DeckOfCards()
        {
            cards = Create();
            Shuffle();
        }

        private List<Card> Create()
        {
            topPointer = 0;
            cards = new List<Card>(52);
            for(int value = 2; value < 15; value++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    cards.Add(
                        new Card((CardValue)value, (CardSuit)suit)
                        );
                }
            }
            return cards;
        }
        private void Shuffle()
        {
            Random random = new Random();
            for (int i = cards.Count; i > 1; i--)
            {
                int j = random.Next(i);
                var temp = cards[j];
                cards[j] = cards[i - 1];
                cards[i - 1] = temp;
            }
        }

        public Card GetCard()
        {
            if(topPointer < 0 || topPointer >= MAX_CARDS_IN_DECK)
            {
                throw new ArgumentOutOfRangeException("Top Pointer of deck out of range");
            }
            var temp = cards[topPointer];
            cards.RemoveAt(topPointer);
            topPointer++;
            return temp;
        }
    }
}
