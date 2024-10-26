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
    public partial class OptionWindow : Form
    {
        public OptionWindow()
        {
            InitializeComponent();
        }

        private void SaveCustomSerialsButton_Click(object sender, EventArgs e)
        {
           spoofer.MainForm.setCustomSerials(BaseboardInput.Text, UUIDInput.Text, ChassisInput.Text, CPUInput.Text);
            this.Close();
        }
    }
}
