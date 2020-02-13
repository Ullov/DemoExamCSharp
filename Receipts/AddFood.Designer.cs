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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.demoExamDbDataSet = new Receipts.demoExamDbDataSet();
            this.partsOfFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsOfFoodTableAdapter = new Receipts.demoExamDbDataSetTableAdapters.PartsOfFoodTableAdapter();
            this.howToPrepareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.howToPrepareTableAdapter = new Receipts.demoExamDbDataSetTableAdapters.HowToPrepareTableAdapter();
            this.measurementUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.measurementUnitsTableAdapter = new Receipts.demoExamDbDataSetTableAdapters.MeasurementUnitsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.demoExamDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOfFoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.howToPrepareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementUnitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.measurementUnitsBindingSource;
            this.comboBox1.DisplayMember = "unit";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 20);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 19);
            this.textBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Еденица измерения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Способ приготовления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ингредиенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Название";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.partsOfFoodBindingSource;
            this.comboBox2.DisplayMember = "nname";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(194, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(278, 20);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "id";
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.howToPrepareBindingSource;
            this.comboBox3.DisplayMember = "nname";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(194, 58);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(278, 20);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.ValueMember = "id";
            // 
            // demoExamDbDataSet
            // 
            this.demoExamDbDataSet.DataSetName = "demoExamDbDataSet";
            this.demoExamDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsOfFoodBindingSource
            // 
            this.partsOfFoodBindingSource.DataMember = "PartsOfFood";
            this.partsOfFoodBindingSource.DataSource = this.demoExamDbDataSet;
            // 
            // partsOfFoodTableAdapter
            // 
            this.partsOfFoodTableAdapter.ClearBeforeFill = true;
            // 
            // howToPrepareBindingSource
            // 
            this.howToPrepareBindingSource.DataMember = "HowToPrepare";
            this.howToPrepareBindingSource.DataSource = this.demoExamDbDataSet;
            // 
            // howToPrepareTableAdapter
            // 
            this.howToPrepareTableAdapter.ClearBeforeFill = true;
            // 
            // measurementUnitsBindingSource
            // 
            this.measurementUnitsBindingSource.DataMember = "MeasurementUnits";
            this.measurementUnitsBindingSource.DataSource = this.demoExamDbDataSet;
            // 
            // measurementUnitsTableAdapter
            // 
            this.measurementUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.button1.Location = new System.Drawing.Point(168, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 158);
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
            this.Load += new System.EventHandler(this.AddFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demoExamDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOfFoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.howToPrepareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementUnitsBindingSource)).EndInit();
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
        private demoExamDbDataSet demoExamDbDataSet;
        private System.Windows.Forms.BindingSource partsOfFoodBindingSource;
        private demoExamDbDataSetTableAdapters.PartsOfFoodTableAdapter partsOfFoodTableAdapter;
        private System.Windows.Forms.BindingSource howToPrepareBindingSource;
        private demoExamDbDataSetTableAdapters.HowToPrepareTableAdapter howToPrepareTableAdapter;
        private System.Windows.Forms.BindingSource measurementUnitsBindingSource;
        private demoExamDbDataSetTableAdapters.MeasurementUnitsTableAdapter measurementUnitsTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}