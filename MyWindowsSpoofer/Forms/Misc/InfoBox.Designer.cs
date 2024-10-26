namespace spoofer.Forms.Misc
{
    partial class InfoBox
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
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.DragBar = new Siticone.UI.WinForms.SiticonePictureBox();
            this.TitleLoginLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoTextBox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.DragController = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.LoginButton = new Siticone.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.DragBar)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(390, -2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 27);
            this.siticoneControlBox1.TabIndex = 27;
            // 
            // DragBar
            // 
            this.DragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.DragBar.Location = new System.Drawing.Point(12, -2);
            this.DragBar.Name = "DragBar";
            this.DragBar.ShadowDecoration.Parent = this.DragBar;
            this.DragBar.Size = new System.Drawing.Size(423, 27);
            this.DragBar.TabIndex = 25;
            this.DragBar.TabStop = false;
            // 
            // TitleLoginLabel
            // 
            this.TitleLoginLabel.AutoSize = true;
            this.TitleLoginLabel.BackColor = System.Drawing.Color.Black;
            this.TitleLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TitleLoginLabel.Location = new System.Drawing.Point(193, 28);
            this.TitleLoginLabel.Name = "TitleLoginLabel";
            this.TitleLoginLabel.Size = new System.Drawing.Size(84, 31);
            this.TitleLoginLabel.TabIndex = 24;
            this.TitleLoginLabel.Text = "INFO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(-5, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 377);
            this.panel1.TabIndex = 26;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.AcceptsReturn = true;
            this.InfoTextBox.AcceptsTab = true;
            this.InfoTextBox.AllowDrop = true;
            this.InfoTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InfoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InfoTextBox.DefaultText = "";
            this.InfoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InfoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InfoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InfoTextBox.DisabledState.Parent = this.InfoTextBox;
            this.InfoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InfoTextBox.FillColor = System.Drawing.Color.Black;
            this.InfoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InfoTextBox.FocusedState.Parent = this.InfoTextBox;
            this.InfoTextBox.ForeColor = System.Drawing.Color.White;
            this.InfoTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InfoTextBox.HoveredState.Parent = this.InfoTextBox;
            this.InfoTextBox.Location = new System.Drawing.Point(32, 62);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.PasswordChar = '\0';
            this.InfoTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.InfoTextBox.PlaceholderText = "";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.SelectedText = "";
            this.InfoTextBox.ShadowDecoration.Parent = this.InfoTextBox;
            this.InfoTextBox.Size = new System.Drawing.Size(391, 116);
            this.InfoTextBox.TabIndex = 29;
            this.InfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DragController
            // 
            this.DragController.TargetControl = this.DragBar;
            // 
            // LoginButton
            // 
            this.LoginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoginButton.BorderRadius = 5;
            this.LoginButton.CheckedState.Parent = this.LoginButton;
            this.LoginButton.CustomImages.Parent = this.LoginButton;
            this.LoginButton.FillColor = System.Drawing.Color.Teal;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoginButton.HoveredState.Parent = this.LoginButton;
            this.LoginButton.Location = new System.Drawing.Point(95, 193);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.ShadowDecoration.Parent = this.LoginButton;
            this.LoginButton.Size = new System.Drawing.Size(254, 45);
            this.LoginButton.TabIndex = 30;
            this.LoginButton.Text = "OK";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // InfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(433, 254);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.TitleLoginLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DragBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "w";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.DragBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticonePictureBox DragBar;
        private System.Windows.Forms.Label TitleLoginLabel;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox InfoTextBox;
        private Siticone.UI.WinForms.SiticoneDragControl DragController;
        private Siticone.UI.WinForms.SiticoneButton LoginButton;
    }
}