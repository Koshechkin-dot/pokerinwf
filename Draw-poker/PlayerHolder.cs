using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.Game;

namespace Draw_poker
{
    public class PlayerHolder
    {
        public Player Player { get; }
        public Label CashLabel { get; }
        public Label BetLabel { get; }
        public CheckedListBox CheckedListBox { get; }
        public PlayerHolder(Player player, Label cash, Label bet, CheckedListBox checkedListBox)
        {
            Player = player;
            CashLabel = cash;
            BetLabel = bet;
            CheckedListBox = checkedListBox;
        }
        public void Fold()
        {
            ClearCards();
            Player.Bet = 0;
            UpdateLabel();
        }
        public bool Call(int _bet)
        {
            var gp = GameProcess.Instance;
            if (_bet <= Player.Cash + Player.Bet && _bet > Player.Bet)
            {
                Player.Cash -= (_bet - Player.Bet);
                Player.Bet = _bet;
                gp.GameBank.Bank += _bet;
                UpdateLabel();
                return true;
            }
            return false;
        }
        public bool Raise(int _new_bet)
        {
            var gp = GameProcess.Instance;
            if (_new_bet <= Player.Cash + Player.Bet && _new_bet > gp._bet)
            {
                Player.Cash -= (_new_bet - Player.Bet);
                gp._bet = _new_bet;
                gp.GameBank.Bank += _new_bet - Player.Bet;
                Player.Bet = _new_bet;
                UpdateLabel();
                return true;
            }
            return false;
        }

        public void AddCard(Card card)
        {
            if (Player.Cards.Count >= Player.MAX_CARDS_IN_HAND)
            {
                throw new ArgumentOutOfRangeException("Can't add card to full hand");
            }
            Player.Cards.Add(card);
        }
        public void ReplaceCard(Card newCard, int index)
        {
            Player.Cards[index] = newCard;
            CheckedListBox.Items[index] = newCard;
        }
        public void ClearCards()
        {
            CheckedListBox.Items.Clear();
            Player.Cards.Clear();
        }
        // Для Ботов
        public void Action(int _new_bet)
        {
            if (!Call(_new_bet))
            {
                Fold();
            }
            Random random = new Random();
            if (random.Next(0, 100) < 20)
            {
                Raise(_new_bet + 10);
            }
            else
            {
                Call(_new_bet);
            }
            UpdateLabel();
        }
        public void UpdateLabel()
        {
            CashLabel.Text = Player.Cash.ToString();
            BetLabel.Text = Player.Bet.ToString();
        }
    }
}
