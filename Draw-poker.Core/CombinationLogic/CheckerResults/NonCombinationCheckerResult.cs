using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Core.CombinationLogic.CheckerResults
{
    public class NonCombinationCheckerResult : CheckerResult
    {
        public CardValue Value { get; }
        public NonCombinationCheckerResult(CardValue value)
        {
            Value = value;
        }
        public override int CompareTo(CheckerResult? other)
        {
            if(other == null) return 1;
            var cast = other as NonCombinationCheckerResult;
            if (Value > cast.Value) return 1;
            if (Value < cast.Value) return -1;
            return 0;
        }
    }
}
