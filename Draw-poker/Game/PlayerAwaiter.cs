﻿namespace Draw_poker.Game
{
    public class PlayerAwaiter
    {
        private List<Button> Buttons;
        private List<CheckBox> CheckBoxes;
        public PlayerAwaiter(List<Button> buttons, List<CheckBox> checkBoxes)
        {
            Buttons = buttons;
            CheckBoxes = checkBoxes;
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
        public async Task ReplacementTurnAwaiter()
        {
            //типо выделенные карты чекбоксов удалить карты с ними
            //имена и масти карт надо где то в update я хз где
            Buttons.Where(t => t.Name == $"ReplaceB").First().Enabled = true;
            await ButtonClicked.Task;
            Buttons.Where(t => t.Name == $"ReplaceB").First().Enabled = false;
            ButtonClicked = new TaskCompletionSource<bool>();
        }
    }
}