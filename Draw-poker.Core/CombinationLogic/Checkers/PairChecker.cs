using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public class PairChecker : CombinationChecker<PairCheckerResult>
    {
        public override PairCheckerResult? Check(Player player)
        {
            if (player.Cards.Count == 0) { return null; }
            var hand = player.Cards;
            var pairs = hand.GroupBy(card => card.Value);
            List<CardValue> cards = new List<CardValue>();
            if (pairs.Count() == 2)
            {
                cards = pairs.Select(v => v.Key).ToList();
            }
            if (cards.Any())
            {
                return new(cards[0]);
            }
            return null;
        }
    }
}
