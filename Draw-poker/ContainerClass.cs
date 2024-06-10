namespace Draw_poker
{
    public class ContainerClass
    {
        public List<Label> Labels;
        public List<Button> Buttons;
        public List<PictureBox> PlayerCards;
        public List<PictureBox> BotCards;
        public List<CheckBox> PlayerBox;
        public ContainerClass(GameForm form)
        {
            Labels = form.Controls.OfType<Label>().ToList();
            Buttons = form.Controls.OfType<Button>().ToList();
            PlayerCards = form.Controls.OfType<PictureBox>().Where(box => box.Name.StartsWith("Player")).OrderBy(box => box.Name).ToList();
            BotCards = form.Controls.OfType<PictureBox>().Where(box => box.Name.StartsWith("Bot")).OrderBy(box => box.Name).ToList();
            PlayerBox = form.Controls.OfType<CheckBox>().OrderBy(box => box.Name).ToList();
        }

    }
}
