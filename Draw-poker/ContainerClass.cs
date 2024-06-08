namespace Draw_poker
{
    public class ContainerClass
    {
        public List<Label> labels;
        public List<Button> buttons;
        public List<CheckedListBox> checkboxes;
        public ContainerClass(GameForm form)
        {
            labels = form.Controls.OfType<Label>().ToList();
            buttons = form.Controls.OfType<Button>().ToList();
            checkboxes = form.Controls.OfType<CheckedListBox>().ToList();
        }

    }
}
