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
    public partial class UpdateBookDetails : Form
    {
      

        public UpdateBookDetails()
        {
            InitializeComponent();
        }

        private void UpdateBookDetails_Load(object sender, EventArgs e)
        {// GETTING DATA DATAGIRD VIEW
            try
            {
                UpdateBookDB obj = new UpdateBookDB();
                SqlDataReader DR = obj.getbookdata();
                DataTable dt = new DataTable();
                dt.Columns.Add("ISBNNumber");// Sql table colum names
                dt.Columns.Add("BookName");
                dt.Columns.Add("AuthorName");
                dt.Columns.Add("publishedyear");
                dt.Columns.Add("bookprice");
                dt.Columns.Add("Bookcategoery");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Avalableqty");
                dt.Columns.Add("publisherName");
                while (DR.Read())
                {
                    DataRow row = dt.NewRow();
                    row["ISBNNumber"] = DR["ISBNNumber"];// datagird view coulum name and sql table colum name
                    row["BookName"] = DR["BookName"];
                    row["AuthorName"] = DR["AuthorName"];
                    row["publishedyear"] = DR["publishedyear"];
                    row["bookprice"] = DR["bookprice"];
                    row["Bookcategoery"] = DR["Bookcategoery"];
                    row["Quantity"] = DR["Quantity"];
                    row["Avalableqty"] = DR["Avalableqty"];
                    row["publisherName"] = DR["publisherName"];
                    dt.Rows.Add(row);
                }
                dataGridViewBookdetails.DataSource = dt;// Data gird view variable name
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void dataGridViewBookdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {// get selected book details from database and display it text fileds
                String isbn;
                isbn = dataGridViewBookdetails.SelectedCells[0].Value.ToString();
                UpdateBookDB obj = new UpdateBookDB();
                SqlDataReader DR = obj.getgridviewbookdata(isbn);
                DataTable dt = new DataTable();
                //  DataTable dt = new DataTable();
                // dt.Columns.Add("ISBNNumber");
                dt.Columns.Add("BookName");
                dt.Columns.Add("AuthorName");
                dt.Columns.Add("publishedyear");
                dt.Columns.Add("bookprice");
                dt.Columns.Add("Bookcategoery");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("publisherName");

                while (DR.Read())
                {

                    textBoxBookName.Text = DR["BookName"].ToString();
                    textBoxAuthorName.Text = DR["AuthorName"].ToString();
                    textBoxPublishedYear.Text = DR["publishedyear"].ToString();
                    textBoxBookPrice.Text = DR["bookprice"].ToString();
                    comboBoxCategory.Text = DR["Bookcategoery"].ToString();
                   
                    textBoxNumberOfcopies.Text = DR["Quantity"].ToString();
                    textBoxPublisherNmae.Text = DR["publisherName"].ToString();


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          //  if()



            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {//check empty filed
            if (textBoxBookName.Text == "")
            {
                MessageBox.Show("Book Name cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (textBoxAuthorName.Text == "")
            {
                MessageBox.Show("Author Name cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPublishedYear.Text == "")
            {
                MessageBox.Show("Published year cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxBookPrice.Text == "")
            {
                MessageBox.Show("Price cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxNumberOfcopies.Text == "")
            {
                MessageBox.Show("Published year cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPublisherNmae.Text == "")
            {
                MessageBox.Show("Publisher name cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {// update book details
                UpdateBookDB obj = new UpdateBookDB();
                String isbn;
                isbn = dataGridViewBookdetails.SelectedCells[0].Value.ToString();
                obj.ISBNNO1 = isbn;
                obj.Bookname = textBoxBookName.Text;
                obj.AuthorName1 = textBoxAuthorName.Text;
                obj.Publishedyr = Convert.ToInt32(textBoxPublishedYear.Text);
                obj.Bookprice = Convert.ToDouble(textBoxBookPrice.Text);
                // combobox1 = comboBoxCategory.SelectedItem.ToString();
                obj.Bookcategory = comboBoxCategory.Text;
                obj.Numofcopy = Convert.ToInt32(textBoxNumberOfcopies.Text);
                obj.Pulishname = textBoxPublisherNmae.Text;
                obj.Updatebookdetails(obj);
                //refreh datagird view
                try
                {
                    UpdateBookDB objU = new UpdateBookDB();
                    SqlDataReader DR = objU.getbookdata();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ISBNNumber");
                    dt.Columns.Add("BookName");
                    dt.Columns.Add("AuthorName");
                    dt.Columns.Add("publishedyear");
                    dt.Columns.Add("bookprice");
                    dt.Columns.Add("Bookcategoery");
                    dt.Columns.Add("Quantity");
                    dt.Columns.Add("Avalableqty");
                    dt.Columns.Add("publisherName");

                    while (DR.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["ISBNNumber"] = DR["ISBNNumber"];
                        row["BookName"] = DR["BookName"];
                        row["AuthorName"] = DR["AuthorName"];
                        row["publishedyear"] = DR["publishedyear"];
                        row["bookprice"] = DR["bookprice"];
                        row["Bookcategoery"] = DR["Bookcategoery"];
                        row["Quantity"] = DR["Quantity"];
                        row["Avalableqty"] = DR["Avalableqty"];
                        row["publisherName"] = DR["publisherName"];
                        dt.Rows.Add(row);
                    }
                    dataGridViewBookdetails.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            //clear text fileds
            textBoxBookName.Text ="";
            textBoxAuthorName.Text = "";
            textBoxPublishedYear.Text = "";
            textBoxBookPrice.Text = "";
            textBoxNumberOfcopies.Text = "";
            textBoxPublisherNmae.Text = "";



        }

        private void textBoxPublisherNmae_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewBookdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearchbook_KeyUp(object sender, KeyEventArgs e)
        {// serach book name from sql database
            try
            {
                UpdateBookDB obj = new UpdateBookDB();
                SqlDataReader DR = obj.SearchBook(textBoxSearchbook.Text);
                DataTable dt = new DataTable();
                dt.Columns.Add("ISBNNumber");
                dt.Columns.Add("BookName");
                dt.Columns.Add("AuthorName");
                dt.Columns.Add("publishedyear");
                dt.Columns.Add("bookprice");
                dt.Columns.Add("Bookcategoery");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Avalableqty");
                dt.Columns.Add("publisherName");

                while (DR.Read())
                {
                    DataRow row = dt.NewRow();
                    row["ISBNNumber"] = DR["ISBNNumber"];
                    row["BookName"] = DR["BookName"];
                    row["AuthorName"] = DR["AuthorName"];
                    row["publishedyear"] = DR["publishedyear"];
                    row["bookprice"] = DR["bookprice"];
                    row["Bookcategoery"] = DR["Bookcategoery"];
                    row["Quantity"] = DR["Quantity"];
                    row["Avalableqty"] = DR["Avalableqty"];
                    row["publisherName"] = DR["publisherName"];
                    dt.Rows.Add(row);
                }
                dataGridViewBookdetails.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {// delete button coding
            UpdateBookDB obj = new UpdateBookDB();
            String isbn;
            isbn = dataGridViewBookdetails.SelectedCells[0].Value.ToString();
            obj.ISBNNO1 = isbn;
            obj.DeleteBook(obj);

            try
            {
                UpdateBookDB objU = new UpdateBookDB();
                SqlDataReader DR = objU.getbookdata();
                DataTable dt = new DataTable();
                dt.Columns.Add("ISBNNumber");
                dt.Columns.Add("BookName");
                dt.Columns.Add("AuthorName");
                dt.Columns.Add("publishedyear");
                dt.Columns.Add("bookprice");
                dt.Columns.Add("Bookcategoery");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Avalableqty");
                dt.Columns.Add("publisherName");

                while (DR.Read())
                {
                    DataRow row = dt.NewRow();
                    row["ISBNNumber"] = DR["ISBNNumber"];
                    row["BookName"] = DR["BookName"];
                    row["AuthorName"] = DR["AuthorName"];
                    row["publishedyear"] = DR["publishedyear"];
                    row["bookprice"] = DR["bookprice"];
                    row["Bookcategoery"] = DR["Bookcategoery"];
                    row["Quantity"] = DR["Quantity"];
                    row["Avalableqty"] = DR["Avalableqty"];
                    row["publisherName"] = DR["publisherName"];
                    dt.Rows.Add(row);
                }
                dataGridViewBookdetails.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // clear text fileds
            textBoxBookName.Text = "";
            textBoxAuthorName.Text = "";
            textBoxPublishedYear.Text = "";
            textBoxBookPrice.Text = "";
            textBoxNumberOfcopies.Text = "";
            textBoxPublisherNmae.Text = "";









        }

        private void Back_Click(object sender, EventArgs e)
        {// back button
            Libraryanform f = new Libraryanform();
            f.Show();
            this.Hide();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
