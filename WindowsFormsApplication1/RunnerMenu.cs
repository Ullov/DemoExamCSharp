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
    public partial class RunnerMenu : Form
    {
        DateTime endTime = new DateTime(2020, 1, 1);
        public RunnerMenu()
        {
            InitializeComponent();
            TimerHandler th = new TimerHandler(label4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string text = "Для получения дополнительной информации пожалуйста свяжитесь с координаторами\n\nТелефон: +55 11 9988 7766\nEmail: coordinators@marathonskills.org";
            CustomMessageBoxTextOnly cmbto = new CustomMessageBoxTextOnly();
            cmbto.title = "Контакты";
            cmbto.text = text;
        }
    }
}
