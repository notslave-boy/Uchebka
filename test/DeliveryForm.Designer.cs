
namespace test
{
    partial class DeliveryForm
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
            this.dDEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dWHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShopDataSet = new test.EShopDataSet();
            this.deliveryTableAdapter = new test.EShopDataSetTableAdapters.DeliveryTableAdapter();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dDEPDataGridViewTextBoxColumn,
            this.dWHDataGridViewTextBoxColumn,
            this.dORDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliveryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // dDEPDataGridViewTextBoxColumn
            // 
            this.dDEPDataGridViewTextBoxColumn.DataPropertyName = "D_DEP";
            this.dDEPDataGridViewTextBoxColumn.HeaderText = "Номер отправления";
            this.dDEPDataGridViewTextBoxColumn.Name = "dDEPDataGridViewTextBoxColumn";
            this.dDEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dWHDataGridViewTextBoxColumn
            // 
            this.dWHDataGridViewTextBoxColumn.DataPropertyName = "D_WH";
            this.dWHDataGridViewTextBoxColumn.HeaderText = "Номер склада";
            this.dWHDataGridViewTextBoxColumn.Name = "dWHDataGridViewTextBoxColumn";
            // 
            // dORDDataGridViewTextBoxColumn
            // 
            this.dORDDataGridViewTextBoxColumn.DataPropertyName = "D_ORD";
            this.dORDDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.dORDDataGridViewTextBoxColumn.Name = "dORDDataGridViewTextBoxColumn";
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.eShopDataSet;
            // 
            // eShopDataSet
            // 
            this.eShopDataSet.DataSetName = "EShopDataSet";
            this.eShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(60, 285);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 27);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(227, 285);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 27);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(655, 285);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(90, 27);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Выход";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(430, 285);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(90, 27);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Найти";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeliveryForm";
            this.Text = "Доставка";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public EShopDataSet eShopDataSet;
        public System.Windows.Forms.BindingSource deliveryBindingSource;
        public EShopDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dWHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}