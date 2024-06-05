using Draw_poker.Core;
using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.CombinationLogic.Checkers;
using Draw_poker.Core.Game;

namespace Draw_poker
{
    public partial class Form : System.Windows.Forms.Form
    {
        int num_of_players;
        GameProcess gameProcess;

        public Form()
        {
            InitializeComponent();
        }

        public void UpdateLabels(GameProcess gameProcess)
        {
            for (int i = 0; i < gameProcess._players.Length; i++)
            {

            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            int num_of_players = 4;
            GameProcess gameProcess = new(num_of_players, 1000);
            gameProcess.Start();
            //BotCards.Items.Add(String.Join(", ", p1.GetCardValues()));
            //PlayerCards.Items.Add(String.Join(", ", p2.GetCardValues()));
            //BotCards.Items.Add(String.Join(", ", p1.GetCardSuits()));
            //PlayerCards.Items.Add(String.Join(", ", p2.GetCardSuits()));
        }

        private void FoldB_Click(object sender, EventArgs e)
        {
            gameProcess._players[gameProcess._plr_pos].Fold();
        }

        private void CallB_Click(object sender, EventArgs e)
        {
            gameProcess._players[gameProcess._plr_pos].Call(gameProcess._bet);
        }

        private void RaiseB_Click(object sender, EventArgs e)
        {
            gameProcess._players[gameProcess._plr_pos].Raise(ref gameProcess, Int32.Parse(RaiseValue.Text));
        }
    }
}
