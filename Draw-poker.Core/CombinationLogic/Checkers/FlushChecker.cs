﻿using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public class FlushChecker : CombinationChecker<FlushCheckerResult>
    {
        public override FlushCheckerResult? Check(Player player)
        {
            if (player.Cards.Count == 0) { return null; }
            var hand = player.Cards;
            CardSuit suit = hand[0].Suit;
            if(hand.Count(card => card.Suit == suit) == 5 )
            {
                return new(ConvertToValues(player));
            }
            return null;
        }
    }
}
