using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    internal class StraightChecker : CombinationChecker<StraightCheckerResult>
    {
        public override StraightCheckerResult? Check(Player player)
        {
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
