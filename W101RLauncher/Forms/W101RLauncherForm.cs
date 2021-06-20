using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace W101RLauncher.Forms
{
    public partial class W101RLauncherForm : Form
    {
        
        private bool _mouseIsDown;
        private Point _firstPoint;
        private List<TextBox> _textBoxList;
        private List<PictureBox> _pictureBoxList;

        // W101RLauncherForm
        public W101RLauncherForm()
        {
            InitializeComponent();
        }
        
        private void W101RLauncherForm_Load(object sender, EventArgs e)
        {
            var data = Methods.Datatable.ReadData();
            var settings = Methods.Datatable.ReadSettings();
            login.Image = Properties.Resources.login;
            if (settings != null)
            {
                launcherCheckBox.Checked = (bool)settings.Rows[0]["KeepLauncherOpen"];
                passwordCheckBox.Checked = (bool)settings.Rows[0]["SavePassword"];
            }
            if (data == null) return;
            serverIP.Text = (string)data.Rows[0]["ServerIP"];
            username.Text = (string)data.Rows[0]["Username"];
            alphaKey.Text = (string)data.Rows[0]["AlphaKey"];
            password.Text = (string)data.Rows[0]["Password"];
            if (string.IsNullOrEmpty(password.Text))
            {
                password.Select();
            }
            password.PasswordChar = '*';
        }
        
        // W101RLauncherPanel
        private void W101RLauncherPanel_MouseDown(object sender, MouseEventArgs e)
        {
            PanelMouseDown(e);
        }
        
        // Stop moving form
        private void W101RLauncherPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseIsDown = false;
        }
        
        private void W101RLauncherPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Location = Methods.Mouse.PanelMouseMove(e, Location, _mouseIsDown, _firstPoint);
        }

        // Textboxes
        
        private void serverIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Methods.Misc.Tabbing(e, username);
        }
        
        private void serverIP_Enter(object sender, EventArgs e)
        {
            Methods.Mouse.OnEnter(serverIP, "Server IP...");
        }

        private void serverIP_Leave(object sender, EventArgs e)
        {
            Methods.Mouse.OnLeave(serverIP, "Server IP...");
        }
        
        private void serverIP_TextChanged(object sender, EventArgs e)
        { 
            TextBoxListMaker();
            Methods.Check.TextBoxCheck(_textBoxList, login);
        }
        
        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            Methods.Misc.Tabbing(e, password);
        }

        private void username_Enter(object sender, EventArgs e)
        {
            Methods.Mouse.OnEnter(username, "Username...");
        }

        private void username_Leave(object sender, EventArgs e)
        {
            Methods.Mouse.OnLeave(username, "Username...");
        }
        
        private void username_TextChanged(object sender, EventArgs e)
        {
            TextBoxListMaker();
            Methods.Check.TextBoxCheck(_textBoxList, login);
        }
        
        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            Methods.Misc.Tabbing(e, alphaKey);
        }
        
        private void password_Enter(object sender, EventArgs e)
        {
            if (!password.Text.Equals("Password...") || !password.PasswordChar.Equals('\0')) return;
            Methods.Mouse.OnEnter(password, "Password...");
        }
        
        private void password_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(password.Text) || !password.PasswordChar.Equals('*')) return;
            Methods.Mouse.OnLeave(password, "Password...");
        }
        
        private void password_TextChanged(object sender, EventArgs e)
        {
            TextBoxListMaker();
            Methods.Check.TextBoxCheck(_textBoxList, login);
        }
        
        private void alphaKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            Methods.Misc.Tabbing(e, serverIP);
        }

        private void alphaKey_Enter(object sender, EventArgs e)
        {
            Methods.Mouse.OnEnter(alphaKey, "Alpha key...");
        }

        private void alphaKey_Leave(object sender, EventArgs e)
        {
            Methods.Mouse.OnLeave(alphaKey, "Alpha key...");
        }
        
        private void alphaKey_TextChanged(object sender, EventArgs e)
        {
            TextBoxListMaker();
            Methods.Check.TextBoxCheck(_textBoxList, login);
        }
        
        // Buttons
        private void login_Click(object sender, EventArgs e)
        {
            LoginClick();
        }
        
        private void login_MouseHover(object sender, EventArgs e)
        {
            Methods.Mouse.ButtonMouseHover(login, _pictureBoxList);
        }
        
        private void login_MouseLeave(object sender, EventArgs e)
        {
            Methods.Mouse.ButtonMouseLeave(login, _pictureBoxList);
        }
        
        // Minimize form by pressing the minimize button
        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void minimize_MouseHover(object sender, EventArgs e)
        {
            PictureBoxListMaker();
            Methods.Mouse.ButtonMouseHover(minimize, _pictureBoxList);
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxListMaker();
            Methods.Mouse.ButtonMouseLeave(minimize, _pictureBoxList);
        }

        // Close the program by pressing the close button
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void close_MouseHover(object sender, EventArgs e)
        {
            PictureBoxListMaker();
            Methods.Mouse.ButtonMouseHover(close, _pictureBoxList);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxListMaker();
            Methods.Mouse.ButtonMouseLeave(close, _pictureBoxList);
        }
        
        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
        }
        
        private void settingsButton_MouseHover(object sender, EventArgs e)
        {
            PictureBoxListMaker();
            Methods.Mouse.ButtonMouseHover(settingsButton, _pictureBoxList);
        }
        
        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxListMaker();
            Methods.Mouse.ButtonMouseLeave(settingsButton, _pictureBoxList);
        }
        
        private void ok_Click(object sender, EventArgs e)
        {
            OkClick();
        }
        
        private void ok_MouseHover(object sender, EventArgs e)
        {
            PictureBoxListMaker();
            Methods.Mouse.ButtonMouseHover(ok, _pictureBoxList);
        }
        
        private void ok_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxListMaker();
            Methods.Mouse.ButtonMouseLeave(ok, _pictureBoxList);
        }
        
        // Methods
        // Fix flickering while pressing tab
        protected override void WndProc(ref Message m) 
        {
            // Suppress the WM_UPDATEUISTATE message
            if (m.Msg == 0x128) return;
            base.WndProc(ref m);
        }

        // Save current mouse pointer location as long as the form is clicked
        private void PanelMouseDown(MouseEventArgs e)
        {
            _firstPoint = e.Location;
            _mouseIsDown = true;
        }
        
        //Code for clicking on login
        private void LoginClick()
        {
            TextBoxListMaker();
            Methods.Launch.Wizard101(_textBoxList, passwordCheckBox.Checked);
            if (!launcherCheckBox.Checked)
            {
                Close();
            }
        }
        
        //Code for clicking ok on settings
        private void OkClick()
        {
            settingsPanel.Visible = false;
            Methods.Datatable.WriteSettings(passwordCheckBox.Checked, launcherCheckBox.Checked);
            if (passwordCheckBox.Checked) return;
            try
            {
                Methods.Datatable.WritePassword();
            }
            catch
            {
                // ignored
            }

            password.Text = "";
        }
        
        // Make textbox list
        private void TextBoxListMaker()
        {
            _textBoxList = new List<TextBox>
            {
                serverIP,
                username,
                alphaKey,
                password
            };
        }
        
        // Make picturebox list
        private void PictureBoxListMaker()
        {
            _pictureBoxList = new List<PictureBox>
            {
                ok,
                settingsButton,
                minimize,
                close
            };
        }
    }
}