using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receipts
{
    public partial class PartOfFood : Form
    {
        public PartOfFood()
        {
            InitializeComponent();
        }

        private void PartOfFood_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "receiptsDataSet.PartsOfFood". При необходимости она может быть перемещена или удалена.
            this.partsOfFoodTableAdapter.Fill(this.receiptsDataSet.PartsOfFood);
        }
    }
}
