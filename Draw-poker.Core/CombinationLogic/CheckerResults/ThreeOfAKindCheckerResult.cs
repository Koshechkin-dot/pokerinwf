using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Core.CombinationLogic.CheckerResults
{
    public class ThreeOfAKindCheckerResult : CheckerResult
    {
        public CardValue CardValue { get; }
        public ThreeOfAKindCheckerResult(CardValue cardValue)
        {
            CardValue = cardValue;
        }
        public override int CompareTo(CheckerResult? other)
        {
            if(other == null) return 1;
            var cast = other as ThreeOfAKindCheckerResult;
            if (CardValue > cast.CardValue) return 1;
            if (CardValue < cast.CardValue) return -1;
            return 0;
        }
    }
}
