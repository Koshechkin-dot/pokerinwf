using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Core.CombinationLogic.CheckerResults
{
    public class FullHouseCheckerResult : CheckerResult
    {
        public CardValue Triple { get; }
        public CardValue Pair { get; }
        public FullHouseCheckerResult(CardValue triple, CardValue pair)
        {
            Triple = triple;
            Pair = pair;
        }
        public override int CompareTo(CheckerResult? other)
        {
            if(other == null) return 1;
            var cast = (FullHouseCheckerResult)other;
            if(Triple > cast.Triple) return 1;
            if(Triple < cast.Triple) return -1;
            if(Pair > cast.Pair) return 1;
            if(Pair < cast.Pair) return -1;
            return 0;
        }
    }
}
