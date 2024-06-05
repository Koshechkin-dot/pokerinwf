using Draw_poker.Core.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Draw_poker
{
    public class PlayerHolder
    {
        public Player _player { get; }
        public Label _name { get; }
        public Label _cash { get; }
        public Label _bet { get; }
        public PlayerHolder(Player player, Label name, Label cash, Label bet)
        {
            _player = player;
            _name = name;
            _cash = cash;
            _bet = bet;
        }
        public void Fold()
        {
            _player.ClearCards();
            _player.Bet = 0;
        }
        public bool Call(GameProcess gp, int _bet)
        {
            if (_bet <= _player.Cash + _player.Bet && _bet > _player.Bet)
            {
                _player.Cash -= (_bet - _player.Bet);
                _player.Bet = _bet;
                gp._game_bank += _bet;
                return true;
            }
            return false;
        }
        public bool Raise(ref GameProcess gp, int _new_bet)
        {
            if (_new_bet <= _player.Cash + _player.Bet && _new_bet > gp._bet)
            {
                _player.Cash -= (_new_bet - _player.Bet);
                gp._bet = _new_bet;
                gp._game_bank += _new_bet - _player.Bet;
                _player.Bet = _new_bet;
                return true;
            }
            return false;
        }
        // Для Ботов
        public void Action(GameProcess gp, int _new_bet)
        {
            if (!Call(gp, _new_bet))
            {
                Fold();
            }
            Random random = new Random();
            if (random.Next(0, 100) < 20)
            {
                Raise(ref gp, _new_bet + 10);
            }
            else
            {
                Call(gp, _new_bet);
            }
        }
    }
}
