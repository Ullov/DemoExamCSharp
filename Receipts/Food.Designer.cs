namespace Receipts
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.demoExamDbDataSet = new Receipts.demoExamDbDataSet();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTableAdapter = new Receipts.demoExamDbDataSetTableAdapters.FoodTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementUnitsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsOfFoodAndNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wayOfPreparingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoExamDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Блюда";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.measurementUnitsIdDataGridViewTextBoxColumn,
            this.partsOfFoodAndNumberDataGridViewTextBoxColumn,
            this.nnameDataGridViewTextBoxColumn,
            this.wayOfPreparingIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.foodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(560, 200);
            this.dataGridView1.TabIndex = 2;
            // 
            // demoExamDbDataSet
            // 
            this.demoExamDbDataSet.DataSetName = "demoExamDbDataSet";
            this.demoExamDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "Food";
            this.foodBindingSource.DataSource = this.demoExamDbDataSet;
            // 
            // foodTableAdapter
            // 
            this.foodTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measurementUnitsIdDataGridViewTextBoxColumn
            // 
            this.measurementUnitsIdDataGridViewTextBoxColumn.DataPropertyName = "measurementUnitsId";
            this.measurementUnitsIdDataGridViewTextBoxColumn.HeaderText = "measurementUnitsId";
            this.measurementUnitsIdDataGridViewTextBoxColumn.Name = "measurementUnitsIdDataGridViewTextBoxColumn";
            this.measurementUnitsIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partsOfFoodAndNumberDataGridViewTextBoxColumn
            // 
            this.partsOfFoodAndNumberDataGridViewTextBoxColumn.DataPropertyName = "partsOfFoodAndNumber";
            this.partsOfFoodAndNumberDataGridViewTextBoxColumn.HeaderText = "partsOfFoodAndNumber";
            this.partsOfFoodAndNumberDataGridViewTextBoxColumn.Name = "partsOfFoodAndNumberDataGridViewTextBoxColumn";
            this.partsOfFoodAndNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nnameDataGridViewTextBoxColumn
            // 
            this.nnameDataGridViewTextBoxColumn.DataPropertyName = "nname";
            this.nnameDataGridViewTextBoxColumn.HeaderText = "nname";
            this.nnameDataGridViewTextBoxColumn.Name = "nnameDataGridViewTextBoxColumn";
            this.nnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wayOfPreparingIdDataGridViewTextBoxColumn
            // 
            this.wayOfPreparingIdDataGridViewTextBoxColumn.DataPropertyName = "wayOfPreparingId";
            this.wayOfPreparingIdDataGridViewTextBoxColumn.HeaderText = "wayOfPreparingId";
            this.wayOfPreparingIdDataGridViewTextBoxColumn.Name = "wayOfPreparingIdDataGridViewTextBoxColumn";
            this.wayOfPreparingIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoExamDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private demoExamDbDataSet demoExamDbDataSet;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private demoExamDbDataSetTableAdapters.FoodTableAdapter foodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementUnitsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsOfFoodAndNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wayOfPreparingIdDataGridViewTextBoxColumn;
    }
}

