using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spoofer.Forms.Misc
{
    public partial class InfoBox : Form
    {
        public InfoBox()
        {
            InitializeComponent();
        }


        internal bool ChangeInfoText(string InfoText)
        {
            InfoTextBox.Text = InfoText;
            return true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
