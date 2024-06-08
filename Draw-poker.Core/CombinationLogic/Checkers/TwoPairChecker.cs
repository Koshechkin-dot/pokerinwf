using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public class TwoPairChecker : CombinationChecker<TwoPairCheckerResult>
    {
        public override TwoPairCheckerResult? Check(Player player)
        {
            if (player.Cards.Count == 0) { return null; }
            var hand = player.Cards;
            var pairs = hand.GroupBy(card => card.Value)
                            .Where(group => group.Count() == 2)
                            .Select(v => v.Key).ToList();
            if (pairs.Any())
            {
                return new(pairs);
            }
            return null;      
        }
    }
}
