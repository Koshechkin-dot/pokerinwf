namespace Draw_poker.Game
{
    public class PlayerAwaiter
    {
        private List<Button> Buttons;
        public PlayerAwaiter(List<Button> buttons)
        {
            Buttons = buttons;
            foreach (Button button in Buttons)
            {
                button.Click += HandleClick;
            }
        }
        private TaskCompletionSource<bool> ButtonClicked = new TaskCompletionSource<bool>();
        private void HandleClick(object sender, EventArgs eventArgs)
        {
            ButtonClicked.TrySetResult(true);
        }
        public async Task TradeTurnAwaiter()
        {
            Buttons.Where(t => t.Name == $"FoldB").First().Enabled = true;
            Buttons.Where(t => t.Name == $"CallB").First().Enabled = true;
            Buttons.Where(t => t.Name == $"RaiseB").First().Enabled = true;
            await ButtonClicked.Task;
            Buttons.Where(t => t.Name == $"FoldB").First().Enabled = false;
            Buttons.Where(t => t.Name == $"CallB").First().Enabled = false;
            Buttons.Where(t => t.Name == $"RaiseB").First().Enabled = false;
            ButtonClicked = new TaskCompletionSource<bool>();
        }
        //допиши логику для реплейсмента ну там нужные кнопочки подрубишь все дела
        public async Task ReplacementTurnAwaiter()
        {
            await ButtonClicked.Task;
            ButtonClicked = new TaskCompletionSource<bool>();
        }
    }
}