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
    public partial class ViewBookForm : Form
    {
        public ViewBookForm()
        {
            InitializeComponent();
        }

        private void ViewBookForm_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateBookDB obj = new UpdateBookDB();
                SqlDataReader DR = obj.getbookdata();
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

        private void dataGridViewBookdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearchbook_KeyUp(object sender, KeyEventArgs e)
        {
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

        private void label8_Click(object sender, EventArgs e)
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
