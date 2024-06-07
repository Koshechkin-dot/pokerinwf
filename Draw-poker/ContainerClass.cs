﻿namespace Draw_poker
{
    public class ContainerClass
    {
        public List<Label> labels;
        public List<Button> buttons;
        public ContainerClass(Form form)
        {
            labels = form.Controls.OfType<Label>().ToList();
            buttons = form.Controls.OfType<Button>().ToList();
        }

    }
}
