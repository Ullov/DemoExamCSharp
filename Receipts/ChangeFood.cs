﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Receipts
{
    public partial class ChangeFood : Form
    {
        Timer timer;
        Dictionary<int, string> currentPartsOfFoodInfo = new Dictionary<int, string>();
        public ChangeFood()
        {
            InitializeComponent();

            label6.Visible = false;
            DbHandler dbh = new DbHandler();
            dbh.addItemsToComboBox(comboBox3, 0, 1, "HowPrepare", 2);
            dbh.addItemsToComboBox(comboBox1, 0, 1, "MeasurementUnits", -1);
            dbh.addItemsToComboBox(comboBox2, 0, 1, "PartsOfFood", -1);
            dbh.addItemsToComboBox(comboBox4, 0, 2, "Food", -1);
            currentPartsOfFoodInfo = dbh.refreshListBox(listBox1, "foodChange", (int)comboBox4.SelectedValue);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbHandler dbh = new DbHandler();
            currentPartsOfFoodInfo = dbh.refreshListBox(listBox1, "foodChange", (int)comboBox4.SelectedValue);
            //dbh.serializePartsOfFood(currentPartsOfFoodInfo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt((int)listBox1.SelectedIndex);
            foreach (var item in currentPartsOfFoodInfo.Where(kvp => kvp.Value == (string)listBox1.SelectedItem).ToList())
            {
                currentPartsOfFoodInfo.Remove(item.Key);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = textBox2.Text;
            int tmpKey = (int)comboBox2.SelectedValue;
            currentPartsOfFoodInfo.Add(tmpKey, tmp);
            textBox2.Text = "";
            listBox1.Items.Add(tmp + " x " + comboBox2.GetItemText(comboBox2.SelectedItem));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbHandler dbh = new DbHandler();
            dbh.write("insert into Food (measurementUnitsId, howPrepareId, partsOfFood) values ('" + comboBox1.SelectedValue + "','" + comboBox3.SelectedValue + "','" + dbh.serializePartsOfFood(currentPartsOfFoodInfo) + "')");
            listBox1.Items.Clear();
            label6.Visible = true;
            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += hideLabel;
            timer.Start();
        }

        private void hideLabel(object sender, EventArgs e)
        {
            label6.Visible = false;
            timer.Stop();
        }
    }
}
