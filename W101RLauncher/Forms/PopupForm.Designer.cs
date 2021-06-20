using System.ComponentModel;

namespace W101RLauncher.Forms
{
    sealed partial class PopupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ok = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.ok)).BeginInit();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.Transparent;
            this.ok.BackgroundImage = global::W101RLauncher.Properties.Resources.ok;
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ok.Location = new System.Drawing.Point(163, 92);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(68, 31);
            this.ok.TabIndex = 0;
            this.ok.TabStop = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            this.ok.MouseLeave += new System.EventHandler(this.ok_MouseLeave);
            this.ok.MouseHover += new System.EventHandler(this.ok_MouseHover);
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(395, 144);
            this.ControlBox = false;
            this.Controls.Add(this.ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PopupForm";
            this.TransparencyKey = System.Drawing.Color.Goldenrod;
            ((System.ComponentModel.ISupportInitialize) (this.ok)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox ok;

        #endregion
    }
}