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
    public partial class ChangePartsOfFood : Form
    {
        public ChangePartsOfFood()
        {
            InitializeComponent();

            DbHandler dbh = new DbHandler();
            dbh.addItemsToComboBox(comboBox2, 0, 1, "HowPrepare", 2, false);
            dbh.addItemsToComboBox(comboBox1, 0, 1, "MeasurementUnits", -1);
            dbh.addItemsToComboBox(comboBox1, 0, 1, "MeasurementUnits", -1);
        }
    }
}
