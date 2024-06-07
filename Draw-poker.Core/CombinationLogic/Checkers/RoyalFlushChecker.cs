using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public class RoyalFlushChecker : CombinationChecker<RoyalFlushCheckerResult>
    {
        public override RoyalFlushCheckerResult? Check(Player player)
        {
            var hand = player.Cards;
            var suit = hand[0].Suit;
            if (hand.Count(cards => cards.Suit == suit) < 5)
            {
                return null;
            }
            List<CardValue> values = ConvertToValues(player);
            if (
                values.Contains(CardValue.Ten) &&
                values.Contains(CardValue.Jack) &&
                values.Contains(CardValue.Queen) &&
                values.Contains(CardValue.King) &&
                values.Contains(CardValue.Ace)
            )
            {
                return new RoyalFlushCheckerResult();
            }
            return null;
        }
    }
}
