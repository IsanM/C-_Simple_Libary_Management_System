using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABClibrarySystem
{
    public partial class UpdateMember : Form
    {
        public UpdateMember()
        {
            InitializeComponent();
        }
        
        private void UpdateMember_Load(object sender, EventArgs e)
        {
            // geeting memeber details and display datagird view
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

        private void dataGridViewUpdateMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonFeMale_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPhonenumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxPhonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void textBoxRegistraionFee_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxRegistraionFee_KeyPress(object sender, KeyPressEventArgs e)
        {// stop entering string values
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {// update button// Empty filed val;idation
            if (textBoxFristName.Text == "")
            {
                MessageBox.Show("Insert Frist Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxLastName.Text == "")
            {
                MessageBox.Show("Insert Last Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Insert Email", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Insert password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxConfirmpassword.Text == "")
            {
                MessageBox.Show("Insert Confirm Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (richTextBoxAdress.Text == "")
            {
                MessageBox.Show("Insert Adress", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPhonenumber.Text == "")
            {
                MessageBox.Show("Insert PhoneNumber", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxRegistraionFee.Text == "")
            {
                MessageBox.Show("Insert RegistrationFee", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdateMemberDB obj = new UpdateMemberDB();
                String NICNO;
                NICNO = dataGridViewUpdateMember.SelectedCells[0].Value.ToString();
                obj.NICNumber1 = NICNO;

                obj.FristName1 = textBoxFristName.Text;
                obj.LastName1 = textBoxLastName.Text;
                obj.Email1 = textBoxEmail.Text;
                obj.Password = textBoxPassword.Text;
                obj.Gender1 = comboBoxGender.Text;
                obj.Address1 = richTextBoxAdress.Text;
                obj.Phonenumber1 = Convert.ToInt32(textBoxPhonenumber.Text);
                obj.Registarationfee1 = Convert.ToDouble(textBoxRegistraionFee.Text);
                obj.enterupdateMemeber(obj);
            }
            // refresh table
            try
            {

                UpdateMemberDB objt = new UpdateMemberDB();
                SqlDataReader DR = objt.getMemberInfo();
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
            //send email
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("ishanmadhawa44@gmail.com", "ishpvi928280");
                MailMessage mail = new MailMessage("ishanmadhawa44@gmail.com", textBoxEmail.Text, "Your detalis has been updated get mor info please contact administor!!Your loinid is  Your NIC Number and password given bellow ", textBoxConfirmpassword.Text);
                mail.Priority = MailPriority.High;
                smtp.Send(mail);
                MessageBox.Show("Mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Clear textfileds

            // textBoxNICNumber.Text = "";
            textBoxFristName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmpassword.Text = "";
            richTextBoxAdress.Text = "";
            textBoxPhonenumber.Text = "";
            textBoxRegistraionFee.Text = "";






        }

        private void dataGridViewUpdateMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // getting selected member details
            try
            {
                String NICNO;
                NICNO = dataGridViewUpdateMember.SelectedCells[0].Value.ToString();
                UpdateMemberDB obj = new UpdateMemberDB();
                SqlDataReader DR = obj.getupdateMemberInfo(NICNO);
                DataTable dt = new DataTable();
                dt.Columns.Add("MemberID");
                dt.Columns.Add("FristName");
                dt.Columns.Add("LastName");
                dt.Columns.Add("Email");
                dt.Columns.Add("MemberPassword");
                dt.Columns.Add("gender");
                dt.Columns.Add("Adress");
                dt.Columns.Add("Phone_Number");
              //  dt.Columns.Add("Registerdate");
                dt.Columns.Add("Registationfee");
                while (DR.Read())
                {
                    DataRow row = dt.NewRow();
                   // row["MemberID"] = DR["MemberID"];
                   textBoxFristName.Text = DR["FristName"].ToString();
                    textBoxLastName.Text = DR["LastName"].ToString();
                    textBoxEmail.Text = DR["Email"].ToString();              
                    textBoxPassword.Text = DR["MemberPassword"].ToString();
                    textBoxConfirmpassword.Text = DR["MemberPassword"].ToString();
                    comboBoxGender.Text= DR["gender"].ToString();
                    richTextBoxAdress.Text = DR["Adress"].ToString();
                     textBoxPhonenumber.Text = DR["Phone_Number"].ToString();
                  
                      textBoxRegistraionFee.Text = DR["Registationfee"].ToString();
                    dt.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {// delete button coding
            try
            {
                UpdateMemberDB objt = new UpdateMemberDB();
                String NicNumber;
                NicNumber = dataGridViewUpdateMember.SelectedCells[0].Value.ToString();
                objt.NICNumber1 = NicNumber;
                objt.DeleteMemeber(objt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // refersh table
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
            textBoxFristName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmpassword.Text = "";
            richTextBoxAdress.Text = "";
            textBoxPhonenumber.Text = "";
            textBoxRegistraionFee.Text = "";


        }

        private void Back_Click(object sender, EventArgs e)
        {
            Libraryanform f = new Libraryanform();
            f.Show();
            this.Hide();
        }

        private void textBoxSearchMember_KeyUp(object sender, KeyEventArgs e)
        {// serach member name
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

        private void textBoxSearchMember_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
