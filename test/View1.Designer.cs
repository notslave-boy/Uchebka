
namespace test
{
    partial class View1
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
            this.eShopDataSet1 = new test.EShopDataSet1();
            this.orderedClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderedClientsTableAdapter = new test.EShopDataSet1TableAdapters.OrderedClientsTableAdapter();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedClientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.клиентDataGridViewTextBoxColumn,
            this.товарDataGridViewTextBoxColumn,
            this.суммаЗаказаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderedClientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // eShopDataSet1
            // 
            this.eShopDataSet1.DataSetName = "EShopDataSet1";
            this.eShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderedClientsBindingSource
            // 
            this.orderedClientsBindingSource.DataMember = "OrderedClients";
            this.orderedClientsBindingSource.DataSource = this.eShopDataSet1;
            // 
            // orderedClientsTableAdapter
            // 
            this.orderedClientsTableAdapter.ClearBeforeFill = true;
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            // 
            // товарDataGridViewTextBoxColumn
            // 
            this.товарDataGridViewTextBoxColumn.DataPropertyName = "Товар";
            this.товарDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.товарDataGridViewTextBoxColumn.Name = "товарDataGridViewTextBoxColumn";
            // 
            // суммаЗаказаDataGridViewTextBoxColumn
            // 
            this.суммаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Сумма заказа";
            this.суммаЗаказаDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
            this.суммаЗаказаDataGridViewTextBoxColumn.Name = "суммаЗаказаDataGridViewTextBoxColumn";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(605, 269);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(132, 41);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View1";
            this.Text = "View1";
            this.Load += new System.EventHandler(this.View1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedClientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EShopDataSet1 eShopDataSet1;
        private System.Windows.Forms.BindingSource orderedClientsBindingSource;
        private EShopDataSet1TableAdapters.OrderedClientsTableAdapter orderedClientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn товарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CloseBtn;
    }
}