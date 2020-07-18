using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABClibrarySystem
{
   public  class UpdateMemberDB
    {
        String NICNumber;
        String FristName;
        String LastName;
        String Email;
        String password;
        String Gender;
        String Address;
        int Phonenumber;
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
        // delte meber
        public void DeleteMemeber(UpdateMemberDB objt)
        {

            DBConnection mycon = new DBConnection();
            String SQL = "delete from  Member where  MemberID='" + objt.NICNumber + "'";
            mycon.addvalues(SQL);

        }
        // Serch Member
        public SqlDataReader SearchMember(String MemberName)
        {

            DBConnection mycon = new DBConnection();
            String SQL = "select * from Member where FristName like('%" + MemberName + "%')";
            return mycon.getdata(SQL);

        }

        public void enterupdateMemeber(UpdateMemberDB obj)
        {
            // Update Members details
            String SQL = "update Member set  FristName='" + obj.FristName + "',LastName='" + obj.LastName+ "',Email='" + obj.Email + "',MemberPassword='" + obj.password + "',gender='" + obj.Gender + "',Adress ='" + obj.Address + "',Phone_Number='" + obj.Phonenumber + "',Registationfee='" + obj.Registarationfee + "'where  MemberID='" + obj.NICNumber + "'";
            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }

        public SqlDataReader getMemberInfo()
        {
            //geting data to table
            DBConnection mycon = new DBConnection();
            String SQL = "select * from Member";
            return mycon.getdata(SQL);

        }
        // getting data to update text fileds
        public SqlDataReader getupdateMemberInfo(String nicno)
        {

            DBConnection mycon = new DBConnection();
            String SQL = "select * from Member where MemberID='" + nicno + "'";
            return mycon.getdata(SQL);

        }


    }
}
