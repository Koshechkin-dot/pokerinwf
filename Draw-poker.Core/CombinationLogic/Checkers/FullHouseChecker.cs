using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public class FullHouseChecker : CombinationChecker<FullHouseCheckerResult>
    {
        public override FullHouseCheckerResult? Check(Player player)
        {
            if (player.Cards.Count == 0) { return null; }
            var hand = player.Cards;
            int? triple = hand.GroupBy(card => card.Value)
                              .Where(group => group.Count() == 3)
                              .Select(group => (int?)group.Key)
                              .FirstOrDefault();

            if (triple.HasValue)
            {
                int? pair = hand.GroupBy(card => card.Value)
                                .Where(group => group.Count() == 2)
                                .Select(group => (int?)group.Key)
                                .FirstOrDefault();

                if (pair.HasValue)
                {
                    return new((CardValue)triple, (CardValue)pair);
                }
            }

            return null;
        }
    }
}
