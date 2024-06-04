using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public abstract class CombinationChecker<T> where T : CheckerResult
    {
        public abstract T? Check(Player player);

        protected List<CardValue> ConvertToValues(Player player)
        {
            var hand = player.GetCards();
            List<CardValue> values = new List<CardValue>();
            foreach (Card card in hand)
            {
                values.Add(card.Value);
            }
            return values;
        }
        protected List<CardSuit> ConvertToSuits(Player player)
        {
            var hand = player.GetCards();
            List<CardSuit> suits = new List<CardSuit>();
            foreach (Card card in hand)
            {
                suits.Add(card.Suit);
            }
            return suits;
        }
    }
}
