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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    main.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                        if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }

            ClientsForm second = this.Owner as ClientsForm;
            if (second != null)
            {
                for (int i = 0; i < second.dataGridView2.RowCount; i++)
                {
                    second.dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < second.dataGridView2.ColumnCount; j++)
                        if (second.dataGridView2.Rows[i].Cells[j].Value != null)
                            if (second.dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                second.dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                }
            }

            DeliveryForm df = this.Owner as DeliveryForm;
            if (df != null)
            {
                for (int i = 0; i < df.dataGridView1.RowCount; i++)
                {
                    df.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < df.dataGridView1.ColumnCount; j++)
                        if (df.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (df.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                df.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }

            JournalForm jf = this.Owner as JournalForm;
            if (jf != null)
            {
                for (int i = 0; i < jf.dataGridView1.RowCount; i++)
                {
                    jf.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < jf.dataGridView1.ColumnCount; j++)
                        if (jf.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (jf.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                jf.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }

            OrderForm of = this.Owner as OrderForm;
            if (of != null)
            {
                for (int i = 0; i < of.dataGridView1.RowCount; i++)
                {
                    of.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < of.dataGridView1.ColumnCount; j++)
                        if (of.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (of.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                of.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
