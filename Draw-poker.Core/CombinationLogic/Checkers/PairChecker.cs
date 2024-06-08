﻿using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.Game;

namespace Draw_poker.Core.CombinationLogic.Checkers
{
    public class PairChecker : CombinationChecker<PairCheckerResult>
    {
        public override PairCheckerResult? Check(Player player)
        {
            if (player.Cards.Count == 0) { return null; }
            var hand = player.Cards;
            var pairs = hand.GroupBy(card => card.Value)
                            .Where(group => group.Count() == 1)
                            .Select(v => v.Key).ToList();
            if (pairs.Any())
            {
                return new(pairs[0]);
            }
            return null;
        }
    }
}
