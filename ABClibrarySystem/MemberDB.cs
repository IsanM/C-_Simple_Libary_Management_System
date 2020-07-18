using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABClibrarySystem
{
  public  class MemberDB
    {
        String issueid;
        String Bookname;
        String MemberName;
        String IssueDate;
        String ReturnDate;
        String MemberID;
        String Retunissueid;
        String returnbooknme;
        public string Issueid
        {
            get
            {
                return issueid;
            }

            set
            {
                issueid = value;
            }
        }

        public string Bookname1
        {
            get
            {
                return Bookname;
            }

            set
            {
                Bookname = value;
            }
        }

        public string MemberName1
        {
            get
            {
                return MemberName;
            }

            set
            {
                MemberName = value;
            }
        }

        public string IssueDate1
        {
            get
            {
                return IssueDate;
            }

            set
            {
                IssueDate = value;
            }
        }

        public string ReturnDate1
        {
            get
            {
                return ReturnDate;
            }

            set
            {
                ReturnDate = value;
            }
        }

        public string MemberID1
        {
            get
            {
                return MemberID;
            }

            set
            {
                MemberID = value;
            }
        }

        public string Retunissueid1
        {
            get
            {
                return Retunissueid;
            }

            set
            {
                Retunissueid = value;
            }
        }

        public string Returnbooknme
        {
            get
            {
                return returnbooknme;
            }

            set
            {
                returnbooknme = value;
            }
        }

        // add issue details
        public void addisueinfo(MemberDB obj)
        {
            String SQL = "insert into bookissue values('" + obj.issueid+ "','" + obj.Bookname + "','" + obj.MemberName + "','" + obj.IssueDate+ "','" + obj.ReturnDate + "','" + obj.MemberID+ "')";
            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }
        // update avalable quantity
        public void Upatebookavalableqty(MemberDB obj)
        {
            String SQL = "update Book set Avalableqty=Avalableqty-1  where BookName='" + obj.Bookname + "'";
            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }
        //get selected issue book details
        public SqlDataReader getissuebookdetil(String isueid)
        {
            DBConnection mycon = new DBConnection();
            String SQL = "select * from bookissue where  IssueID='" + isueid + "'";
            return mycon.getdata(SQL);
        }

        //get issuee id 
        public SqlDataReader getAutogenaratedid()
        {
            DBConnection mycon = new DBConnection();
            String SQL = "select IssueID from bookissue order by IssueID";
            return mycon.getdata(SQL);
        }
        // get bookdetails
        public SqlDataReader getbooklist()
        {
            DBConnection mycon = new DBConnection();
            String SQL= "select ISBNNumber,BookName,Quantity,Avalableqty from Book";
              return mycon.getdata(SQL);
        }

        // get member detils
        public SqlDataReader getMemberInfo(String id)
        {
            DBConnection mycon = new DBConnection();
            String SQL = "select * from Member where  MemberID='" + id+ "'";
            return mycon.getdata(SQL);
        }
        // get selected book details
        public SqlDataReader getBookname(String bookid)
        {
            DBConnection mycon = new DBConnection();
            String SQL = "select * from Book where ISBNNumber='" + bookid + "'";
            return mycon.getdata(SQL);
        }
        // get issue table data(Member form)
        public SqlDataReader getissueBooktable()
        {
            DBConnection mycon = new DBConnection();
            String SQL = "select * from bookissue";
            return mycon.getdata(SQL);
        }
        //Return  book(Member Form)
        public void DeleteIssue(MemberDB obj)
        {

            DBConnection mycon = new DBConnection();
            String SQL = "delete from bookissue where IssueID='" + obj.Retunissueid + "'";
            mycon.addvalues(SQL);

        }
        // update avalable quantity
        public void Upatebookavalableqty1(MemberDB obj)
        {
            String SQL = "update Book set Avalableqty=Avalableqty+1  where BookName='" + obj.Returnbooknme + "'";

            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);


        }
    }
}
