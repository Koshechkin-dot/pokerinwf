using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.Game;
using Draw_poker.Game;

namespace Draw_poker
{
    public class GameProcess
    {
        public static GameProcess Instance
        {
            get
            {
                if (_instance == null)
                { 
                    _instance = new GameProcess();
                    return _instance;
                }
                return _instance;
            }
        }
        private static GameProcess _instance;
        private GameProcess()
        {
        }
        public GameBank GameBank;
        public int _bet;
        public int _start_cash;
        
        public List<PlayerHolder> Initialize(int startCash, ContainerClass cc)
        {
            GameBank = new(cc.labels.Where(label => label.Name == "Bank").First());
            return new List<PlayerHolder>()
            {
                new PlayerHolder(new Player(startCash),
                cc.labels.Where(t => t.Name == "PlayerCash").First(),
                cc.labels.Where(t => t.Name == "PlayerBet").First()
                ),
                new PlayerHolder(new Player(startCash),
                cc.labels.Where(t => t.Name == "BotCash").First(),
                cc.labels.Where(t => t.Name == "BotBet").First()
                )
            };
        }

        public void Start(int start_cash)
        {
            _bet = 25; //ante
            _start_cash = start_cash;
            
        }

        //public void GameIter(ContainerClass cc)
        //{
        //    cc.buttons.Where(t => t.Name == $"FoldB").First().Enabled = false;
        //    cc.buttons.Where(t => t.Name == $"CallB").First().Enabled = false;
        //    cc.buttons.Where(t => t.Name == $"RaiseB").First().Enabled = false;
        //    for (int i = 0; i < _players.Length; ++i)
        //    {
        //        if (_players[i].Player.GetCards != null)
        //        {
        //            if (i != _plr_pos)
        //            {
        //                _players[i].Action(_bet);
        //                UpdateLabels(cc);
        //            }
        //            else
        //            {
        //                cc.buttons.Where(t => t.Name == $"FoldB").First().Enabled = true;
        //                cc.buttons.Where(t => t.Name == $"CallB").First().Enabled = true;
        //                cc.buttons.Where(t => t.Name == $"RaiseB").First().Enabled = true;
        //            }
        //        }
        //    }
        //}
    }
}
