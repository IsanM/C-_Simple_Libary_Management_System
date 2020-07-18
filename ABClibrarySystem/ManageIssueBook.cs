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
using System.Net;
using System.Net.Mail;
namespace ABClibrarySystem
{
    public partial class ManageIssueBook : Form
    {
        public ManageIssueBook()
        {
            InitializeComponent();
        }

        private void ManageIssueBook_Load(object sender, EventArgs e)
        {
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

        private void dataGridViewReturnbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {// in this code use to selected book details(datagird view) set to text filed
                String issueid;
                issueid = dataGridViewReturnbook.SelectedCells[0].Value.ToString();
                MemberDB obj = new MemberDB();
                SqlDataReader dr = obj.getissuebookdetil(issueid);
                DataTable dt = new DataTable();
               // dt.Columns.Add("IssueID");
                dt.Columns.Add("BookName");
                dt.Columns.Add("MemberName");
                dt.Columns.Add("IssueDate");
                dt.Columns.Add("ReturnDate");
                dt.Columns.Add("MemberID");
                while (dr.Read())
                {
                    DataRow row = dt.NewRow();
                    textBoxBookNAME.Text = dr["BookName"].ToString();
                    textBoxMemberName.Text = dr["BookName"].ToString();
                    textBoxIssueDate.Text = dr["IssueDate"].ToString();
                    textBoxReturndate.Text = dr["ReturnDate"].ToString();
                    textBoxMembeerid.Text = dr["MemberID"].ToString();
                    dt.Rows.Add(row);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           try
            {
                String Memberid;
                Memberid = dataGridViewReturnbook.SelectedCells[5].Value.ToString();
                MemberDB obj = new MemberDB();
                SqlDataReader dr = obj.getMemberInfo(Memberid);
                // DataTable dt = new DataTable();
                while (dr.Read())
                {
                    textBoxEMAIL.Text = dr["Email"].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void richTextBoxContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonmail_Click(object sender, EventArgs e)
        {
            try
            {//send email coding
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("ishanmadhawa44@gmail.com", "ishpvi928280");
                MailMessage mail = new MailMessage
                    ("ishanmadhawa44@gmail.com", textBoxEMAIL.Text, "Return Notice ", richTextBoxContent.Text);
                mail.Priority = MailPriority.High;
                smtp.Send(mail);
                MessageBox.Show("Mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {//Back to main menu
            Libraryanform f = new Libraryanform();
            f.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMembeerid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxReturndate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIssueDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMemberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBookNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEMAIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewReturnbook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
