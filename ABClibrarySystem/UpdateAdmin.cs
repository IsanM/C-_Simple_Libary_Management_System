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
    public partial class UpdateAdmin : Form
    {
        public UpdateAdmin()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            //back button
            AdminForm f = new AdminForm();
            f.Show();
            this.Hide();
        }

        private void UpdateAdmin_Load(object sender, EventArgs e)
        {
            //geting all  admin details admin table
            try
            { 
            AdminDB obj = new AdminDB();
            SqlDataReader DR = obj.getAdminInfo();
            DataTable dt = new DataTable();
            dt.Columns.Add("AdminID");
            dt.Columns.Add("FristName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("Email");
            dt.Columns.Add("UserPassword");
            dt.Columns.Add("gender");
            dt.Columns.Add("Adress");
            dt.Columns.Add("Phone_Number");
            dt.Columns.Add("Registerdate");
            while (DR.Read())
            {
                DataRow row = dt.NewRow();
                row["AdminID"] = DR["AdminID"];
                row["FristName"] = DR["FristName"];
                row["LastName"] = DR["LastName"];
                row["Email"] = DR["Email"];
                row["UserPassword"] = DR["UserPassword"];
                row["gender"] = DR["gender"];
                row["Adress"] = DR["Adress"];
                row["Phone_Number"] = DR["Phone_Number"];
                row["Registerdate"] = DR["Registerdate"];
               
                dt.Rows.Add(row);

            }
            dataGridViewUpdateAdmin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewUpdateAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //setting table value textfileds

            try
            {
                String NICNO;
                NICNO = dataGridViewUpdateAdmin.SelectedCells[0].Value.ToString();
                AdminDB obj = new AdminDB();
                SqlDataReader DR = obj.getupdateAdminInfo(NICNO);
                DataTable dt = new DataTable();
                dt.Columns.Add("AdminID");
                dt.Columns.Add("FristName");
                dt.Columns.Add("LastName");
                dt.Columns.Add("Email");
                dt.Columns.Add("UserPassword");
                dt.Columns.Add("gender");
                dt.Columns.Add("Adress");
                dt.Columns.Add("Phone_Number");
                //  dt.Columns.Add("Registerdate");
                //dt.Columns.Add("Registationfee");
                while (DR.Read())
                {
                    DataRow row = dt.NewRow();
                    // row["MemberID"] = DR["MemberID"];
                    textBoxFristName.Text = DR["FristName"].ToString();
                    textBoxLastName.Text = DR["LastName"].ToString();
                    textBoxEmail.Text = DR["Email"].ToString();
                    textBoxPassword.Text = DR["UserPassword"].ToString();
                    textBoxConfirmpassword.Text = DR["UserPassword"].ToString();
                    comboBoxGender.Text = DR["gender"].ToString();
                    richTextBoxAdress.Text = DR["Adress"].ToString();
                    textBoxPhonenumber.Text = DR["Phone_Number"].ToString();

                  //  textBoxRegistraionFee.Text = DR["Registationfee"].ToString();
                    dt.Rows.Add(row);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }

        private void textBoxPhonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {//Update button coding
            if (textBoxFristName.Text == "")
            {
                MessageBox.Show("Frist Name cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (textBoxLastName.Text == "")
            {
                MessageBox.Show("Last Name cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Email year cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Password cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxConfirmpassword.Text == "")
            {
                MessageBox.Show("Confirm Password cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (richTextBoxAdress.Text == "")
            {
                MessageBox.Show("Adress cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPhonenumber.Text == "")
            {
                MessageBox.Show("Phone number cant be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //updatecoding
                AdminDB obj = new AdminDB();
                String NICNO;
                NICNO = dataGridViewUpdateAdmin.SelectedCells[0].Value.ToString();
                obj.NICNumber1 = NICNO;
                obj.FristName1 = textBoxFristName.Text;
                obj.LastName1 = textBoxLastName.Text;
                obj.Email1 = textBoxEmail.Text;
                obj.Password = textBoxPassword.Text;
                obj.Gender1 = comboBoxGender.Text;
                obj.Address1 = richTextBoxAdress.Text;
                obj.Phonenumber1 = Convert.ToInt32(textBoxPhonenumber.Text);
                obj.enterupdaeAdmin(obj);
                // refersh table
                try
                {
                    AdminDB obcj = new AdminDB();
                    SqlDataReader DR = obcj.getAdminInfo();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("AdminID");
                    dt.Columns.Add("FristName");
                    dt.Columns.Add("LastName");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("UserPassword");
                    dt.Columns.Add("gender");
                    dt.Columns.Add("Adress");
                    dt.Columns.Add("Phone_Number");
                    dt.Columns.Add("Registerdate");
                    while (DR.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["AdminID"] = DR["AdminID"];
                        row["FristName"] = DR["FristName"];
                        row["LastName"] = DR["LastName"];
                        row["Email"] = DR["Email"];
                        row["UserPassword"] = DR["UserPassword"];
                        row["gender"] = DR["gender"];
                        row["Adress"] = DR["Adress"];
                        row["Phone_Number"] = DR["Phone_Number"];
                        row["Registerdate"] = DR["Registerdate"];

                        dt.Rows.Add(row);

                    }
                    dataGridViewUpdateAdmin.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // send email
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
                // clear text filed
                textBoxFristName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
                textBoxConfirmpassword.Text = "";
                richTextBoxAdress.Text = "";
                textBoxPhonenumber.Text = "";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {// delete button
            try
            {
              AdminDB objt = new AdminDB();
                String NicNumber;
                NicNumber = dataGridViewUpdateAdmin.SelectedCells[0].Value.ToString();
                objt.NICNumber1 = NicNumber;
                objt.DeleteAdmin(objt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // refersh table
            try
            {
                AdminDB obcj = new AdminDB();
                SqlDataReader DR = obcj.getAdminInfo();
                DataTable dt = new DataTable();
                dt.Columns.Add("AdminID");
                dt.Columns.Add("FristName");
                dt.Columns.Add("LastName");
                dt.Columns.Add("Email");
                dt.Columns.Add("UserPassword");
                dt.Columns.Add("gender");
                dt.Columns.Add("Adress");
                dt.Columns.Add("Phone_Number");
                dt.Columns.Add("Registerdate");
                while (DR.Read())
                {
                    DataRow row = dt.NewRow();
                    row["AdminID"] = DR["AdminID"];
                    row["FristName"] = DR["FristName"];
                    row["LastName"] = DR["LastName"];
                    row["Email"] = DR["Email"];
                    row["UserPassword"] = DR["UserPassword"];
                    row["gender"] = DR["gender"];
                    row["Adress"] = DR["Adress"];
                    row["Phone_Number"] = DR["Phone_Number"];
                    row["Registerdate"] = DR["Registerdate"];

                    dt.Rows.Add(row);

                }
                dataGridViewUpdateAdmin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // clear text filed
            textBoxFristName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmpassword.Text = "";
            richTextBoxAdress.Text = "";
            textBoxPhonenumber.Text = "";

        }

        private void textBoxSearchMember_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
               
                AdminDB obj = new AdminDB();
                SqlDataReader DR = obj.SearchAdmin(textBoxSearchMember.Text);
                DataTable dt = new DataTable();
                dt.Columns.Add("AdminID");
                dt.Columns.Add("FristName");
                dt.Columns.Add("LastName");
                dt.Columns.Add("Email");
                dt.Columns.Add("UserPassword");
                dt.Columns.Add("gender");
                dt.Columns.Add("Adress");
                dt.Columns.Add("Phone_Number");
                dt.Columns.Add("Registerdate");
                while (DR.Read())
                {
                    DataRow row = dt.NewRow();
                    row["AdminID"] = DR["AdminID"];
                    row["FristName"] = DR["FristName"];
                    row["LastName"] = DR["LastName"];
                    row["Email"] = DR["Email"];
                    row["UserPassword"] = DR["UserPassword"];
                    row["gender"] = DR["gender"];
                    row["Adress"] = DR["Adress"];
                    row["Phone_Number"] = DR["Phone_Number"];
                    row["Registerdate"] = DR["Registerdate"];

                    dt.Rows.Add(row);

                }
                dataGridViewUpdateAdmin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxConfirmpassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirmpassword.Text)
            {
                labelpasswordmaching.ForeColor = Color.Green;
                labelpasswordmaching.Text = "Matched";

            }
            else
            {
                labelpasswordmaching.ForeColor = Color.Red;
                labelpasswordmaching.Text = "Not matching";
            }
        }
    }
}
