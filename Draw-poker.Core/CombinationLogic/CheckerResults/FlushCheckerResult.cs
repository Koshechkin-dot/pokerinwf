using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Core.CombinationLogic.CheckerResults
{
    public class FlushCheckerResult : CheckerResult
    {
        public List<CardValue> Values { get; }
        public FlushCheckerResult(List<CardValue> values)
        {
            Values = values;
        }
        public override int CompareTo(CheckerResult? other)
        {
            if(other == null) return 1;
            var cast = other as FlushCheckerResult;
            var otherValues = cast?.Values.Order().ToList();
            var values = Values?.Order().ToList();
            for(int i = 4; i > -1; i--)
            {
                if (values[i] > otherValues[i]) return 1;
                if (values[i] < otherValues[i]) return -1;
            }
            return 0;
        }
    }
}
