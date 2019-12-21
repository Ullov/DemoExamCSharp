using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CustomMessageBoxTextOnly : Form
    {
        public string title;
        public string text;
        public CustomMessageBoxTextOnly()
        {
            InitializeComponent();
        }

        private void CustomMessageBoxTextOnly_Shown(object sender, EventArgs e)
        {
            label1.Text = text;
            label2.Text = title;
        }
    }
}
