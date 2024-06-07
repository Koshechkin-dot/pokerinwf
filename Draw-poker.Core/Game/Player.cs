using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Core.Game
{
    public class Player
    {
        public const int MAX_CARDS_IN_HAND = 5;
        public int Cash { get; set; }
        public int Bet { get; set; }
        public List<Card> Cards { get; }

        public Player(int cash)
        {
            Cards = new List<Card>(MAX_CARDS_IN_HAND);
            Cash = cash;
        }
        
    }
}
