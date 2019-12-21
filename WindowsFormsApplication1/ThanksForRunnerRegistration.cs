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
    public partial class ThanksForRunnerRegistration : Form
    {
        DateTime endTime = new DateTime(2020, 1, 1);
        public ThanksForRunnerRegistration()
        {
            InitializeComponent();

            Timer t = new Timer();
            t.Interval = 500;
            t.Tick += new EventHandler(tTick);
            TimeSpan ts = endTime.Subtract(DateTime.Now);
            label4.Text = ts.ToString("d' дней 'hh' часов и 'mm' минут до старта марафона'");
            t.Start();
        }

        void tTick(object sender, EventArgs e)
        {
            TimeSpan ts = endTime.Subtract(DateTime.Now);
            label4.Text = ts.ToString("d' дней 'hh' часов и 'mm' минут до старта марафона'");
        }
    }
}
