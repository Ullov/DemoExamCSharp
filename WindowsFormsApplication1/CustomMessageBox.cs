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
    public partial class CustomMessageBox : Form
    {
        public Bitmap bmp;
        public string text;
        public CustomMessageBox()
        {
            InitializeComponent();

            //Bitmap bmp = new Bitmap(Resource1.arise_logo);
        }

        private void CustomMessageBox_Shown(object sender, EventArgs e)
        {
            pictureBox1.Image = bmp;
            label1.Text = text;
        }
    }
}
