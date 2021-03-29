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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eShopDataSet1.OrderedClients". При необходимости она может быть перемещена или удалена.
            this.orderedClientsTableAdapter.Fill(this.eShopDataSet1.OrderedClients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eShopDataSet.Assortment". При необходимости она может быть перемещена или удалена.
            this.assortmentTableAdapter.Fill(this.eShopDataSet.Assortment);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            assortmentTableAdapter.Update(eShopDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
