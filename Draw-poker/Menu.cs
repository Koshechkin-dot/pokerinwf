using Draw_poker.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_poker
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void StartB_Click(object sender, EventArgs e)
        {
            if (NameBox.Text != string.Empty && NameBox.Text.Length < 8)
            {
                this.Hide();
                GameForm form = new GameForm(this, NameBox.Text);
                form.Show();
            }
        }
    }
}
