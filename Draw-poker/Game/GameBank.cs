namespace Draw_poker.Game
{
    public class GameBank
    {
        public int Bank { get; set; }
        public Label BankLabel { get; set; }
        public GameBank(Label bank)
        {
            Bank = 0;
            BankLabel = bank;
        }

        public void UpdateLabel()
        {
            BankLabel.Text = Bank.ToString();
        }

    }
}
