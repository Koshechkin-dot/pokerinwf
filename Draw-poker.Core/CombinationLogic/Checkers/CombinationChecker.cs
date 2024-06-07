using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public abstract class CombinationChecker<T> : ICombinationChecker where T : CheckerResult
    {
        public abstract CheckerResult? Check(Player player);

        protected List<CardValue> ConvertToValues(Player player)
        {
            var hand = player.Cards;
            List<CardValue> values = new List<CardValue>();
            foreach (Card card in hand)
            {
                values.Add(card.Value);
            }
            return values;
        }
        protected List<CardSuit> ConvertToSuits(Player player)
        {
            var hand = player.Cards;
            List<CardSuit> suits = new List<CardSuit>();
            foreach (Card card in hand)
            {
                suits.Add(card.Suit);
            }
            return suits;
        }
    }
}
