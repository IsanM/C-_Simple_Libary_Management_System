using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABClibrarySystem
{
   public class AddNewBookDB
    {
        String ISBNNO;
        String bookname;
        String AuthorName;
        int publishedyr;
        double bookprice;
        String bookcategory;
        int numofcopy;
        String pulishname;

        public string ISBNNO1
        {
            get
            {
                return ISBNNO;
            }

            set
            {
                ISBNNO = value;
            }
        }

        public string Bookname
        {
            get
            {
                return bookname;
            }

            set
            {
                bookname = value;
            }
        }

        public string AuthorName1
        {
            get
            {
                return AuthorName;
            }

            set
            {
                AuthorName = value;
            }
        }

        public int Publishedyr
        {
            get
            {
                return publishedyr;
            }

            set
            {
                publishedyr = value;
            }
        }

        public double Bookprice
        {
            get
            {
                return bookprice;
            }

            set
            {
                bookprice = value;
            }
        }

        public string Bookcategory
        {
            get
            {
                return bookcategory;
            }

            set
            {
                bookcategory = value;
            }
        }

        public int Numofcopy
        {
            get
            {
                return numofcopy;
            }

            set
            {
                numofcopy = value;
            }
        }

        public string Pulishname
        {
            get
            {
                return pulishname;
            }

            set
            {
                pulishname = value;
            }
        }
        public void addbookdetails(AddNewBookDB obj)
        {//inserting data in sql database
            String SQL = "insert into Book values('" + obj.ISBNNO + "','" + obj.bookname + "','" + obj.AuthorName + "','" + obj.publishedyr + "','" + obj.bookprice + "','" + obj.bookcategory + "','" + obj.numofcopy + "','" + obj.numofcopy + "','" + obj.pulishname + "')";

            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);


        }

        //Stop entarig duplicate values
        public SqlDataReader SearchDuplicatevalues(String ISBNNumber)
        {

            DBConnection mycon = new DBConnection();
            String SQL = "select  * from Book where ISBNNumber='" + ISBNNumber + "'";
            return mycon.getdata(SQL);

        }

    }
}
