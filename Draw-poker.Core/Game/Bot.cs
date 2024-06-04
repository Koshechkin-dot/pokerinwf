using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Core.Game
{
    public class Bot : Player
    {
        private readonly Player _player;
        
        public Bot(Player player, int cash)
            : base(cash)
        {
            _player = player;
        }

    }
}
