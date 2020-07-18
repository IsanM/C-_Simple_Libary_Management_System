using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABClibrarySystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {// log out
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }
        private void lablelogout_Click(object sender, EventArgs e)
        {// log out
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }
        private void buttonAddNewAdmin_Click(object sender, EventArgs e)
        {// add new admin
           AddNewAdmin   f = new AddNewAdmin();
            f.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {//update admin
            UpdateAdmin f = new UpdateAdmin();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddLibariyan_Click(object sender, EventArgs e)
        {// add new libariyan
            AddLibariyan      f = new AddLibariyan();
            f.Show();
            this.Hide();
        }

        private void buttonUpdteLibariyan_Click(object sender, EventArgs e)
        {// update libariyan
           UpdateLibariyanDetail f = new UpdateLibariyanDetail();
            f.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
