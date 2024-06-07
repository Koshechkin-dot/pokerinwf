using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.CombinationLogic.Checkers;
using Draw_poker.Core.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_poker.Game
{
    public class WinnerRecognizer
    {
        private List<ICombinationChecker> combinationCheckers;
        public WinnerRecognizer()
        {
            combinationCheckers = new List<ICombinationChecker>()
            {
                new RoyalFlushChecker(),
                new StraightFlushChecker(),
                new FourOfAKindChecker(),
                new FullHouseChecker(),
                new FlushChecker(),
                new StraightChecker(),
                new ThreeOfAKindChecker(),
                new TwoPairChecker(),
                new PairChecker(),
                new NonCombinationChecker()
            };
        }
        public List<Player> Recognize(List<Player> players)
        {
            List<Player> winners = new List<Player>();
            foreach (ICombinationChecker checker in combinationCheckers)
            {
                Dictionary<Player, CheckerResult?> results = new();
                foreach (Player player in players)
                {
                    results.Add(player, checker.Check(player));
                }
                int winnersCount = results.Values.Where(value => value != null).Count();
                if (winnersCount == 1)
                {
                    winners.Add(results.Where(element => element.Value != null).First().Key);
                    break;
                }
                if (winnersCount > 1 && winnersCount <= players.Count)
                {
                    var win = results.Where(element => element.Value != null).ToList();
                    if (win[0].Value.CompareTo(win[1].Value) < 0)
                    {
                        winners.Add(win[1].Key);
                    }
                    else if (win[0].Value.CompareTo(win[1].Value) > 0)
                    {
                        winners.Add(win[0].Key);
                    }
                    else
                    {
                        winners.AddRange(win.Select(element => element.Key));
                    }
                    break;
                }
            }
            return winners;
        }
    }
}
