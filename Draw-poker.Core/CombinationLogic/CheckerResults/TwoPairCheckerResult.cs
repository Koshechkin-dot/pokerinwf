using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Core.CombinationLogic.CheckerResults
{
    public class TwoPairCheckerResult : CheckerResult
    {
        public List<CardValue> Values { get; }
        public TwoPairCheckerResult(List<CardValue> values)
        {
            Values = values;
        }
        public override int CompareTo(CheckerResult? other)
        {
            if (other == null) return 1;
            var cast = other as TwoPairCheckerResult;
            var otherValues = cast.Values.Order().ToList();
            var values = Values.Order().ToList();
            if (values[1] > otherValues[1]) return 1;
            if (values[1] < otherValues[1]) return -1;
            if (values[0] > otherValues[0]) return 1;
            if (values[0] < otherValues[0]) return -1;
            return 0;
        }
    }
}
