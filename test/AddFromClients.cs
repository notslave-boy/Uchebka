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
    public partial class AddFromClients : Form
    {
        public AddFromClients()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ClientsForm main = this.Owner as ClientsForm;
            if (main != null)
            {
                DataRow nRow = main.eShopDataSet.Tables[1].NewRow();
                int rc = main.dataGridView2.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                nRow[2] = tbMail.Text;
                nRow[3] = tbSex.Text;
                nRow[4] = tbPhone.Text;
                nRow[5] = tbPassp.Text;
                nRow[6] = tbAddr.Text;
                main.eShopDataSet.Tables[1].Rows.Add(nRow);
                main.clientsTableAdapter.Update(main.eShopDataSet.Clients);
                main.eShopDataSet.Tables[1].AcceptChanges();
                main.dataGridView2.Refresh();
                tbName.Text = "";
                tbMail.Text = "";
                tbSex.Text  = "";
                tbPhone.Text = "";
                tbPassp.Text = "";
                tbAddr.Text = "";
            }
        } 
    }
}
