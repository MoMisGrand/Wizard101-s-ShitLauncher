using System.Windows.Forms;

namespace W101RLauncher.Methods
{
    public static class Misc
    {
        // Fix tabbing
        public static void Tabbing(KeyPressEventArgs e, Control control)
        {
            if (e.KeyChar != (char) Keys.Tab) return;
            var textBox = (TextBox)control;
            textBox.Select();
            textBox.SelectAll();
            e.Handled = true;
        }
    }
}