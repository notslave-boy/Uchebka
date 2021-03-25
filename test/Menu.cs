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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AssortmentBtnOpen_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Owner = this;
            form1.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientsAddBtn_Click(object sender, EventArgs e)
        {
            ClientsForm cf = new ClientsForm();
            cf.Owner = this;
            cf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeliveryForm df = new DeliveryForm();
            df.Owner = this;
            df.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JournalForm jf = new JournalForm();
            jf.Owner = this;
            jf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderForm of = new OrderForm();
            of.Owner = this;
            of.Show();
        }
    }
}
