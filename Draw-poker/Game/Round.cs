using Draw_poker.Core.CardsLogic;
using System;

namespace Draw_poker.Game
{
    public class Round
    {
        public DeckOfCards Deck { get; }
        public GameBank GameBank { get; }
        public List<PlayerHolder> Players { get; }
        public bool IsPlayerDealer { get; set; }
        private PlayerAwaiter awaiter;
        
        public Round(List<PlayerHolder> players, List<Button> buttons)
        {
            Deck = new DeckOfCards();
            awaiter = new PlayerAwaiter(buttons);
            GameBank = GameProcess.Instance.GameBank;
            Players = players;
            
            CardDeal();
        }
        

        public async Task Trade()
        {
            if (IsPlayerDealer)
            {
                Players[1].Action(GameBank.Bet);
                await awaiter.TradeTurnAwaiter();
            }
            else
            {
                await awaiter.TradeTurnAwaiter();
                Players[1].Action(GameBank.Bet);
            }
            foreach (PlayerHolder player in Players)
            {
                player.UpdateLabel();
            }
            if (Players[0].Player.Cards.Count == 0)
            {
                GameBank.Bet = 25;
                return;
            }
            if (Players[0].Player.Bet != Players[1].Player.Bet)
            {
                await Trade();
            }
            return;
        }
        public async Task Replacement()
        {
            await awaiter.ReplacementTurnAwaiter();

            List <CheckBox> playerControls = GameProcess.Instance.ContainerClass.PlayerBox;
            for (int i = 0; i < playerControls.Count(); i++)
            {
                if (playerControls[i].Checked)
                {
                    Players[0].ReplaceCard(Deck.GetCard(), i);
                    playerControls[i].Checked = false;
                }
            }
        }
        public async Task Showdown()
        {
            Players[1].ShowCards();
            WinnerRecognizer recognizer = new WinnerRecognizer();
            var result = recognizer.Recognize(Players.Select(x => x.Player).ToList());
            int cashForWinners;
            if (result.Count > 1)
            {
                cashForWinners = GameBank.Bank / result.Count;
            }
            else
            {
                cashForWinners = GameBank.Bank;
            }
            GameBank.Bank = 0;
            foreach (var player in result)
            {
                player.Cash += cashForWinners;
                
            }
            foreach (var player in Players)
            {
                player.Player.Bet = 0;
                player.UpdateLabel();
            }
            GameBank.UpdateLabel();
        }
        private void CardDeal()
        {
            foreach (var player in Players)
            {
                player.ClearCards();
            }
            for (int i = 0; i < 5; i++)
            {
                foreach (PlayerHolder plr in Players)
                {
                    Card card = Deck.GetCard();
                    plr.AddCard(card);
                    if (!plr.IsBot)
                    {
                        plr.PictureBoxes[i].Image = ImageRepository.GetCardImage(card);
                    }
                    else
                    {
                        plr.PictureBoxes[i].Image = ImageRepository.GetCardBack();
                    }

                }
            }
        }

    }
}
