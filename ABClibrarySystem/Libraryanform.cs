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
    public partial class Libraryanform : Form
    {
        public Libraryanform()
        {
            InitializeComponent();
        }

        private void Libraryanform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAddnewbook_Click(object sender, EventArgs e)
        { // display add new book interface
            AddNewBook f = new AddNewBook();
            f.Show();
            this.Hide();
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {// display update book interface
            UpdateBookDetails f = new UpdateBookDetails();
            f.Show();
            this.Hide();
        }

        private void buttonViewBook_Click(object sender, EventArgs e)
        {// display view book interface
            ViewBookForm f = new ViewBookForm();
            f.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {// display login interface
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {// display add new member interface
            AddNewMember f = new AddNewMember();
            f.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {// display update member interface
            UpdateMember f = new UpdateMember();
            f.Show();
            this.Hide();
        }

        private void buttonViewMember_Click(object sender, EventArgs e)
        {// display view member interface
            ViewMemberForm f = new ViewMemberForm();
            f.Show();
            this.Hide();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {// log out the system
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }

        private void lablelogout_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }

        private void buttonViewIsuebok_Click(object sender, EventArgs e)
        {//display manage issue book interface 
            ManageIssueBook f = new ManageIssueBook();
            f.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
