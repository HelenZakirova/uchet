using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uchet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status Win = new status();
            Win.Owner = this;
            this.Hide();
            Win.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            peoples Win = new peoples();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list Win = new list();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            workers Win = new workers();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login Win = new login();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            positions Win = new positions();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
    }
}
