using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABClibrarySystem
{
public class LoginFormDB
    {
       /* String logid;

        public string Logid
        {
            get
            {
                return logid;
            }

            set
            {
                logid = value;
            }
        
        }
*/

        public SqlDataReader getlogindata(String AdminName, String Password)//get admin logidetails
        {
            DBConnection mycon = new DBConnection();
            String SQL = 
        "select * from  Administrator where AdminID='" + AdminName + "'and UserPassword='" + Password + "'";
            return mycon.getdata(SQL);
        }

        public SqlDataReader getLibariyanlogin(String LibariyanName, String laibariyanPassword)//get Laibariyan logidetails
        {

            DBConnection mycon = new DBConnection();
            String SQL = "select * from  Librarian where LibrarianID='" + LibariyanName + "'and LibrarianPassword='" + laibariyanPassword + "'";
            return mycon.getdata(SQL);

        }

        public SqlDataReader getMemberLogin(String MemberName, String MemberPassword)//get Member logidetails
        {

            DBConnection mycon = new DBConnection();
            String SQL = "select * from  Member where MemberID='" + MemberName + "'and MemberPassword='" + MemberPassword + "'";
            return mycon.getdata(SQL);

        }

    }


}

