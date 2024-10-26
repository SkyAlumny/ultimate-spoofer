using spoofer.Forms.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spoofer
{
    public partial class Loading : Form
    {
       

        public Loading()
        {
            InitializeComponent();
            LoadingTimer.Start();

        }

        LoginForm login = new LoginForm();
        SpoofScreen screen = new SpoofScreen();
        OptionWindow optionWindow = new OptionWindow();
        InfoBox InfoBox = new InfoBox();
        tty_protection ttyprotection = new tty_protection();

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPanel_Click(object sender, EventArgs e)
        {

        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {

            Loadingbar.Value += 1;
            if (Loadingbar.Value == 20)
            {

                ttyprotection.executeProtection();
                login.Show();
                login.Hide();
            }
            if (Loadingbar.Value == 50)
            {
                optionWindow.Show();
                optionWindow.Hide();
                ttyprotection.executeProtection();
              
            }
            if (Loadingbar.Value == 70)
            {
                InfoBox.Show();
                InfoBox.Hide();
                ttyprotection.executeProtection();

            }
            if (Loadingbar.Value == 90)
            {
                screen.Show();
                screen.Hide();
                ttyprotection.executeProtection();
            }
            if (Loadingbar.Value == 100)
            {
                LoadingTimer.Stop();
                ttyprotection.executeProtection();
                this.Hide();
                login.Show();
            }
        }

      
    }
}
