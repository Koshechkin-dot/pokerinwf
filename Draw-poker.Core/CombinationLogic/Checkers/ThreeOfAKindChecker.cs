using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    internal class ThreeOfAKindChecker : CombinationChecker<ThreeOfAKindCheckerResult>
    {
        public override ThreeOfAKindCheckerResult? Check(Player player)
        {
            var hand = player.GetCards();
            int? triple = hand.GroupBy(card => card.Value)
                              .Where(group => group.Count() == 3)
                              .Select(group => (int?)group.Key)
                              .FirstOrDefault();
            if(triple.HasValue)
            {
                return new((CardValue) triple);
            }
            return null;
        }
    }
}
