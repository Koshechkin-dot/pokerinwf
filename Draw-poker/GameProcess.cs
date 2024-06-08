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
            _bet = 25;
            _start_cash = startCash;
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

        public async void Game(int startCash, ContainerClass cc)
        {
            List<PlayerHolder> playerHolders = Initialize(startCash, cc);
            Round round = new(GameBank, playerHolders, cc.buttons, cc.checkboxes);
            // я хз что тут писать await round.Trade();
        }
    }
}
