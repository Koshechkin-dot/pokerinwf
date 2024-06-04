namespace Draw_poker.Core.CombinationLogic.CheckerResults
{
    public abstract class CheckerResult : IComparable<CheckerResult>
    {
        public abstract int CompareTo(CheckerResult? other);
        
    }
}
