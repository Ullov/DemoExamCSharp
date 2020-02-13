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
    public partial class AddFood : Form
    {
        private string partsOfFood = "";
        public AddFood()
        {
            InitializeComponent();
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExamDbDataSet.MeasurementUnits". При необходимости она может быть перемещена или удалена.
            this.measurementUnitsTableAdapter.Fill(this.demoExamDbDataSet.MeasurementUnits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExamDbDataSet.HowToPrepare". При необходимости она может быть перемещена или удалена.
            this.howToPrepareTableAdapter.Fill(this.demoExamDbDataSet.HowToPrepare);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExamDbDataSet.PartsOfFood". При необходимости она может быть перемещена или удалена.
            this.partsOfFoodTableAdapter.Fill(this.demoExamDbDataSet.PartsOfFood);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbHandler dbh = new DbHandler();
            dbh.write("insert into Food (measurementUnit, partsOfFoodAndNumber, nname, wayOfPreparingId) values ('" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + textBox1.Text + "','" + comboBox3.SelectedValue + "')");
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            partsOfFood += comboBox2.SelectedValue + ",";
        }
    }
}
