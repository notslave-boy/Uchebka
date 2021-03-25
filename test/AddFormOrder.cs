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
    public partial class AddFormOrder : Form
    {
        public AddFormOrder()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            OrderForm main = this.Owner as OrderForm;
            if (main != null)
            {
                DataRow nRow = main.eShopDataSet.Tables[4].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = tbProd.Text;
                nRow[1] = tbSum.Text;
                nRow[2] = tbClient.Text;
                nRow[3] = tbDate.Text;
                nRow[4] = tbNum.Text;
                main.eShopDataSet.Tables[4].Rows.Add(nRow);
                main.orderedTableAdapter.Update(main.eShopDataSet.Ordered);
                main.eShopDataSet.Tables[4].AcceptChanges();
                main.dataGridView1.Refresh();
                tbProd.Text     = "";
                tbSum.Text      = "";
                tbClient.Text   = "";
                tbDate.Text     = "";
                tbNum.Text      = "";
            }
        }
    }
}
