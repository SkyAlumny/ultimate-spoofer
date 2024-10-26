namespace spoofer
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.LoginPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.Loadingbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.TitleLoginLabel = new System.Windows.Forms.Label();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.Animator = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginPanel.BackgroundImage")));
            this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginPanel.BorderRadius = 2;
            this.LoginPanel.Controls.Add(this.Loadingbar);
            this.LoginPanel.Controls.Add(this.siticonePictureBox1);
            this.LoginPanel.Controls.Add(this.TitleLoginLabel);
            this.LoginPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginPanel.GradientTopLeft = System.Drawing.Color.Black;
            this.LoginPanel.GradientTopRight = System.Drawing.Color.Black;
            this.LoginPanel.Location = new System.Drawing.Point(-1, -14);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Quality = 10;
            this.LoginPanel.Size = new System.Drawing.Size(633, 280);
            this.LoginPanel.TabIndex = 11;
            this.LoginPanel.Click += new System.EventHandler(this.LoginPanel_Click);
            // 
            // Loadingbar
            // 
            this.Loadingbar.FillColor = System.Drawing.Color.Teal;
            this.Loadingbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadingbar.ForeColor = System.Drawing.Color.CadetBlue;
            this.Loadingbar.Location = new System.Drawing.Point(3, 235);
            this.Loadingbar.Name = "Loadingbar";
            this.Loadingbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Loadingbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Loadingbar.ShadowDecoration.BorderRadius = 10;
            this.Loadingbar.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.Loadingbar.ShadowDecoration.Enabled = true;
            this.Loadingbar.ShowText = true;
            this.Loadingbar.Size = new System.Drawing.Size(630, 30);
            this.Loadingbar.TabIndex = 9;
            this.Loadingbar.Text = "Loadingbar";
            this.Loadingbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.Loadingbar.UseTransparentBackground = true;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.Location = new System.Drawing.Point(252, 80);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(136, 104);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 8;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.Click += new System.EventHandler(this.siticonePictureBox1_Click);
            // 
            // TitleLoginLabel
            // 
            this.TitleLoginLabel.AutoSize = true;
            this.TitleLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TitleLoginLabel.Location = new System.Drawing.Point(239, 23);
            this.TitleLoginLabel.Name = "TitleLoginLabel";
            this.TitleLoginLabel.Size = new System.Drawing.Size(160, 31);
            this.TitleLoginLabel.TabIndex = 0;
            this.TitleLoginLabel.Text = "WELCOME";
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Enabled = true;
            this.LoadingTimer.Interval = 35;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // Animator
            // 
            this.Animator.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.Animator.TargetForm = this;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 252);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel LoginPanel;
        private System.Windows.Forms.Label TitleLoginLabel;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Guna.UI2.WinForms.Guna2ProgressBar Loadingbar;
        private System.Windows.Forms.Timer LoadingTimer;
        private Guna.UI2.WinForms.Guna2AnimateWindow Animator;
    }
}