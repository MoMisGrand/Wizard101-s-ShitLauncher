using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace W101RLauncher.Forms
{
    public sealed partial class PopupForm : Form
    {
        public PopupForm(Image image)
        {
            InitializeComponent();
            BackgroundImage = image;
            SystemSounds.Hand.Play();
        }

        private void ok_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void ok_MouseHover(object sender, EventArgs e)
        {
            ok.Image = Properties.Resources.ok_hover;
        }

        private void ok_MouseLeave(object sender, EventArgs e)
        {
            ok.Image = Properties.Resources.ok;
        }
    }
}