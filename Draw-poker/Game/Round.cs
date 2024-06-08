using Draw_poker.Core.CardsLogic;

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
            if(IsPlayerDealer)
            {
                Players[1].Action(50);
                await awaiter.TradeTurnAwaiter();
            }
            else
            {
                await awaiter.TradeTurnAwaiter();
                Players[1].Action(50);
            }
            return;
        }
        public async Task Replacement()
        {
            await awaiter.ReplacementTurnAwaiter();

            var indexes = Players[0].CheckedListBox.CheckedIndices.Cast<int>().ToList();
            foreach(var index in indexes)
            {
                Players[0].ReplaceCard(Deck.GetCard(), index);
            }
        }
        public async Task Showdown()
        {
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
                    plr.CheckedListBox.Items.Add(card.Value.ToString() + "Of" + card.Suit.ToString());
                }
            }
        }

    }
}
