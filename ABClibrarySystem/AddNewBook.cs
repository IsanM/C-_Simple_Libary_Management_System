using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABClibrarySystem
{
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {// save button coding
            if (textBoxRegisternumber.Text == "")
            {
                MessageBox.Show("Insert ISBN Number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxBookName.Text == "")
            {
                MessageBox.Show("Insert Book name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxAuthorName.Text == "")
            {
                MessageBox.Show("Insert Author  name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPublishedyear.Text == "")
            {
                MessageBox.Show("Insert published year", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPrice.Text == "")
            {
                MessageBox.Show("Insert Book price", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxNumberOfCopies.Text == "")
            {
                MessageBox.Show("Insert number of copy", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPublisherName.Text == "")
            {
                MessageBox.Show("Insert publisher name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // finding duplicate values

                try
                {
                    AddNewBookDB objt = new  AddNewBookDB();
                    //obj.NICNumber1 = textBoxNICNumber.Text;
                    SqlDataReader DR = objt.SearchDuplicatevalues(textBoxRegisternumber.Text);
                    SqlCommand cmd = new SqlCommand();
                    int count = 0;
                    while (DR.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("This ID is Alradey in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                         AddNewBookDB obj = new AddNewBookDB();
                  obj.ISBNNO1 = textBoxRegisternumber.Text;
                  obj.Bookname = textBoxBookName.Text;
                  obj.AuthorName1 = textBoxAuthorName.Text;
                  obj.Publishedyr = Convert.ToInt32(textBoxPublishedyear.Text);
                  obj.Bookprice = Convert.ToDouble(textBoxPrice.Text);
                  //String combo = comboBoxCategory.SelectedItem.ToString();
                  obj.Bookcategory = comboBoxCategory.Text;
                  obj.Numofcopy = Convert.ToInt32(textBoxNumberOfCopies.Text);
                  obj.Pulishname = textBoxPublisherName.Text;
                  // MessageBox.Show("Save Sucessfull!");
                  obj.addbookdetails(obj);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRegisternumber.Text = "";
            textBoxBookName.Text = "";
            textBoxAuthorName.Text = "";
            textBoxPublishedyear.Text = "";
            textBoxPrice.Text = "";
            textBoxNumberOfCopies.Text = "";
            textBoxPublisherName.Text = "";
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPublishedyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void textBoxNumberOfCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Libraryanform f = new Libraryanform();
            f.Show();
            this.Hide();

        }
    }
}
