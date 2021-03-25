
namespace test
{
    partial class OrderForm
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
            this.oIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPRODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShopDataSet = new test.EShopDataSet();
            this.orderedTableAdapter = new test.EShopDataSetTableAdapters.OrderedTableAdapter();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIDDataGridViewTextBoxColumn,
            this.oPRODDataGridViewTextBoxColumn,
            this.oSUMDataGridViewTextBoxColumn,
            this.oCLIENTDataGridViewTextBoxColumn,
            this.oDATEDataGridViewTextBoxColumn,
            this.oNUMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // oIDDataGridViewTextBoxColumn
            // 
            this.oIDDataGridViewTextBoxColumn.DataPropertyName = "O_ID";
            this.oIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.oIDDataGridViewTextBoxColumn.Name = "oIDDataGridViewTextBoxColumn";
            this.oIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oPRODDataGridViewTextBoxColumn
            // 
            this.oPRODDataGridViewTextBoxColumn.DataPropertyName = "O_PROD";
            this.oPRODDataGridViewTextBoxColumn.HeaderText = "Код товара";
            this.oPRODDataGridViewTextBoxColumn.Name = "oPRODDataGridViewTextBoxColumn";
            // 
            // oSUMDataGridViewTextBoxColumn
            // 
            this.oSUMDataGridViewTextBoxColumn.DataPropertyName = "O_SUM";
            this.oSUMDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
            this.oSUMDataGridViewTextBoxColumn.Name = "oSUMDataGridViewTextBoxColumn";
            // 
            // oCLIENTDataGridViewTextBoxColumn
            // 
            this.oCLIENTDataGridViewTextBoxColumn.DataPropertyName = "O_CLIENT";
            this.oCLIENTDataGridViewTextBoxColumn.HeaderText = "ID Клиента";
            this.oCLIENTDataGridViewTextBoxColumn.Name = "oCLIENTDataGridViewTextBoxColumn";
            // 
            // oDATEDataGridViewTextBoxColumn
            // 
            this.oDATEDataGridViewTextBoxColumn.DataPropertyName = "O_DATE";
            this.oDATEDataGridViewTextBoxColumn.HeaderText = "Дата-время";
            this.oDATEDataGridViewTextBoxColumn.Name = "oDATEDataGridViewTextBoxColumn";
            // 
            // oNUMDataGridViewTextBoxColumn
            // 
            this.oNUMDataGridViewTextBoxColumn.DataPropertyName = "O_NUM";
            this.oNUMDataGridViewTextBoxColumn.HeaderText = "Номер отправления";
            this.oNUMDataGridViewTextBoxColumn.Name = "oNUMDataGridViewTextBoxColumn";
            // 
            // orderedBindingSource
            // 
            this.orderedBindingSource.DataMember = "Ordered";
            this.orderedBindingSource.DataSource = this.eShopDataSet;
            // 
            // eShopDataSet
            // 
            this.eShopDataSet.DataSetName = "EShopDataSet";
            this.eShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderedTableAdapter
            // 
            this.orderedTableAdapter.ClearBeforeFill = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(428, 264);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(90, 27);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "Найти";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(653, 264);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(90, 27);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Text = "Выход";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(225, 264);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 27);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(58, 264);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 27);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public EShopDataSet eShopDataSet;
        public System.Windows.Forms.BindingSource orderedBindingSource;
        public EShopDataSetTableAdapters.OrderedTableAdapter orderedTableAdapter;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPRODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oNUMDataGridViewTextBoxColumn;
    }
}