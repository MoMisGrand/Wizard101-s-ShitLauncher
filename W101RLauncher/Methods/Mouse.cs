using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace W101RLauncher.Methods
{
    public static class Mouse
    {
        // Erase textbox text
        public static void OnEnter(Control control, string text)
        {
            var textBox = (TextBox) control;
            if (!textBox.Text.Equals(text)) return;
            textBox.Text = "";
            // Erase password text and use password characters
            if (textBox.Name.Equals("password"))
            {
                textBox.PasswordChar = '*';
            }
        }
        
        // Change textbox text back to placeholder
        public static void OnLeave(Control control, string text)
        {
            var textBox = (TextBox) control;
            if (!textBox.Text.Equals("")) return;
            textBox.Text = text;
            // Change password text back to placeholder and use regular characters
            if (textBox.Name.Equals("password"))
            {
                textBox.PasswordChar = '\0';
            }
        }
        
        // Change image on mouse hover
        public static void ButtonMouseHover(Control control, List<PictureBox> list)
        {
            try
            {
                var pictureBox = (PictureBox)control;
                if (pictureBox.Equals(list[0]))
                {
                    pictureBox.Image = Properties.Resources.ok_hover;
                }
                else if (pictureBox.Equals(list[1]))
                {
                    pictureBox.Image = Properties.Resources.settings_hover;
                }
                else if (pictureBox.Equals(list[2]))
                {
                    pictureBox.Image = Properties.Resources.minimize_hover;
                }
                else
                {
                    pictureBox.Image = Properties.Resources.close_hover;
                }
            }
            catch
            {
                var button = (Button)control;
                if (!button.Enabled) return;
                button.Image = Properties.Resources.login_hover;
            }
            GC.Collect();
        }
        
        // Change image on mouse leave
        public static void ButtonMouseLeave(Control control, List<PictureBox> list)
        {
            try
            {
                var pictureBox = (PictureBox) control;
                if (pictureBox.Equals(list[0]))
                {
                    pictureBox.Image = Properties.Resources.ok;
                }
                else if (pictureBox.Equals(list[1]))
                {
                    pictureBox.Image = Properties.Resources.settings;
                }
                else if (pictureBox.Equals(list[2]))
                {
                    pictureBox.Image = Properties.Resources.minimize;
                }
                else
                {
                    pictureBox.Image = Properties.Resources.close;
                }
            }
            catch
            {
                var button = (Button)control;
                if (!button.Enabled) return;
                button.Image = Properties.Resources.login;
            }
            GC.Collect();
        }
        
        // Move the window by following the mouse movement as long as the form is clicked
        public static Point PanelMouseMove(MouseEventArgs e, Point location, bool mouseIsDown, Point firstPoint)
        {
            if (!mouseIsDown) return location;
            //Get the difference between the two points
            var xDiff = firstPoint.X - e.Location.X;
            var yDiff = firstPoint.Y - e.Location.Y;

            //Set the new point
            var x = location.X - xDiff;
            var y = location.Y - yDiff;
            location = new Point(x, y);

            return location;
        }
    }
}