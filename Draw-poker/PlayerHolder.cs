using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.Game;
using Draw_poker.Game;

namespace Draw_poker
{
    public class PlayerHolder
    {
        public Player Player { get; }
        public Label CashLabel { get; }
        public Label BetLabel { get; }
        public List<PictureBox> PictureBoxes { get; }
        public bool IsBot { get; }
        public PlayerHolder(Player player, Label cash, Label bet, List<PictureBox> checkedListBox, bool isBot)
        {
            Player = player;
            CashLabel = cash;
            BetLabel = bet;
            PictureBoxes = checkedListBox;
            IsBot = isBot;
        }
        public void Fold()
        {
            ClearCards();
            Player.Bet = 0;
            UpdateLabel();
        }
        public bool CanCall(int _bet)
        {
            var gp = GameProcess.Instance;
            if (_bet <= Player.Cash + Player.Bet && _bet > Player.Bet && _bet == gp.GameBank.Bet)
            {
                return true;
            }
            return false;
        }
        public void Call(int _bet)
        {
            var gp = GameProcess.Instance;
            Player.Cash -= _bet - Player.Bet;
            Player.Bet = _bet;
            gp.GameBank.Bank += _bet;
            UpdateLabel();
            gp.GameBank.UpdateLabel();
        }
        public bool Raise(int _new_bet)
        {
            var gp = GameProcess.Instance;
            if (_new_bet <= Player.Cash + Player.Bet && _new_bet > gp.GameBank.Bet)
            {
                Player.Cash -= (_new_bet - Player.Bet);
                gp.GameBank.Bet = _new_bet;
                gp.GameBank.Bank += _new_bet - Player.Bet;
                Player.Bet = _new_bet;
                UpdateLabel();
                gp.GameBank.UpdateLabel();
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
            if(!IsBot)
            {
                PictureBoxes[index].Image = ImageRepository.GetCardImage(newCard);
            }
        }
        public void ClearCards()
        {
            foreach(var box in PictureBoxes)
            {
                box.Image = null;
            }
            Player.Cards.Clear();
        }
        // Для Ботов
        public void Action(int _new_bet)
        {
            if (!CanCall(_new_bet))
            {
                Fold();
            }
            Random random = new Random();
            if (random.Next(0, 100) < 40)
            {
                Raise(_new_bet + 15);
            }
            else
            {
                Call(_new_bet);
            }
            UpdateLabel();
        }
        public void ShowCards()
        {
            if(Player.Cards.Count == 0)
            {
                return;
            }
            for(int i = 0; i < Player.Cards.Count; i++)
            {
                PictureBoxes[i].Image = ImageRepository.GetCardImage(Player.Cards[i]);
            }
        }
        public void UpdateLabel()
        {
            CashLabel.Text = Player.Cash.ToString();
            BetLabel.Text = Player.Bet.ToString();
        }
    }
}
