using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Core.Game
{
    public class Player
    {
        public const int MAX_CARDS_IN_HAND = 5;
        public int Cash { get; set; }
        public int Bet { get; set; }
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
        public void ReplaceCard(Card card, int index)
        {
            cards.Remove(cards[index]);
            cards.Insert(index, card);
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
        public void Fold()
        {
            cards.Clear();
            Bet = 0;
        }
        public bool Call(int _bet)
        {
            if (_bet <= Cash)
            {
                Cash -= (_bet - Bet);
                Bet = _bet;
                return true;
            }
            return false;
        }
        public bool Raise(ref GameProcess gp, int _new_bet)
        {
            if (_new_bet <= Cash && _new_bet > Bet)
            {
                Cash -= (_new_bet - Bet);
                gp._bet = _new_bet;
                Bet = _new_bet;
                return true;
            }
            return false;
        }
        // Для Ботов
        public void Action(ref GameProcess gp, int _new_bet)
        {
            Random random = new Random();
            if (random.Next(0, 100) % 2 == 1)
            {
                Raise(ref gp, _new_bet + 10);
            }
            else
            {
                Call(_new_bet);
            }
            if (!Call(_new_bet))
            {
                Fold();
            }
        }
        
    }
}
