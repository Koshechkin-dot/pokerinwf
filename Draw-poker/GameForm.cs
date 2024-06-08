using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.CombinationLogic.Checkers;
using Draw_poker.Core.Game;
using Draw_poker.Game;
using System.Runtime.CompilerServices;

namespace Draw_poker
{
    public partial class GameForm : System.Windows.Forms.Form
    {
        Form menu;
        int num_of_players;
        private GameProcess gameProcess;
        private Round round;
        private ContainerClass containerClass;

        public GameForm(Form Menu, string plrName)
        {
            InitializeComponent();
            PlayerName.Text = plrName;
            menu = Menu;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            int start_cash = 1000;
            containerClass = new ContainerClass(this);
            gameProcess = GameProcess.Instance;

            gameProcess.Initialize(start_cash, containerClass);
        }

        private void FoldB_Click(object sender, EventArgs e)
        {
            //gameProcess._players[gameProcess._plr_pos].Fold();
            //gameProcess.UpdateLabels(containerClass);
        }

        private void CallB_Click(object sender, EventArgs e)
        {
            //gameProcess._players[gameProcess._plr_pos].Call(gameProcess._bet);
            //gameProcess.UpdateLabels(containerClass);
        }

        private void RaiseB_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(RaiseValue.Text, out int result);
            //gameProcess._players[gameProcess._plr_pos].Raise(result);
            //gameProcess.UpdateLabels(containerClass);
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Close();
        }
    }
}