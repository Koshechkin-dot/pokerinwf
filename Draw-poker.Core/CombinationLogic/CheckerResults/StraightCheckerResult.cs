using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Core.CombinationLogic.CheckerResults
{
    public class StraightCheckerResult : CheckerResult
    {
        public CardValue Value { get; }
        public StraightCheckerResult(CardValue value) 
        {
            Value = value;
        }

        public override int CompareTo(CheckerResult? other)
        {
            if (other == null) return 1;
            var cast = (StraightFlushCheckerResult)other;
            if (Value > cast.Value)
            {
                return 1;
            }
            else if (Value < cast.Value)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
