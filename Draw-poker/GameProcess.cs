using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.Game;
using Draw_poker.Game;
using System.Windows.Forms;

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
        public List<PlayerHolder> PlayerHolders { get; private set; }
        public ContainerClass ContainerClass { get; private set; }
        public int _start_cash;
        
        public List<PlayerHolder> Initialize(int startCash, ContainerClass cc)
        {
            ContainerClass = cc;
            _start_cash = startCash;
            GameBank = new(cc.Labels.Where(label => label.Name == "Bank").First());
            return new List<PlayerHolder>()
            {
                new PlayerHolder(new Player(startCash),
                cc.Labels.Where(t => t.Name == "PlayerCash").First(),
                cc.Labels.Where(t => t.Name == "PlayerBet").First(),
                cc.PlayerCards,
                false
                ),
                new PlayerHolder(new Player(startCash),
                cc.Labels.Where(t => t.Name == "BotCash").First(),
                cc.Labels.Where(t => t.Name == "BotBet").First(),
                cc.BotCards,
                true
                )
            };
        }

        public async void Game(int startCash, ContainerClass cc)
        {
            PlayerHolders = Initialize(startCash, cc);
            foreach (PlayerHolder playerHolder in PlayerHolders)
            {
                playerHolder.UpdateLabel();
            }
            string resultOfGame = string.Empty;
            while(true)
            {
                Round round = new(PlayerHolders, cc.Buttons);
                await round.Trade();
                if (PlayerHolders[0].Player.Cards.Count == 0)
                {
                    PlayerHolders[1].Player.Bet = 0;
                    PlayerHolders[1].Player.Cash += GameBank.Bank;
                    PlayerHolders[1].UpdateLabel();
                    GameBank.Bank = 0;
                    GameBank.UpdateLabel();
                    PlayerHolders[0].UpdateLabel();
                    continue;
                }
                await round.Replacement();
                await round.Showdown();
                if (PlayerHolders.Where(player => player.Player.Cash == 0).Count() > 0)
                {
                    int index = PlayerHolders.IndexOf(
                        PlayerHolders.Where(player => player.Player.Cash == 0)
                        .First()
                        );
                    if(index == 0)
                    {
                        resultOfGame = "Вы проиграли\nПопробуете еще раз?";
                    }
                    else
                    {
                        resultOfGame = "Вы выиграли!\nХотите еще партию?";
                    }
                    break;
                }
            }
            //надо сделать окно с результатом
            MessageBox.Show(resultOfGame);
            Game(startCash, cc);
        }
    }
}
