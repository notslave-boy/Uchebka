
namespace test
{
    partial class ClientsForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADDRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eShopDataSet = new test.EShopDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new test.EShopDataSetTableAdapters.ClientsTableAdapter();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.cNAMEDataGridViewTextBoxColumn,
            this.cPOSTDataGridViewTextBoxColumn,
            this.cSEXDataGridViewTextBoxColumn,
            this.cTELDataGridViewTextBoxColumn,
            this.cPASSDataGridViewTextBoxColumn,
            this.cADDRDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.clientsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(782, 208);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNAMEDataGridViewTextBoxColumn
            // 
            this.cNAMEDataGridViewTextBoxColumn.DataPropertyName = "C_NAME";
            this.cNAMEDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.cNAMEDataGridViewTextBoxColumn.Name = "cNAMEDataGridViewTextBoxColumn";
            // 
            // cPOSTDataGridViewTextBoxColumn
            // 
            this.cPOSTDataGridViewTextBoxColumn.DataPropertyName = "C_POST";
            this.cPOSTDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.cPOSTDataGridViewTextBoxColumn.Name = "cPOSTDataGridViewTextBoxColumn";
            // 
            // cSEXDataGridViewTextBoxColumn
            // 
            this.cSEXDataGridViewTextBoxColumn.DataPropertyName = "C_SEX";
            this.cSEXDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.cSEXDataGridViewTextBoxColumn.Name = "cSEXDataGridViewTextBoxColumn";
            // 
            // cTELDataGridViewTextBoxColumn
            // 
            this.cTELDataGridViewTextBoxColumn.DataPropertyName = "C_TEL";
            this.cTELDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.cTELDataGridViewTextBoxColumn.Name = "cTELDataGridViewTextBoxColumn";
            // 
            // cPASSDataGridViewTextBoxColumn
            // 
            this.cPASSDataGridViewTextBoxColumn.DataPropertyName = "C_PASS";
            this.cPASSDataGridViewTextBoxColumn.HeaderText = "Паспортные данные";
            this.cPASSDataGridViewTextBoxColumn.Name = "cPASSDataGridViewTextBoxColumn";
            // 
            // cADDRDataGridViewTextBoxColumn
            // 
            this.cADDRDataGridViewTextBoxColumn.DataPropertyName = "C_ADDR";
            this.cADDRDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.cADDRDataGridViewTextBoxColumn.Name = "cADDRDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.eShopDataSet;
            // 
            // eShopDataSet
            // 
            this.eShopDataSet.DataSetName = "EShopDataSet";
            this.eShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.eShopDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(46, 298);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 27);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(260, 298);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 27);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(456, 298);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(90, 27);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Найти";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(652, 298);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(90, 27);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Выход";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ClientsForm";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2;
        public EShopDataSet eShopDataSet;
        public System.Windows.Forms.BindingSource clientsBindingSource;
        public EShopDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDRDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button CloseBtn;
        public System.Windows.Forms.BindingSource clientsBindingSource1;
    }
}