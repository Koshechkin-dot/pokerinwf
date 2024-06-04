using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Core.CombinationLogic.CheckerResults
{
    public class FourOfAKindCheckerResult : CheckerResult
    {
        public CardValue Value { get; }
        public override int CompareTo(CheckerResult? other)
        {
            if (other == null) return 1;

            var cast = (FourOfAKindCheckerResult) other;
            if(Value > cast.Value)
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

        public FourOfAKindCheckerResult(CardValue cardValue)
        {
            Value = cardValue;
        }
    }
}
