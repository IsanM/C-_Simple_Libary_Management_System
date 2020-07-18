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
    public partial class ViewMemberForm : Form
    {
        public ViewMemberForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {//back 
            Libraryanform f = new Libraryanform();
            f.Show();
            this.Hide();
        }

        private void ViewMemberForm_Load(object sender, EventArgs e)
        {// display all member details
            try
            {
                UpdateMemberDB obj = new UpdateMemberDB();
                SqlDataReader DR = obj.getMemberInfo();
                DataTable dt = new DataTable();
                dt.Columns.Add("MemberID");
                dt.Columns.Add("FristName");
                dt.Columns.Add("LastName");
                dt.Columns.Add("Email");
                dt.Columns.Add("MemberPassword");
                dt.Columns.Add("gender");
                dt.Columns.Add("Adress");
                dt.Columns.Add("Phone_Number");
                dt.Columns.Add("Registerdate");
                dt.Columns.Add("Registationfee");
                while (DR.Read())
                {
                    DataRow row = dt.NewRow();
                    row["MemberID"] = DR["MemberID"];
                    row["FristName"] = DR["FristName"];
                    row["LastName"] = DR["LastName"];
                    row["Email"] = DR["Email"];
                    row["MemberPassword"] = DR["MemberPassword"];
                    row["gender"] = DR["gender"];
                    row["Adress"] = DR["Adress"];
                    row["Phone_Number"] = DR["Phone_Number"];
                    row["Registerdate"] = DR["Registerdate"];
                    row["Registationfee"] = DR["Registationfee"];
                    dt.Rows.Add(row);
                }
                dataGridViewUpdateMember.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBoxSearchMember_KeyUp(object sender, KeyEventArgs e)
        { // serach Member details
            try
            {
                UpdateMemberDB objt = new UpdateMemberDB();
                SqlDataReader DR = objt.SearchMember(textBoxSearchMember.Text);
                DataTable dt = new DataTable();
                dt.Columns.Add("MemberID");
                dt.Columns.Add("FristName");
                dt.Columns.Add("LastName");
                dt.Columns.Add("Email");
                dt.Columns.Add("MemberPassword");
                dt.Columns.Add("gender");
                dt.Columns.Add("Adress");
                dt.Columns.Add("Phone_Number");
                dt.Columns.Add("Registerdate");
                dt.Columns.Add("Registationfee");
                while (DR.Read())
                {
                    DataRow row = dt.NewRow();
                    row["MemberID"] = DR["MemberID"];
                    row["FristName"] = DR["FristName"];
                    row["LastName"] = DR["LastName"];
                    row["Email"] = DR["Email"];
                    row["MemberPassword"] = DR["MemberPassword"];
                    row["gender"] = DR["gender"];
                    row["Adress"] = DR["Adress"];
                    row["Phone_Number"] = DR["Phone_Number"];
                    row["Registerdate"] = DR["Registerdate"];
                    row["Registationfee"] = DR["Registationfee"];
                    dt.Rows.Add(row);
                }
                dataGridViewUpdateMember.DataSource = dt;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
