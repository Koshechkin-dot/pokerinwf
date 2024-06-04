using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public class NonCombinationChecker : CombinationChecker<NonCombinationCheckerResult>
    {
        public override NonCombinationCheckerResult? Check(Player player)
        {
            var values = ConvertToValues(player);
            return new(values.Max());
        }
    }
}
