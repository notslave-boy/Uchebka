using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.eShopDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = AsName.Text;
                nRow[2] = AsCost.Text;
                nRow[3] = AsCount.Text;
                main.eShopDataSet.Tables[0].Rows.Add(nRow);
                main.assortmentTableAdapter.Update(main.eShopDataSet.Assortment);
                main.eShopDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                AsName.Text = "";
                AsCost.Text = "";
                AsCount.Text = "";
            }
        }
    }
}
