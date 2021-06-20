namespace W101RLauncher.Forms
{
    partial class W101RLauncherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W101RLauncherForm));
            this.W101RLauncherPanel = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.launcherCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.ok = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.alphaKey = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.serverIP = new System.Windows.Forms.TextBox();
            this.W101RLauncherPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // W101RLauncherPanel
            // 
            this.W101RLauncherPanel.BackColor = System.Drawing.Color.Transparent;
            this.W101RLauncherPanel.BackgroundImage = global::W101RLauncher.Properties.Resources.launcher;
            this.W101RLauncherPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.W101RLauncherPanel.Controls.Add(this.settingsPanel);
            this.W101RLauncherPanel.Controls.Add(this.settingsButton);
            this.W101RLauncherPanel.Controls.Add(this.login);
            this.W101RLauncherPanel.Controls.Add(this.close);
            this.W101RLauncherPanel.Controls.Add(this.minimize);
            this.W101RLauncherPanel.Controls.Add(this.alphaKey);
            this.W101RLauncherPanel.Controls.Add(this.password);
            this.W101RLauncherPanel.Controls.Add(this.username);
            this.W101RLauncherPanel.Controls.Add(this.serverIP);
            this.W101RLauncherPanel.Location = new System.Drawing.Point(0, 0);
            this.W101RLauncherPanel.Name = "W101RLauncherPanel";
            this.W101RLauncherPanel.Size = new System.Drawing.Size(800, 600);
            this.W101RLauncherPanel.TabIndex = 0;
            this.W101RLauncherPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.W101RLauncherPanel_MouseDown);
            this.W101RLauncherPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.W101RLauncherPanel_MouseMove);
            this.W101RLauncherPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.W101RLauncherPanel_MouseUp);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackgroundImage = global::W101RLauncher.Properties.Resources.settings_panel;
            this.settingsPanel.Controls.Add(this.launcherCheckBox);
            this.settingsPanel.Controls.Add(this.passwordCheckBox);
            this.settingsPanel.Controls.Add(this.ok);
            this.settingsPanel.Location = new System.Drawing.Point(210, 230);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(395, 144);
            this.settingsPanel.TabIndex = 13;
            this.settingsPanel.Visible = false;
            // 
            // launcherCheckBox
            // 
            this.launcherCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launcherCheckBox.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launcherCheckBox.ForeColor = System.Drawing.Color.Black;
            this.launcherCheckBox.Location = new System.Drawing.Point(114, 48);
            this.launcherCheckBox.Name = "launcherCheckBox";
            this.launcherCheckBox.Size = new System.Drawing.Size(11, 11);
            this.launcherCheckBox.TabIndex = 3;
            this.launcherCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.launcherCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordCheckBox.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCheckBox.ForeColor = System.Drawing.Color.Black;
            this.passwordCheckBox.Location = new System.Drawing.Point(114, 73);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(11, 11);
            this.passwordCheckBox.TabIndex = 2;
            this.passwordCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.BackgroundImage = global::W101RLauncher.Properties.Resources.ok;
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ok.Location = new System.Drawing.Point(159, 97);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(68, 31);
            this.ok.TabIndex = 0;
            this.ok.TabStop = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            this.ok.MouseLeave += new System.EventHandler(this.ok_MouseLeave);
            this.ok.MouseHover += new System.EventHandler(this.ok_MouseHover);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = global::W101RLauncher.Properties.Resources.settings;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsButton.Location = new System.Drawing.Point(50, 508);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(96, 41);
            this.settingsButton.TabIndex = 12;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseLeave += new System.EventHandler(this.settingsButton_MouseLeave);
            this.settingsButton.MouseHover += new System.EventHandler(this.settingsButton_MouseHover);
            // 
            // login
            // 
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login.Enabled = false;
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.ForeColor = System.Drawing.Color.Transparent;
            this.login.Location = new System.Drawing.Point(647, 503);
            this.login.Name = "login";
            this.login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login.Size = new System.Drawing.Size(104, 49);
            this.login.TabIndex = 11;
            this.login.TabStop = false;
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            this.login.MouseLeave += new System.EventHandler(this.login_MouseLeave);
            this.login.MouseHover += new System.EventHandler(this.login_MouseHover);
            // 
            // close
            // 
            this.close.BackgroundImage = global::W101RLauncher.Properties.Resources.close;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Location = new System.Drawing.Point(765, 15);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(15, 15);
            this.close.TabIndex = 10;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimize.Location = new System.Drawing.Point(747, 15);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(15, 15);
            this.minimize.TabIndex = 9;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover);
            // 
            // alphaKey
            // 
            this.alphaKey.BackColor = System.Drawing.Color.DimGray;
            this.alphaKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaKey.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaKey.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.alphaKey.Location = new System.Drawing.Point(423, 543);
            this.alphaKey.Name = "alphaKey";
            this.alphaKey.Size = new System.Drawing.Size(100, 21);
            this.alphaKey.TabIndex = 4;
            this.alphaKey.TabStop = false;
            this.alphaKey.Text = "Alpha key...";
            this.alphaKey.TextChanged += new System.EventHandler(this.alphaKey_TextChanged);
            this.alphaKey.Enter += new System.EventHandler(this.alphaKey_Enter);
            this.alphaKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphaKey_KeyPress);
            this.alphaKey.Leave += new System.EventHandler(this.alphaKey_Leave);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.DimGray;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.password.Location = new System.Drawing.Point(256, 543);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 21);
            this.password.TabIndex = 3;
            this.password.TabStop = false;
            this.password.Text = "Password...";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.DimGray;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.username.Location = new System.Drawing.Point(423, 490);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 21);
            this.username.TabIndex = 2;
            this.username.TabStop = false;
            this.username.Text = "Username...";
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // serverIP
            // 
            this.serverIP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.serverIP.BackColor = System.Drawing.Color.DimGray;
            this.serverIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverIP.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverIP.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.serverIP.Location = new System.Drawing.Point(256, 490);
            this.serverIP.Name = "serverIP";
            this.serverIP.Size = new System.Drawing.Size(100, 21);
            this.serverIP.TabIndex = 1;
            this.serverIP.TabStop = false;
            this.serverIP.Text = "Server IP...";
            this.serverIP.TextChanged += new System.EventHandler(this.serverIP_TextChanged);
            this.serverIP.Enter += new System.EventHandler(this.serverIP_Enter);
            this.serverIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serverIP_KeyPress);
            this.serverIP.Leave += new System.EventHandler(this.serverIP_Leave);
            // 
            // W101RLauncherForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.W101RLauncherPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W101RLauncherForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Goldenrod;
            this.Load += new System.EventHandler(this.W101RLauncherForm_Load);
            this.W101RLauncherPanel.ResumeLayout(false);
            this.W101RLauncherPanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.CheckBox launcherCheckBox;
        private System.Windows.Forms.CheckBox passwordCheckBox;

        private System.Windows.Forms.PictureBox ok;

        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.Panel settingsPanel;

        private System.Windows.Forms.Panel W101RLauncherPanel;

        private System.Windows.Forms.Button login;

        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;

        private System.Windows.Forms.TextBox alphaKey;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox serverIP;
        private System.Windows.Forms.TextBox username;

        #endregion
    }
}