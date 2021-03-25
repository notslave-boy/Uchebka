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
    public partial class AddFormDelivery : Form
    {
        public AddFormDelivery()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DeliveryForm main = this.Owner as DeliveryForm;
            if (main != null)
            {
                DataRow nRow = main.eShopDataSet.Tables[2].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = tbDep.Text;
                nRow[1] = tbWh.Text;
                nRow[2] = tbOrder.Text;
                main.eShopDataSet.Tables[2].Rows.Add(nRow);
                main.deliveryTableAdapter.Update(main.eShopDataSet.Delivery);
                main.eShopDataSet.Tables[2].AcceptChanges();
                main.dataGridView1.Refresh();
                tbDep.Text = "";
                tbWh.Text = "";
                tbOrder.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
