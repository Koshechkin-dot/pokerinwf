namespace Draw_poker.Game
{
    public class PlayerAwaiter
    {
        private List<Button> Buttons;
        public PlayerAwaiter(List<Button> buttons)
        {
            Buttons = buttons;
        }
        private TaskCompletionSource<bool> ButtonClicked = new TaskCompletionSource<bool>();
        private void HandleClick(object sender, EventArgs eventArgs)
        {
            ButtonClicked.TrySetResult(true);
        }
        public async Task TradeTurnAwaiter()
        {
            List<Button> buttons = new List<Button>()
            {
                Buttons.Where(t => t.Name == "FoldB").First(),
                Buttons.Where(t => t.Name == "CallB").First(),
                Buttons.Where(t => t.Name == "RaiseB").First()
            };
            SetupButtons(buttons, true);
            await ButtonClicked.Task;
            SetupButtons(buttons, false);
            ButtonClicked = new TaskCompletionSource<bool>();
        }
        public async Task ReplacementTurnAwaiter()
        {
            List<Button> buttons = new List<Button>()
            {
                Buttons.Where(t => t.Name == $"ReplaceB").First()
            };
            SetupButtons(buttons, true);
            await ButtonClicked.Task;
            SetupButtons(buttons, false);
            ButtonClicked = new TaskCompletionSource<bool>();
        }
        private void SetupButtons(List<Button> buttons, bool enable)
        {
            foreach (var button in buttons)
            {
                button.Enabled = enable;
                if (enable)
                {
                    button.Click += HandleClick;
                }
                else
                {
                    button.Click -= HandleClick;
                }
            }

        }
    }
}