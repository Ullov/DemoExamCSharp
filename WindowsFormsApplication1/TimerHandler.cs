using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class TimerHandler
    {
        private Label lab;
        DateTime endTime;
        public TimerHandler(Label label)
        {
            lab = label;
            endTime = new DateTime(2020, 1, 1);
            Timer t = new Timer();
            t.Interval = 500;
            t.Tick += new EventHandler(tTick);
            TimeSpan ts = endTime.Subtract(DateTime.Now);
            lab.Text = ts.ToString("d' дней 'hh' часов и 'mm' минут до старта марафона'");
            t.Start();

            lab.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void tTick(object sender, EventArgs e)
        {
            TimeSpan ts = endTime.Subtract(DateTime.Now);
            lab.Text = ts.ToString("d' дней 'hh' часов и 'mm' минут до старта марафона'");
        }
    }
}
