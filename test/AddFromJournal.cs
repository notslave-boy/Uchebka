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
    public partial class AddFromJournal : Form
    {
        public AddFromJournal()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            JournalForm main = this.Owner as JournalForm;
            if (main != null)
            {
                DataRow nRow = main.eShopDataSet.Tables[3].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = tbID.Text;
                nRow[1] = tbClient.Text;
                nRow[2] = tbNum.Text;
                nRow[3] = tbSum.Text;
                nRow[4] = tbDate.Text;
                main.eShopDataSet.Tables[3].Rows.Add(nRow);
                main.journalTableAdapter.Update(main.eShopDataSet.Journal);
                main.eShopDataSet.Tables[3].AcceptChanges();
                main.dataGridView1.Refresh();
                tbID.Text       = "";
                tbClient.Text   = "";
                tbNum.Text      = "";
                tbSum.Text      = "";
                tbDate.Text     = "";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
