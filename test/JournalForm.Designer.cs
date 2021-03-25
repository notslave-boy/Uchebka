
namespace test
{
    partial class JournalForm
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
            this.eShopDataSet = new test.EShopDataSet();
            this.journalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalTableAdapter = new test.EShopDataSetTableAdapters.JournalTableAdapter();
            this.jIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jSUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jIDDataGridViewTextBoxColumn,
            this.jCLIENTDataGridViewTextBoxColumn,
            this.jNUMDataGridViewTextBoxColumn,
            this.jSUMDataGridViewTextBoxColumn,
            this.jDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.journalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(65, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // eShopDataSet
            // 
            this.eShopDataSet.DataSetName = "EShopDataSet";
            this.eShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journalBindingSource
            // 
            this.journalBindingSource.DataMember = "Journal";
            this.journalBindingSource.DataSource = this.eShopDataSet;
            // 
            // journalTableAdapter
            // 
            this.journalTableAdapter.ClearBeforeFill = true;
            // 
            // jIDDataGridViewTextBoxColumn
            // 
            this.jIDDataGridViewTextBoxColumn.DataPropertyName = "J_ID";
            this.jIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.jIDDataGridViewTextBoxColumn.Name = "jIDDataGridViewTextBoxColumn";
            this.jIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jCLIENTDataGridViewTextBoxColumn
            // 
            this.jCLIENTDataGridViewTextBoxColumn.DataPropertyName = "J_CLIENT";
            this.jCLIENTDataGridViewTextBoxColumn.HeaderText = "ID Клиента";
            this.jCLIENTDataGridViewTextBoxColumn.Name = "jCLIENTDataGridViewTextBoxColumn";
            // 
            // jNUMDataGridViewTextBoxColumn
            // 
            this.jNUMDataGridViewTextBoxColumn.DataPropertyName = "J_NUM";
            this.jNUMDataGridViewTextBoxColumn.HeaderText = "Номер отправления";
            this.jNUMDataGridViewTextBoxColumn.Name = "jNUMDataGridViewTextBoxColumn";
            // 
            // jSUMDataGridViewTextBoxColumn
            // 
            this.jSUMDataGridViewTextBoxColumn.DataPropertyName = "J_SUM";
            this.jSUMDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
            this.jSUMDataGridViewTextBoxColumn.Name = "jSUMDataGridViewTextBoxColumn";
            // 
            // jDATEDataGridViewTextBoxColumn
            // 
            this.jDATEDataGridViewTextBoxColumn.DataPropertyName = "J_DATE";
            this.jDATEDataGridViewTextBoxColumn.HeaderText = "Дата-время";
            this.jDATEDataGridViewTextBoxColumn.Name = "jDATEDataGridViewTextBoxColumn";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(431, 244);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(90, 27);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "Найти";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(656, 244);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(90, 27);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Text = "Выход";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(228, 244);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 27);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(61, 244);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 27);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JournalForm";
            this.Text = "JournalForm";
            this.Load += new System.EventHandler(this.JournalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public EShopDataSet eShopDataSet;
        public System.Windows.Forms.BindingSource journalBindingSource;
        public EShopDataSetTableAdapters.JournalTableAdapter journalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jSUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}