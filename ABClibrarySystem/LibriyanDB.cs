using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABClibrarySystem
{
  public  class LibriyanDB
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
        //Stop entarig duplicate values
        public SqlDataReader SearchDuplicatevalues(String NicNumber)
        {

            DBConnection mycon = new DBConnection();
            String SQL = "select  * from  Librarian where LibrarianID='" + NicNumber + "'";
            return mycon.getdata(SQL);

        }
        //Adding Libariyan details Libariyan table
        public void addNewLibariyan(LibriyanDB obj)
        {
            String SQL = "insert into Librarian  values('" + obj.NICNumber + "','" + obj.FristName + "','" + obj.LastName + "','" + obj.Email + "','" + obj.password + "','" + obj.Gender + "','" + obj.Address + "','" + obj.Phonenumber + "','" + obj.regdate.ToString("yyyy-MM-dd") + "')";
            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }

        // geting data update admin table
        public SqlDataReader getLibariyanInfo()
        {
            DBConnection mycon = new DBConnection();
            String SQL = "select * from Librarian";
            return mycon.getdata(SQL);
        }

        //get selcted Libariyan details
        public SqlDataReader getupdateLibariyan(String nicno)
        {
            DBConnection mycon = new DBConnection();
            String SQL = "select * from Librarian where  LibrarianID='" + nicno + "'";
            return mycon.getdata(SQL);
        }

        //update Librarian details
        public void enterupdaeLibrarian(LibriyanDB obj)
        {
            String SQL = "update Librarian set  FristName='" + obj.FristName + "',LastName='" + obj.LastName + "',Email='" + obj.Email + "',LibrarianPassword='" + obj.password + "',gender='" + obj.Gender + "',Adress ='" + obj.Address + "',Phone_Number='" + obj.Phonenumber + "'where LibrarianID='" + obj.NICNumber + "'";
            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }
        //delete Librarian
        public void DeleteLibrarian(LibriyanDB objt)
        {
            DBConnection mycon = new DBConnection();
            String SQL = "delete from  Librarian where  LibrarianID='" + objt.NICNumber + "'";
            mycon.addvalues(SQL);
        }


        //search Librarian
        public SqlDataReader SearchLibrarian(String LibrarianName)
        {

            DBConnection mycon = new DBConnection();
            String SQL = "select * from Librarian where FristName like('%" + LibrarianName + "%')";
            return mycon.getdata(SQL);

        }

    }
}
