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
using System.Data;

namespace ABClibrarySystem
{
   
    public partial class LoginForm : Form
    {
        public static string passingtext;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                MessageBox.Show("Loging ID cant'be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
            else if (textBoxUserPassword.Text == "")
            {
                MessageBox.Show("Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String combo = comboBoxUserType.Text;// select user type
                if (combo == "Admin")
                {
                    //Admin Login Coding
                    LoginFormDB obj = new LoginFormDB();
                    SqlDataReader DR = obj.getlogindata(textBoxUserName.Text, textBoxUserPassword.Text);
                    SqlCommand cmd = new SqlCommand();
                    int count = 0;
                    while (DR.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
                    {
                        AdminForm f = new AdminForm();
                        f.Show();
                        this.Hide();
                        MessageBox.Show("Login Sucessfull!");
                       MemberForm objt = new MemberForm();
                    }
                    else
                    {
                        MessageBox.Show("Invalid USER!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Libariyan Login
                else if (combo == "Librarian")
                {
                    LoginFormDB obj = new LoginFormDB();
                    SqlDataReader DR = obj.getLibariyanlogin(textBoxUserName.Text, textBoxUserPassword.Text);
                    SqlCommand cmd = new SqlCommand();
                    int count = 0;
                    while (DR.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
                    {
                        Libraryanform f = new Libraryanform();
                        f.Show();
                        this.Hide();
                        MessageBox.Show("Login Sucessfull!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid USER!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Member Login
                else if (combo == "Member")
                {
                    LoginFormDB obj = new LoginFormDB();
                    //obj.Logid = textBoxUserName.Text;
                    SqlDataReader DR = obj.getMemberLogin(textBoxUserName.Text, textBoxUserPassword.Text);
                    SqlCommand cmd = new SqlCommand();
                    int count = 0;
                    while (DR.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
                    {
                        LoginFormDB obct = new LoginFormDB();
                            MemberForm f = new MemberForm();
                       // String loginid;
                        passingtext= textBoxUserName.Text;
                        f.Show();
                        this.Hide();
                        MessageBox.Show("Login Sucessfull!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid USER!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
                else if (combo == "")
                {
                    MessageBox.Show("Please Select User Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void gardientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
