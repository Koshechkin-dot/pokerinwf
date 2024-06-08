using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public class StraightFlushChecker : CombinationChecker<StraightFlushCheckerResult>
    {
        public override StraightFlushCheckerResult? Check(Player player)
        {
            if (player.Cards.Count == 0) { return null; }
            var hand = player.Cards;
            CardSuit suit = hand[0].Suit;
            if (hand.Count(cards => cards.Suit == suit) == 5)
            {
                var values = ConvertToValues(player);
                int min = (int)values.Min();
                for (int i = min; i < min + 5; i++)
                {
                    if (!values.Contains((CardValue)i))
                    {
                        return null;
                    }
                }
                return new(values.Min());
            }
            return null;
        }
    }
}
