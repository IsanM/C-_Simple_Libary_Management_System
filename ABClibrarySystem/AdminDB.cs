using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABClibrarySystem
{
 public   class AdminDB
    {

        String NICNumber;
        String FristName;
        String LastName;
        String Email;
        String password;
        String Gender;
        String Address;
        int Phonenumber;
        DateTime regdate;

        public string NICNumber1
        {
            get
            {
                return NICNumber;
            }

            set
            {
                NICNumber = value;
            }
        }

        public string FristName1
        {
            get
            {
                return FristName;
            }

            set
            {
                FristName = value;
            }
        }

        public string LastName1
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public string Email1
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Gender1
        {
            get
            {
                return Gender;
            }

            set
            {
                Gender = value;
            }
        }

        public string Address1
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }

        public int Phonenumber1
        {
            get
            {
                return Phonenumber;
            }

            set
            {
                Phonenumber = value;
            }
        }

        public DateTime Regdate
        {
            get
            {
                return regdate;
            }

            set
            {
                regdate = value;
            }
        }


        //Adding admin details admin table
        public void addNewAdmin(AdminDB obj)
        {
            String SQL = "insert into Administrator  values('" + obj.NICNumber + "','" + obj.FristName + "','" + obj.LastName + "','" + obj.Email + "','" + obj.password + "','" + obj.Gender + "','" + obj.Address + "','" + obj.Phonenumber + "','" + obj.regdate.ToString("yyyy-MM-dd") + "')";

            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);


        }

        //Stop entarig duplicate values
        public SqlDataReader SearchDuplicatevalues(String NicNumber)
        {

            DBConnection mycon = new DBConnection();
            String SQL = "select  * from Administrator where AdminID='" + NicNumber + "'";
            return mycon.getdata(SQL);

        }


        // geting data update admin table
        public SqlDataReader getAdminInfo()
        {
            DBConnection mycon = new DBConnection();
            String SQL = "select * from  Administrator";
            return mycon.getdata(SQL);
        }

        //get selcted admin details
        public SqlDataReader getupdateAdminInfo(String nicno)
        {
            DBConnection mycon = new DBConnection();
            String SQL = "select * from Administrator where   AdminID='" + nicno + "'";
            return mycon.getdata(SQL);
        }

        //update Admin details
        public void enterupdaeAdmin(AdminDB obj)
        {  
            String SQL = "update Administrator set  FristName='" + obj.FristName + "',LastName='" + obj.LastName + "',Email='" + obj.Email + "',UserPassword='" + obj.password + "',gender='" + obj.Gender + "',Adress ='" + obj.Address + "',Phone_Number='" + obj.Phonenumber + "'where AdminID='" + obj.NICNumber + "'";
            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }

        //delete admin
        public void DeleteAdmin(AdminDB objt)
        {
            DBConnection mycon = new DBConnection();
            String SQL = "delete from  Administrator where  AdminID='" + objt.NICNumber + "'";
            mycon.addvalues(SQL);
        }

        //search Admin
        public SqlDataReader SearchAdmin(String AdminName)
        {

            DBConnection mycon = new DBConnection();
            String SQL = "select * from Administrator where FristName like('%" + AdminName + "%')";
            return mycon.getdata(SQL);

        }

    }
}
