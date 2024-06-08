using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public class StraightChecker : CombinationChecker<StraightCheckerResult>
    {
        public override StraightCheckerResult? Check(Player player)
        {
            if (player.Cards.Count == 0) { return null; }
            var values = ConvertToValues(player);
            int min = (int)values.Min();
            for (int i = min; i < min + 5; i++)
            {
                if (!values.Contains((CardValue)i))
                {
                    return null;
                }
            }
            return new(values.Min());
        }
    }
}
