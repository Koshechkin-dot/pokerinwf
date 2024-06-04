namespace Draw_poker.Core.Game
{
    //wrapper
    public class Dealer : Player
    {
        private readonly Player _player;
        public Dealer(Player player, int cash)
            :base(cash)
        {
            _player = player;
        }
    }
}
