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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receiptsDataSet = new Receipts.ReceiptsDataSet();
            this.partsOfFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsOfFoodTableAdapter = new Receipts.ReceiptsDataSetTableAdapters.PartsOfFoodTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energyOnGramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementUnitsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOfFoodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ингредиенты";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(550, 285);
            this.dataGridView1.TabIndex = 3;
            // 
            // receiptsDataSet
            // 
            this.receiptsDataSet.DataSetName = "ReceiptsDataSet";
            this.receiptsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsOfFoodBindingSource
            // 
            this.partsOfFoodBindingSource.DataMember = "PartsOfFood";
            this.partsOfFoodBindingSource.DataSource = this.receiptsDataSet;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "PartOfFood";
            this.Text = "PartOfFood";
            this.Load += new System.EventHandler(this.PartOfFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOfFoodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReceiptsDataSet receiptsDataSet;
        private System.Windows.Forms.BindingSource partsOfFoodBindingSource;
        private ReceiptsDataSetTableAdapters.PartsOfFoodTableAdapter partsOfFoodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energyOnGramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementUnitsIdDataGridViewTextBoxColumn;
    }
}