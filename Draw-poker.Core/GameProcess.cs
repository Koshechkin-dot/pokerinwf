using Draw_poker.Core.CardsLogic;
using Draw_poker.Core.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_poker.Core
{
    public class GameProcess
    {
        public int _turn;
        public int _plr_pos;
        public Player[] _players;
        private DeckOfCards _deckOfCards;
        public int _bet;
        public int _start_cash;
        public int _game_bank;
        public GameProcess(int players, int start_cash)
        {
            _turn = 0;
            _plr_pos = 0;
            _game_bank = 0;
            _bet = 0;
            _start_cash = start_cash;
            _deckOfCards = new DeckOfCards();
            _players = new Player[players];
            for (int i = 0; i < players; i++)
            {
                _players[i] = new Player(_start_cash);
            }
        }

        public void Start()
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (Player plr in _players)
                {
                    plr.AddCard(_deckOfCards.GetCard());
                }
            }
            _bet = 25;
        }

        public Player ChooseWinner()
        {
            if (_game_bank == 0)
            { 
                foreach(Player plr in _players)
                {
                    if (plr.Cash == _start_cash * _players.Length) return plr;
                }
            }
            return null;
        }
    }
}
