namespace Draw_poker.Game
{
    public class GameBank
    {
        public int Bank { get; set; }
        public int Bet { get; set; }
        public Label BankLabel { get; set; }
        public GameBank(Label bank)
        {
            Bet = 25;
            Bank = 0;
            BankLabel = bank;
        }

        public void UpdateLabel()
        {
            BankLabel.Text = Bank.ToString();
        }

    }
}
