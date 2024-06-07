using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.Game;

namespace Draw_poker
{
    public class PlayerHolder
    {
        public Player Player { get; }
        public Label Cash { get; }
        public Label Bet { get; }
        public PlayerHolder(Player player, Label cash, Label bet)
        {
            Player = player;
            Cash = cash;
            Bet = bet;
        }
        public void Fold()
        {
            ClearCards();
            Player.Bet = 0;
        }
        public bool Call(int _bet)
        {
            var gp = GameProcess.Instance;
            if (_bet <= Player.Cash + Player.Bet && _bet > Player.Bet)
            {
                Player.Cash -= (_bet - Player.Bet);
                Player.Bet = _bet;
                gp.GameBank.Bank += _bet;
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
        public void ReplaceCard(Card card, int index)
        {
            Player.Cards.Remove(Player.Cards[index]);
            Player.Cards.Insert(index, card);
        }
        public void ClearCards()
        {
            Player.Cards.Clear();
        }
        public void UpdateLabel()
        {
            Cash.Text = Player.Cash.ToString();
            Bet.Text = Player.Bet.ToString();
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
        }
    }
}
