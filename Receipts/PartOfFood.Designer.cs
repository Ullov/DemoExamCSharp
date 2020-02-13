namespace Receipts
{
    partial class PartOfFood
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.demoExamDbDataSet = new Receipts.demoExamDbDataSet();
            this.demoExamDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsOfFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsOfFoodTableAdapter = new Receipts.demoExamDbDataSetTableAdapters.PartsOfFoodTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energyOnGramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementUnitsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoExamDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoExamDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOfFoodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.energyOnGramDataGridViewTextBoxColumn,
            this.measurementUnitsIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partsOfFoodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(550, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // demoExamDbDataSet
            // 
            this.demoExamDbDataSet.DataSetName = "demoExamDbDataSet";
            this.demoExamDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // demoExamDbDataSetBindingSource
            // 
            this.demoExamDbDataSetBindingSource.DataSource = this.demoExamDbDataSet;
            this.demoExamDbDataSetBindingSource.Position = 0;
            // 
            // partsOfFoodBindingSource
            // 
            this.partsOfFoodBindingSource.DataMember = "PartsOfFood";
            this.partsOfFoodBindingSource.DataSource = this.demoExamDbDataSetBindingSource;
            // 
            // partsOfFoodTableAdapter
            // 
            this.partsOfFoodTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nnameDataGridViewTextBoxColumn
            // 
            this.nnameDataGridViewTextBoxColumn.DataPropertyName = "nname";
            this.nnameDataGridViewTextBoxColumn.HeaderText = "nname";
            this.nnameDataGridViewTextBoxColumn.Name = "nnameDataGridViewTextBoxColumn";
            this.nnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // energyOnGramDataGridViewTextBoxColumn
            // 
            this.energyOnGramDataGridViewTextBoxColumn.DataPropertyName = "energyOnGram";
            this.energyOnGramDataGridViewTextBoxColumn.HeaderText = "energyOnGram";
            this.energyOnGramDataGridViewTextBoxColumn.Name = "energyOnGramDataGridViewTextBoxColumn";
            this.energyOnGramDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measurementUnitsIdDataGridViewTextBoxColumn
            // 
            this.measurementUnitsIdDataGridViewTextBoxColumn.DataPropertyName = "measurementUnitsId";
            this.measurementUnitsIdDataGridViewTextBoxColumn.HeaderText = "measurementUnitsId";
            this.measurementUnitsIdDataGridViewTextBoxColumn.Name = "measurementUnitsIdDataGridViewTextBoxColumn";
            this.measurementUnitsIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PartOfFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 312);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PartOfFood";
            this.Text = "PartOfFood";
            this.Load += new System.EventHandler(this.PartOfFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoExamDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoExamDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOfFoodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource demoExamDbDataSetBindingSource;
        private demoExamDbDataSet demoExamDbDataSet;
        private System.Windows.Forms.BindingSource partsOfFoodBindingSource;
        private demoExamDbDataSetTableAdapters.PartsOfFoodTableAdapter partsOfFoodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energyOnGramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementUnitsIdDataGridViewTextBoxColumn;
    }
}