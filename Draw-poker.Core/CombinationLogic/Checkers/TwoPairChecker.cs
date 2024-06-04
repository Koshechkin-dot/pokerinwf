using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    internal class TwoPairChecker : CombinationChecker<TwoPairCheckerResult>
    {
        public override TwoPairCheckerResult? Check(Player player)
        {
            var hand = player.GetCards();
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
