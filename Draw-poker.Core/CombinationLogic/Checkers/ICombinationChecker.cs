using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public interface ICombinationChecker
    {
        CheckerResult? Check(Player player);
    }
}
