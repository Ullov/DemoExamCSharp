using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class ChasityList : Form
    {
        public ChasityList()
        {
            InitializeComponent();
            TimerHandler th = new TimerHandler(label4);

            listView1.Columns.Add("Icon", 120);
            listView1.Columns.Add("Description", 200);
            listView1.Columns.Add("Description", 400);
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(64, 64);
            imgList.Images.Add("1", Resource1.arise_logo);
            imgList.Images.Add("2", Resource1.aves_do_brazil_logo);
            imgList.Images.Add("3", Resource1.clara_santos_oliveira_institute_logo);
            imgList.Images.Add("4", Resource1.conquer_cancer_brazil);
            imgList.Images.Add("5", Resource1.diabetes_brazil_logo);
            imgList.Images.Add("6", Resource1.heart_health_sao_paulo_logo);
            imgList.Images.Add("7", Resource1.human_rights_centre_logo);
            imgList.Images.Add("8", Resource1.oxfam_international_logo);
            imgList.Images.Add("9", Resource1.querstadtein_logo);
            imgList.Images.Add("10", Resource1.save_the_children_fund_logo);
            imgList.Images.Add("11", Resource1.stay_pumped_logo);
            imgList.Images.Add("12", Resource1.the_red_cross_logo);
            imgList.Images.Add("13", Resource1.upbeat_logo);
            imgList.Images.Add("14", Resource1.wwsm_rescue_logo);
            listView1.SmallImageList = imgList;
            DatabaseHandler dh = new DatabaseHandler();
            SqlDataReader sdr = dh.read("select * from Charity");
            for (int i = 0; i < 14; i++)
            {
                sdr.Read();
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(sdr[1].ToString());
                lvi.SubItems.Add(sdr[2].ToString());
                lvi.ImageIndex = i;
                listView1.Items.Add(lvi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
