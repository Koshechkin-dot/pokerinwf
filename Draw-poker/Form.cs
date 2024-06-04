using Draw_poker.Core;
using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.CombinationLogic.Checkers;
using Draw_poker.Core.Game;

namespace Draw_poker
{
    public partial class Form : System.Windows.Forms.Form
    {
        //test
        private Player p1 = new(1000);
        private Player p2 = new(1000);
        private DeckOfCards deck = new DeckOfCards();

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                p1.AddCard(deck.GetCard());
                p2.AddCard(deck.GetCard());
            }


            BotCards.Items.Add(String.Join(", ", p1.GetCardValues()));
            PlayerCards.Items.Add(String.Join(", ", p2.GetCardValues()));
            BotCards.Items.Add(String.Join(", ", p1.GetCardSuits()));
            PlayerCards.Items.Add(String.Join(", ", p2.GetCardSuits()));
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            
        }
    }
}
