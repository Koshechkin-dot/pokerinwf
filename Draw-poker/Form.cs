using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.CombinationLogic.CheckerResults;
using Draw_poker.Core.CombinationLogic.Checkers;
using Draw_poker.Core.Game;
using System.Runtime.CompilerServices;

namespace Draw_poker
{
    public partial class Form : System.Windows.Forms.Form
    {
        int num_of_players;
        private GameProcess gameProcess;
        private ContainerClass containerClass;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            int start_cash = 1000;
            containerClass = new ContainerClass(this);
            gameProcess = GameProcess.Instance;
            
            gameProcess.Initialize(start_cash, containerClass);
            
            //gameProcess.Start(num_of_players, start_cash, containerClass);
            //gameProcess.GameIter(containerClass);
            //gameProcess.UpdateLabels(containerClass);
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
    }
}
