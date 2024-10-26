using Auth;
using Authmain;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spoofer
{
    public partial class LoginForm : Form
    {
        tty_system ttysystem = new tty_system();
        tty_protection ttyprotection = new tty_protection();
        public static api auth = new api(
        name: StructureDecryption.AuthStructureDecryption.Decrypt(AuthenticationStructure.AuthInformation[1]),
        ownerid: StructureDecryption.AuthStructureDecryption.Decrypt(AuthenticationStructure.AuthInformation[3]),
        secret: StructureDecryption.AuthStructureDecryption.Decrypt(AuthenticationStructure.AuthInformation[2]),
        version: StructureDecryption.AuthStructureDecryption.Decrypt(AuthenticationStructure.AuthInformation[4]));

        public LoginForm()
        {
            InitializeComponent();
            RegisterPanel.Visible = false;
            LoginPanel.Visible = true;
            ttysystem.SetRPC("Logging in");
            AuthenticationObject.AuthInstance.init();
            LoginInputUsername.Text = Properties.Settings.Default["username"].ToString();
            LoginInputPassword.Text = Properties.Settings.Default["password"].ToString();
        }

       

        private async void LoginButton_Click(object sender, EventArgs e)
        {
 
            LoginButton.Text = "Logging in..";
            LoginButton.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(1));
            ttyprotection.executeProtection();
            MainForm mainForm = new MainForm();
            AuthenticationInput.Username = LoginInputUsername.Text;
            AuthenticationInput.Password = LoginInputPassword.Text;
            AuthenticationObject.AuthInstance.login(AuthenticationInput.Username, AuthenticationInput.Password);
            if (AuthenticationObject.AuthInstance.response.success)
            {
                if(AuthenticationObject.AuthInstance.checkblack())
                {
                    File.Create("YOU ARE BANNED");
                    Environment.Exit(0);
                }
                LoginButton.Text = "Loading...";
                ttyprotection.SecureStringInMemory(LoginInputUsername.Text);
                ttyprotection.SecureStringInMemory(LoginInputPassword.Text);
                Properties.Settings.Default["username"] = LoginInputUsername.Text;
                Properties.Settings.Default["password"] = LoginInputPassword.Text;
                Properties.Settings.Default.Save();
                LoginInputUsername.Text = null;
                LoginInputPassword.Text = null;
                await Task.Delay(500);
                this.Hide();
                mainForm.Show();
            }
            else
            {
                ttysystem.ShowInfo("Logging in failed! Error: \n" + AuthenticationObject.AuthInstance.response.message);
                LoginButton.Text = "LOGIN";

            }
        }

        private void TORegiserSwitch_Click(object sender, EventArgs e)
        {
            if (!RegisterPanel.Visible || LoginPanel.Visible)
            {
                RegisterPanel.Visible = true;
                LoginPanel.Visible = false;
                TORegiserSwitch.ForeColor = Color.Cyan;
                TOLoginSwitch.ForeColor = Color.White;
            }
        }

        private void TOLoginSwitch_Click(object sender, EventArgs e)
        {
            if (!LoginPanel.Visible || RegisterPanel.Visible)
            {
                LoginPanel.Visible = true;
                RegisterPanel.Visible = false;
                TOLoginSwitch.ForeColor = Color.Cyan;
                TORegiserSwitch.ForeColor = Color.White;
            }
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
   
            RegisterButton.Text = "Creating Account...";
            RegisterButton.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(1));
            ttyprotection.executeProtection();
            MainForm mainForm = new MainForm();
            AuthenticationInput.Username = RegisterInputUsername.Text;
            AuthenticationInput.Password = RegisterInputPassword.Text;
            AuthenticationInput.License = RegisterInputKey.Text;
            AuthenticationObject.AuthInstance.register(AuthenticationInput.Username, AuthenticationInput.Password, AuthenticationInput.License);
            if (AuthenticationObject.AuthInstance.response.success)
            {
                RegisterButton.Text = "Logging in...";
                ttyprotection.SecureStringInMemory(RegisterInputUsername.Text);
                ttyprotection.SecureStringInMemory(RegisterInputPassword.Text);
                ttyprotection.SecureStringInMemory(RegisterInputKey.Text);
                Properties.Settings.Default["username"] = RegisterInputUsername.Text;
                Properties.Settings.Default["password"] = RegisterInputPassword.Text;
                Properties.Settings.Default.Save();
                RegisterInputUsername.Text = null;
                RegisterInputPassword.Text = null;
                RegisterInputKey.Text = null;
                AuthenticationObject.AuthInstance.setvar("coins", ttysystem.getWebInfo("coinsonregister"));
                mainForm.Show();
                mainForm.Hide();
                await Task.Delay(500);
                this.Hide();
                mainForm.Show();
            }
            else
            {
                ttysystem.ShowInfo("Creating your account failed! Error: \n" + AuthenticationObject.AuthInstance.response.message);
                RegisterButton.Text = "REGISTER";

            }

           
        }

        
    }
}
