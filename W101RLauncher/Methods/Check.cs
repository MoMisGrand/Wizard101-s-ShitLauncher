using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace W101RLauncher.Methods
{
    public static class Check
    {
        public static void TextBoxCheck(List<TextBox> list, Button button)
        {
            if (!(list[0].Text.Equals("") || list[0].Text.Equals("Server IP...") || list[1].Text.Equals("")
                  || list[1].Text.Equals("Username...") || list[3].Text.Equals("") || list[3].Text.Equals("Password...") 
                  || list[2].Text.Equals("") || list[2].Text.Equals("Alpha key...")))
            {
                button.Enabled = true;
                button.Image = Properties.Resources.login;
                GC.Collect();
            }
            else
            {
                button.Enabled = false;
                button.Image = Properties.Resources.login;
                GC.Collect();
            }
        }
    }
}