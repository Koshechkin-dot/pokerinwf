namespace Draw_poker
{
    public partial class GameForm : Form
    {
        Form menu;
        private int startCash;
        private GameProcess gameProcess;
        private ContainerClass containerClass;

        public GameForm(Form Menu, string plrName, int startCash)
        {
            InitializeComponent();
            PlayerName.Text = plrName;
            menu = Menu;
            this.startCash = startCash;
            containerClass = new ContainerClass(this);
            gameProcess = GameProcess.Instance;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            gameProcess.Game(startCash, containerClass);
        }

        private void FoldB_Click(object sender, EventArgs e)
        {
            gameProcess.PlayerHolders[0].Fold();
        }

        private void CallB_Click(object sender, EventArgs e)
        {
            gameProcess.PlayerHolders[0].Call(gameProcess.GameBank.Bet);
        }

        private void RaiseB_Click(object sender, EventArgs e)
        {
            Int32.TryParse(RaiseValue.Text, out int result);
            gameProcess.PlayerHolders[0].Raise(result);
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Close();
        }

        private async Task NextRound_Click(object sender, EventArgs e)
        {
            await Task.Delay(1);
        }
    }
}
