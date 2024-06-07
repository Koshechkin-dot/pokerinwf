using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public class FourOfAKindChecker : CombinationChecker<FourOfAKindCheckerResult>
    {
        public override FourOfAKindCheckerResult? Check(Player player)
        {
            var hand = player.Cards;
            foreach (var card in hand)
            {
                if (hand.Count(cards => cards.Value == card.Value) == 4)
                {
                    return new(card.Value);
                }
            }
            return null;
        }
    }
}
