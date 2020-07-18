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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }
        

        private void MemberForm_Load(object sender, EventArgs e)
        {
           // get member id login form
            textBoxMemberid.Text =LoginForm.passingtext ;
            //get member name
            try
            {
                MemberDB obj = new MemberDB();
                SqlDataReader dtr = obj.getMemberInfo(textBoxMemberid.Text);
                SqlCommand cmd = new SqlCommand();
                while (dtr.Read())
                {
                    textBoxMemberName.Text = dtr["FristName"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //auto  genaratd id
            try
            {
                MemberDB obj = new MemberDB();
                SqlDataReader DR = obj.getAutogenaratedid();
                SqlCommand cmd = new SqlCommand();
                while (DR.Read())
                {
                    textBoxIssueid.Text = DR["IssueID"].ToString();

                }
                int i = int.Parse(textBoxIssueid.Text);
                i = i + 1;
                textBoxIssueid.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // get booktble details
            try
            {
                MemberDB objt = new MemberDB();
                SqlDataReader dr = objt.getbooklist();
                DataTable dt = new DataTable();
                dt.Columns.Add("ISBNNumber");
                dt.Columns.Add("BookName");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Avalableqty");

                while (dr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["ISBNNumber"] = dr["ISBNNumber"];
                    row["BookName"] = dr["BookName"];
                    row["Quantity"] = dr["Quantity"];
                    row["Avalableqty"] = dr["Avalableqty"];
                    dt.Rows.Add(row);

                }
                dataGridViewBookname.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //get issue table details
            try
            {

                MemberDB obj = new MemberDB();
                SqlDataReader dr = obj.getissueBooktable();
                DataTable dt = new DataTable();
                dt.Columns.Add("IssueID");
                dt.Columns.Add("BookName");
                dt.Columns.Add("MemberName");
                dt.Columns.Add("IssueDate");
                dt.Columns.Add("ReturnDate");
                dt.Columns.Add("MemberID");
                while (dr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["IssueID"] = dr["IssueID"];
                    row["BookName"] = dr["BookName"];
                    row["MemberName"] = dr["MemberName"];
                    row["IssueDate"] = dr["IssueDate"];
                    row["ReturnDate"] = dr["ReturnDate"];
                    row["MemberID"] = dr["MemberID"];
                    dt.Rows.Add(row);

                }
                dataGridViewReturnbook.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewBookname_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonIssueBook_Click(object sender, EventArgs e)
        { // issue button
            int avalaleqty = 0;
            MemberDB objct = new MemberDB();
            SqlDataReader drt = objct.getbooklist();
            DataTable dtr = new DataTable();
            dtr.Columns.Add("Avalableqty");
            while (drt.Read())
            {
                avalaleqty = Convert.ToInt32(drt["Avalableqty"].ToString());
            }
            if (avalaleqty > 0)
            {
                if (textBoxBookname.Text == "")
                {
                    MessageBox.Show("Plese select book", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MemberDB obj = new MemberDB();
                    obj.Issueid = textBoxIssueid.Text;
                    obj.Bookname1 = textBoxBookname.Text;
                    obj.MemberName1 = textBoxMemberName.Text;
                    obj.IssueDate1 = dateTimePickerIssudate.Value.ToString();
                    obj.ReturnDate1 = dateTimePickerReturndate.Value.ToString();
                    obj.MemberID1 = textBoxMemberid.Text;
                    obj.addisueinfo(obj);
                    obj.Upatebookavalableqty(obj);
                    // get book table details
                    try
                    {
                        MemberDB objt = new MemberDB();
                        SqlDataReader dr = objt.getbooklist();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("ISBNNumber");
                        dt.Columns.Add("BookName");
                        dt.Columns.Add("Quantity");
                        dt.Columns.Add("Avalableqty");

                        while (dr.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["ISBNNumber"] = dr["ISBNNumber"];
                            row["BookName"] = dr["BookName"];
                            row["Quantity"] = dr["Quantity"];
                            row["Avalableqty"] = dr["Avalableqty"];
                            dt.Rows.Add(row);

                        }
                        dataGridViewBookname.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Book not avalable inthis moment", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            textBoxIssueid.Text = "";
            textBoxBookname.Text = "";
            //get issue table details
            try
            {

                MemberDB obj = new MemberDB();
                SqlDataReader dr = obj.getissueBooktable();
                DataTable dt = new DataTable();
                dt.Columns.Add("IssueID");
                dt.Columns.Add("BookName");
                dt.Columns.Add("MemberName");
                dt.Columns.Add("IssueDate");
                dt.Columns.Add("ReturnDate");
                dt.Columns.Add("MemberID");
                while (dr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["IssueID"] = dr["IssueID"];
                    row["BookName"] = dr["BookName"];
                    row["MemberName"] = dr["MemberName"];
                    row["IssueDate"] = dr["IssueDate"];
                    row["ReturnDate"] = dr["ReturnDate"];
                    row["MemberID"] = dr["MemberID"];
                    dt.Rows.Add(row);

                }
                dataGridViewReturnbook.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //get auto genarated id again
            try
            {
                MemberDB objt = new MemberDB();

                SqlDataReader DR = objt.getAutogenaratedid();
                SqlCommand cmd = new SqlCommand();
                //DataTable dt = new DataTable();
                //dt.Columns.Add("IssueID");
                while (DR.Read())
                {
                    textBoxIssueid.Text = DR["IssueID"].ToString();

                }
                int i = int.Parse(textBoxIssueid.Text);
                i = i + 1;
                textBoxIssueid.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewReturnbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // seting return ook table value to lables
          try
            {
            String issueid;
            issueid=dataGridViewReturnbook.SelectedCells[0].Value.ToString();
           // issueid = labelissueid1.Text;
            MemberDB obj = new MemberDB();
            SqlDataReader dr = obj.getissuebookdetil(issueid);
            DataTable dt = new DataTable();
            dt.Columns.Add("IssueID");
            dt.Columns.Add("BookName");
            dt.Columns.Add("IssueDate");
            dt.Columns.Add("ReturnDate");
            while (dr.Read())
            {
                DataRow row = dt.NewRow();

                labelissueid1.Text = dr["IssueID"].ToString();
                labelbookname.Text= dr["BookName"].ToString();
                labelissuedate.Text = dr["IssueDate"].ToString();
                labelReturndate.Text = dr["ReturnDate"].ToString();
                dt.Rows.Add(row);
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewBookname_CellClick(object sender, DataGridViewCellEventArgs e)
        { //set tble value book nametable
            try
            {
                String Bookid;
                Bookid = dataGridViewBookname.SelectedCells[0].Value.ToString();
                MemberDB obj = new MemberDB();
                SqlDataReader dr = obj.getBookname(Bookid);
                DataTable dt = new DataTable();
                dt.Columns.Add("BookName");
                while (dr.Read())
                {
                    DataRow row = dt.NewRow();

                    textBoxBookname.Text = dr["BookName"].ToString();
                    dt.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            MemberDB obj = new MemberDB();
            obj.Returnbooknme = labelbookname.Text;
            obj.Upatebookavalableqty1(obj);
            obj.Retunissueid1 = labelissueid1.Text;
            obj.DeleteIssue(obj);
            // bookable
            try
            {
                MemberDB objt = new MemberDB();
                SqlDataReader dr = objt.getbooklist();
                DataTable dt = new DataTable();
                dt.Columns.Add("ISBNNumber");
                dt.Columns.Add("BookName");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Avalableqty");

                while (dr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["ISBNNumber"] = dr["ISBNNumber"];
                    row["BookName"] = dr["BookName"];
                    row["Quantity"] = dr["Quantity"];
                    row["Avalableqty"] = dr["Avalableqty"];
                    dt.Rows.Add(row);

                }
                dataGridViewBookname.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // return book table
            try
            {

                MemberDB objt = new MemberDB();
                SqlDataReader dr = objt.getissueBooktable();
                DataTable dt = new DataTable();
                dt.Columns.Add("IssueID");
                dt.Columns.Add("BookName");
                dt.Columns.Add("MemberName");
                dt.Columns.Add("IssueDate");
                dt.Columns.Add("ReturnDate");
                dt.Columns.Add("MemberID");
                while (dr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["IssueID"] = dr["IssueID"];
                    row["BookName"] = dr["BookName"];
                    row["MemberName"] = dr["MemberName"];
                    row["IssueDate"] = dr["IssueDate"];
                    row["ReturnDate"] = dr["ReturnDate"];
                    row["MemberID"] = dr["MemberID"];
                    dt.Rows.Add(row);

                }
                dataGridViewReturnbook.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // clearlables
            labelissueid1.Text = "";
            labelbookname.Text = "";
            labelissuedate.Text = "";
            labelReturndate.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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
    }
}
