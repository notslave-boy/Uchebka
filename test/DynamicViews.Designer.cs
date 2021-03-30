
namespace test
{
    partial class DynamicViews
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
            this.button1 = new System.Windows.Forms.Button();
            this.assortmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShopDataSet = new test.EShopDataSet();
            this.assortmentTableAdapter = new test.EShopDataSetTableAdapters.AssortmentTableAdapter();
            this.eShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costAssortmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShopDataSet2 = new test.EShopDataSet2();
            this.costAssortmentTableAdapter = new test.EShopDataSet2TableAdapters.CostAssortmentTableAdapter();
            this.nToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.tbInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.assortmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costAssortmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet2)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "узбек";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // assortmentBindingSource
            // 
            this.assortmentBindingSource.DataMember = "Assortment";
            this.assortmentBindingSource.DataSource = this.eShopDataSet;
            // 
            // eShopDataSet
            // 
            this.eShopDataSet.DataSetName = "EShopDataSet";
            this.eShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assortmentTableAdapter
            // 
            this.assortmentTableAdapter.ClearBeforeFill = true;
            // 
            // eShopDataSetBindingSource
            // 
            this.eShopDataSetBindingSource.DataSource = this.eShopDataSet;
            this.eShopDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.costAssortmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(170, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 108);
            this.dataGridView1.TabIndex = 5;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // costAssortmentBindingSource
            // 
            this.costAssortmentBindingSource.DataMember = "CostAssortment";
            this.costAssortmentBindingSource.DataSource = this.eShopDataSet2;
            // 
            // eShopDataSet2
            // 
            this.eShopDataSet2.DataSetName = "EShopDataSet2";
            this.eShopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costAssortmentTableAdapter
            // 
            this.costAssortmentTableAdapter.ClearBeforeFill = true;
            // 
            // nToolStripLabel
            // 
            this.nToolStripLabel.Name = "nToolStripLabel";
            this.nToolStripLabel.Size = new System.Drawing.Size(17, 22);
            this.nToolStripLabel.Text = "n:";
            // 
            // nToolStripTextBox
            // 
            this.nToolStripTextBox.Name = "nToolStripTextBox";
            this.nToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.nToolStripTextBox.Text = "250";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nToolStripLabel,
            this.nToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 425);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 6;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(153, 247);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(87, 20);
            this.tbInput.TabIndex = 7;
            // 
            // DynamicViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "DynamicViews";
            this.Text = "DynamicViews";
            this.Load += new System.EventHandler(this.DynamicViews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assortmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costAssortmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopDataSet2)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EShopDataSet eShopDataSet;
        private System.Windows.Forms.BindingSource assortmentBindingSource;
        private EShopDataSetTableAdapters.AssortmentTableAdapter assortmentTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource eShopDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource costAssortmentBindingSource;
        private EShopDataSet2 eShopDataSet2;
        private EShopDataSet2TableAdapters.CostAssortmentTableAdapter costAssortmentTableAdapter;
        private System.Windows.Forms.ToolStripLabel nToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.TextBox tbInput;
    }
}