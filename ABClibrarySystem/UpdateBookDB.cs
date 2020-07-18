using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABClibrarySystem
{
   public class UpdateBookDB
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
// update book details
        public void Updatebookdetails(UpdateBookDB obj)
        {
            String SQL = "update Book set   BookName='" + obj.bookname + "',AuthorName='" + obj.AuthorName + "',publishedyear='" + obj.publishedyr + "',bookprice='" + obj.bookprice + "',Bookcategoery='" + obj.bookcategory + "',Quantity='" + obj.numofcopy + "',Avalableqty='" + obj.numofcopy + "',publisherName='" + obj.pulishname + "'where ISBNNumber='" + obj.ISBNNO+ "'";
            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }
        //delete book details
        public void DeleteBook(UpdateBookDB obj)
        {
            DBConnection mycon = new DBConnection();
            String SQL = "delete from Book where ISBNNumber='" +obj.ISBNNO+ "'";
            mycon.addvalues(SQL);
        }

        //search book
        public SqlDataReader SearchBook(String BookName)
        {
            DBConnection mycon = new DBConnection();
            String SQL = "select * from Book where BookName like('%" + BookName + "%')";
            return mycon.getdata(SQL);
        }

        //geting data from table
        public SqlDataReader getbookdata()
        {
            DBConnection mycon = new DBConnection();
            String SQL = "select * from Book";
            return mycon.getdata(SQL);
        }
        //geting selected book coding
        public SqlDataReader getgridviewbookdata(String isbn)
        {

            DBConnection mycon = new DBConnection();
            String SQL = "select * from Book where ISBNNumber='" + isbn + "'";
            return mycon.getdata(SQL);

        }


    }
}
