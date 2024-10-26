namespace spoofer.Forms.Misc
{
    partial class OptionWindow
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
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DragBar = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.BaseboardInput = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.CPUInput = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneLabel4 = new Siticone.UI.WinForms.SiticoneLabel();
            this.ChassisInput = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneLabel5 = new Siticone.UI.WinForms.SiticoneLabel();
            this.UUIDInput = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.SaveCustomSerialsButton = new Siticone.UI.WinForms.SiticoneButton();
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
            this.siticoneControlBox1.Location = new System.Drawing.Point(756, -2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 27);
            this.siticoneControlBox1.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(-1, -17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 569);
            this.panel1.TabIndex = 29;
            // 
            // DragBar
            // 
            this.DragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.DragBar.Location = new System.Drawing.Point(12, -2);
            this.DragBar.Name = "DragBar";
            this.DragBar.ShadowDecoration.Parent = this.DragBar;
            this.DragBar.Size = new System.Drawing.Size(803, 27);
            this.DragBar.TabIndex = 28;
            this.DragBar.TabStop = false;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.siticoneLabel1.Location = new System.Drawing.Point(273, 31);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(258, 27);
            this.siticoneLabel1.TabIndex = 31;
            this.siticoneLabel1.Text = "Customsize your Serials";
            // 
            // BaseboardInput
            // 
            this.BaseboardInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BaseboardInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BaseboardInput.DefaultText = "";
            this.BaseboardInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BaseboardInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BaseboardInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BaseboardInput.DisabledState.Parent = this.BaseboardInput;
            this.BaseboardInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BaseboardInput.FillColor = System.Drawing.Color.Black;
            this.BaseboardInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BaseboardInput.FocusedState.Parent = this.BaseboardInput;
            this.BaseboardInput.ForeColor = System.Drawing.Color.White;
            this.BaseboardInput.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BaseboardInput.HoveredState.Parent = this.BaseboardInput;
            this.BaseboardInput.Location = new System.Drawing.Point(41, 128);
            this.BaseboardInput.Name = "BaseboardInput";
            this.BaseboardInput.PasswordChar = '\0';
            this.BaseboardInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BaseboardInput.PlaceholderText = "XXXXXX-XXXXXX";
            this.BaseboardInput.SelectedText = "";
            this.BaseboardInput.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BaseboardInput.ShadowDecoration.Enabled = true;
            this.BaseboardInput.ShadowDecoration.Parent = this.BaseboardInput;
            this.BaseboardInput.Size = new System.Drawing.Size(255, 29);
            this.BaseboardInput.TabIndex = 32;
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel2.Location = new System.Drawing.Point(41, 100);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(81, 22);
            this.siticoneLabel2.TabIndex = 33;
            this.siticoneLabel2.Text = "Baseboard";
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel3.Location = new System.Drawing.Point(41, 170);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(36, 22);
            this.siticoneLabel3.TabIndex = 35;
            this.siticoneLabel3.Text = "CPU";
            // 
            // CPUInput
            // 
            this.CPUInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CPUInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CPUInput.DefaultText = "";
            this.CPUInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CPUInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CPUInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CPUInput.DisabledState.Parent = this.CPUInput;
            this.CPUInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CPUInput.FillColor = System.Drawing.Color.Black;
            this.CPUInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CPUInput.FocusedState.Parent = this.CPUInput;
            this.CPUInput.ForeColor = System.Drawing.Color.White;
            this.CPUInput.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CPUInput.HoveredState.Parent = this.CPUInput;
            this.CPUInput.Location = new System.Drawing.Point(41, 198);
            this.CPUInput.Name = "CPUInput";
            this.CPUInput.PasswordChar = '\0';
            this.CPUInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.CPUInput.PlaceholderText = "XXXXXX-XXXXXX";
            this.CPUInput.SelectedText = "";
            this.CPUInput.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CPUInput.ShadowDecoration.Enabled = true;
            this.CPUInput.ShadowDecoration.Parent = this.CPUInput;
            this.CPUInput.Size = new System.Drawing.Size(255, 29);
            this.CPUInput.TabIndex = 34;
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel4.Location = new System.Drawing.Point(503, 170);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(59, 22);
            this.siticoneLabel4.TabIndex = 37;
            this.siticoneLabel4.Text = "Chassis";
            // 
            // ChassisInput
            // 
            this.ChassisInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ChassisInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChassisInput.DefaultText = "";
            this.ChassisInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ChassisInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ChassisInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ChassisInput.DisabledState.Parent = this.ChassisInput;
            this.ChassisInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ChassisInput.FillColor = System.Drawing.Color.Black;
            this.ChassisInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChassisInput.FocusedState.Parent = this.ChassisInput;
            this.ChassisInput.ForeColor = System.Drawing.Color.White;
            this.ChassisInput.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChassisInput.HoveredState.Parent = this.ChassisInput;
            this.ChassisInput.Location = new System.Drawing.Point(503, 198);
            this.ChassisInput.Name = "ChassisInput";
            this.ChassisInput.PasswordChar = '\0';
            this.ChassisInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ChassisInput.PlaceholderText = "XXXXXX-XXXXXX";
            this.ChassisInput.SelectedText = "";
            this.ChassisInput.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ChassisInput.ShadowDecoration.Enabled = true;
            this.ChassisInput.ShadowDecoration.Parent = this.ChassisInput;
            this.ChassisInput.Size = new System.Drawing.Size(255, 29);
            this.ChassisInput.TabIndex = 36;
            // 
            // siticoneLabel5
            // 
            this.siticoneLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel5.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel5.Location = new System.Drawing.Point(503, 100);
            this.siticoneLabel5.Name = "siticoneLabel5";
            this.siticoneLabel5.Size = new System.Drawing.Size(44, 22);
            this.siticoneLabel5.TabIndex = 39;
            this.siticoneLabel5.Text = "UUID";
            // 
            // UUIDInput
            // 
            this.UUIDInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UUIDInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UUIDInput.DefaultText = "";
            this.UUIDInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UUIDInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UUIDInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UUIDInput.DisabledState.Parent = this.UUIDInput;
            this.UUIDInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UUIDInput.FillColor = System.Drawing.Color.Black;
            this.UUIDInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UUIDInput.FocusedState.Parent = this.UUIDInput;
            this.UUIDInput.ForeColor = System.Drawing.Color.White;
            this.UUIDInput.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UUIDInput.HoveredState.Parent = this.UUIDInput;
            this.UUIDInput.Location = new System.Drawing.Point(503, 128);
            this.UUIDInput.Name = "UUIDInput";
            this.UUIDInput.PasswordChar = '\0';
            this.UUIDInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.UUIDInput.PlaceholderText = "XXXXXX-XXXXXX";
            this.UUIDInput.SelectedText = "";
            this.UUIDInput.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UUIDInput.ShadowDecoration.Enabled = true;
            this.UUIDInput.ShadowDecoration.Parent = this.UUIDInput;
            this.UUIDInput.Size = new System.Drawing.Size(255, 29);
            this.UUIDInput.TabIndex = 38;
            // 
            // SaveCustomSerialsButton
            // 
            this.SaveCustomSerialsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SaveCustomSerialsButton.BorderRadius = 5;
            this.SaveCustomSerialsButton.CheckedState.Parent = this.SaveCustomSerialsButton;
            this.SaveCustomSerialsButton.CustomImages.Parent = this.SaveCustomSerialsButton;
            this.SaveCustomSerialsButton.FillColor = System.Drawing.Color.Teal;
            this.SaveCustomSerialsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveCustomSerialsButton.ForeColor = System.Drawing.Color.White;
            this.SaveCustomSerialsButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SaveCustomSerialsButton.HoveredState.Parent = this.SaveCustomSerialsButton;
            this.SaveCustomSerialsButton.Location = new System.Drawing.Point(277, 252);
            this.SaveCustomSerialsButton.Name = "SaveCustomSerialsButton";
            this.SaveCustomSerialsButton.ShadowDecoration.Parent = this.SaveCustomSerialsButton;
            this.SaveCustomSerialsButton.Size = new System.Drawing.Size(254, 45);
            this.SaveCustomSerialsButton.TabIndex = 40;
            this.SaveCustomSerialsButton.Text = "SAVE";
            this.SaveCustomSerialsButton.Click += new System.EventHandler(this.SaveCustomSerialsButton_Click);
            // 
            // OptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.SaveCustomSerialsButton);
            this.Controls.Add(this.siticoneLabel5);
            this.Controls.Add(this.UUIDInput);
            this.Controls.Add(this.siticoneLabel4);
            this.Controls.Add(this.ChassisInput);
            this.Controls.Add(this.siticoneLabel3);
            this.Controls.Add(this.CPUInput);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.BaseboardInput);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DragBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionWindow";
            ((System.ComponentModel.ISupportInitialize)(this.DragBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticonePictureBox DragBar;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox BaseboardInput;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox CPUInput;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel4;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox ChassisInput;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel5;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox UUIDInput;
        private Siticone.UI.WinForms.SiticoneButton SaveCustomSerialsButton;
    }
}