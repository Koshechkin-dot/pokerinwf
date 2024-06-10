using Draw_poker.Core.CardsLogic;

namespace Draw_poker.Game
{
    public class ImageRepository
    {
        private ImageRepository()
        {
            
        }
        public static Image GetCardImage(Card card)
        {
            return Image.FromFile($"D:\\pokerinwf\\Draw-poker\\Cards\\{card.Value}Of{card.Suit}.png");
        }
        public static Image GetCardBack()
        {
            return Image.FromFile("D:\\pokerinwf\\Draw-poker\\Cards\\CardBack.png");
        }
    }
}
