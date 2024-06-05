using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_poker
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
