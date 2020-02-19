namespace Receipts
{
    partial class AddFood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.measurementUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptsDataSet = new Receipts.ReceiptsDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.partsOfFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.measurementUnitsTableAdapter = new Receipts.ReceiptsDataSetTableAdapters.MeasurementUnitsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.howPrepareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.howPrepareTableAdapter = new Receipts.ReceiptsDataSetTableAdapters.HowPrepareTableAdapter();
            this.partsOfFoodTableAdapter = new Receipts.ReceiptsDataSetTableAdapters.PartsOfFoodTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.measurementUnitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOfFoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.howPrepareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 20);
            this.comboBox1.TabIndex = 20;
            // 
            // measurementUnitsBindingSource
            // 
            this.measurementUnitsBindingSource.DataMember = "MeasurementUnits";
            this.measurementUnitsBindingSource.DataSource = this.receiptsDataSet;
            // 
            // receiptsDataSet
            // 
            this.receiptsDataSet.DataSetName = "ReceiptsDataSet";
            this.receiptsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 19);
            this.textBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Еденица измерения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Способ приготовления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ингредиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Название";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(613, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 20);
            this.comboBox2.TabIndex = 21;
            // 
            // partsOfFoodBindingSource
            // 
            this.partsOfFoodBindingSource.DataMember = "PartsOfFood";
            this.partsOfFoodBindingSource.DataSource = this.receiptsDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(194, 38);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(223, 20);
            this.comboBox3.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.button1.Location = new System.Drawing.Point(194, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить блюдо";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // measurementUnitsTableAdapter
            // 
            this.measurementUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Количество ингредиента";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Блюдо сохранено";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.button2.Location = new System.Drawing.Point(512, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 31);
            this.button2.TabIndex = 27;
            this.button2.Text = "Добавить ингредиент в блюдо";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(613, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 19);
            this.textBox2.TabIndex = 28;
            // 
            // howPrepareBindingSource
            // 
            this.howPrepareBindingSource.DataMember = "HowPrepare";
            this.howPrepareBindingSource.DataSource = this.receiptsDataSet;
            // 
            // howPrepareTableAdapter
            // 
            this.howPrepareTableAdapter.ClearBeforeFill = true;
            // 
            // partsOfFoodTableAdapter
            // 
            this.partsOfFoodTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(427, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 100);
            this.listBox1.TabIndex = 29;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 233);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddFood";
            this.Text = "AddFood";
            ((System.ComponentModel.ISupportInitialize)(this.measurementUnitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOfFoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.howPrepareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private ReceiptsDataSet receiptsDataSet;
        private System.Windows.Forms.BindingSource measurementUnitsBindingSource;
        private ReceiptsDataSetTableAdapters.MeasurementUnitsTableAdapter measurementUnitsTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource howPrepareBindingSource;
        private ReceiptsDataSetTableAdapters.HowPrepareTableAdapter howPrepareTableAdapter;
        private System.Windows.Forms.BindingSource partsOfFoodBindingSource;
        private ReceiptsDataSetTableAdapters.PartsOfFoodTableAdapter partsOfFoodTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
    }
}