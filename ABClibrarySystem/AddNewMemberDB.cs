using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABClibrarySystem
{
   public class AddNewMemberDB
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
      double Registarationfee;

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

        public double Registarationfee1
        {
            get
            {
                return Registarationfee;
            }

            set
            {
                Registarationfee = value;
            }
        }
        // inserting data into sql table
        public void addMemeber(AddNewMemberDB obj)
        {
           String SQL = "insert into Member  values('" + obj.NICNumber+ "','" + obj.FristName + "','" + obj.LastName + "','" + obj.Email + "','" + obj.password + "','" + obj.Gender+ "','" + obj.Address + "','" + obj.Phonenumber + "','"+obj.regdate.ToString("yyyy-MM-dd") + "','" + obj.Registarationfee+ "')";

           DBConnection mycon = new DBConnection();
           mycon.addvalues(SQL);


        }
        // 
        public SqlDataReader SearchDuplicatevalues(String NicNumber)
        {

            DBConnection mycon = new DBConnection();
            String SQL = "select  * from Member where  MemberID='" +NicNumber+ "'";
            return mycon.getdata(SQL);

        }




    }
}
