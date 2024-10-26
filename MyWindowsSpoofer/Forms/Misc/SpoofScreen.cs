using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spoofer
{
    public partial class SpoofScreen : Form
    {
     
       
        public SpoofScreen()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
           
        }

        internal void ChangeProgressValue(int value)
        {
            bunifuCircleProgress1.Value = value;
        }

    }
}
