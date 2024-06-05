using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_poker
{
    public class GameProcess
    {
        public static GameProcess gp { get 
            {
                if (_gp == null)
                { 
                    _gp = new GameProcess();
                    return _gp;
                }
                return _gp;
            }
        }
        private static GameProcess _gp;
        public int _plr_pos;
        public PlayerHolder[] _players;
        private DeckOfCards _deckOfCards;
        public int _bet;
        public int _start_cash;
        public int _game_bank;
        private GameProcess()
        {
            
        }

        public void Start(int players, int start_cash, ContainerClass cc)
        {
            Random rnd = new Random();
            _plr_pos = rnd.Next(0, players - 1);
            _game_bank = 0;
            _bet = 25; //ante
            _start_cash = start_cash;
            _deckOfCards = new DeckOfCards();
            _players = new PlayerHolder[players];
            for (int i = 0; i < players; i++)
            {
                _players[i] = new PlayerHolder(new Player(_start_cash), cc.labels.Where(t => t.Name == $"Player{i}").First(),
                    cc.labels.Where(t => t.Name == $"Cash{i}").First(),
                    cc.labels.Where(t => t.Name == $"Bet{i}").First());
                if (i == _plr_pos) _players[i]._name.Text = "Player";
                else _players[i]._name.Text = "Bot";
            }
            for (int i = 0; i < 5; i++)
            {
                foreach (PlayerHolder plr in _players)
                {
                    plr._player.AddCard(_deckOfCards.GetCard());
                }
            }
        }

        public void GameIter(ContainerClass cc)
        {
            cc.buttons.Where(t => t.Name == $"FoldB").First().Enabled = false;
            cc.buttons.Where(t => t.Name == $"CallB").First().Enabled = false;
            cc.buttons.Where(t => t.Name == $"RaiseB").First().Enabled = false;
            for (int i = 0; i < _players.Length; ++i)
            {
                if (_players[i]._player.GetCards != null)
                {
                    if (i != _plr_pos)
                    {
                        _players[i].Action(this, _bet);
                        UpdateLabels(cc);
                    }
                    else
                    {
                        cc.buttons.Where(t => t.Name == $"FoldB").First().Enabled = true;
                        cc.buttons.Where(t => t.Name == $"CallB").First().Enabled = true;
                        cc.buttons.Where(t => t.Name == $"RaiseB").First().Enabled = true;
                    }
                }
            }
        }

        public Player? ChooseWinner()
        {
            if (_game_bank == 0)
            { 
                foreach(PlayerHolder plr in _players)
                {
                    if (plr._player.Cash == _start_cash * _players.Length) return plr._player;
                }
            }
            return null;
        }

        public void UpdateLabels(ContainerClass cc)
        {
            foreach(PlayerHolder plr in _players)
            {
                plr._cash.Text = plr._player.Cash.ToString();
                plr._bet.Text = plr._player.Bet.ToString();
            }
            cc.labels.Where(t => t.Name == $"Bank").First().Text = _game_bank.ToString();
        }
    }
}
