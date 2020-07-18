using System;
using System.Collections.Generic;
using System.Data.SqlClient;// this line use for access some perdefine class or sql database
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABClibrarySystem
{
   public class DBConnection// class name
    {
        SqlConnection con;//Create SQL connection variable
        public SqlConnection createConnection()// using this method establish sql connection and retun establich connection
        {
            con = new SqlConnection("Data Source=ISH\\ISH;Initial Catalog=DOTNET8043;Persist Security Info=True;User ID=hnd;Password=hnd");
            try
            {
                con.Open();// open connection
                return con;// return connection
            }
            catch
            {
                con = null;//return null connection
                return con;
            }
        }
        public void addvalues(string Sql)//insert value into database
        {
            con = createConnection();// get the open connection
            SqlCommand cmd = new SqlCommand(Sql, con);//create sql command with given connection for given sql statement
            int i = cmd.ExecuteNonQuery();//execute the command
            if (i > 0)
            {

                MessageBox.Show("Command Sucessfull!");// show value add sucessfull message

            }
            else
            {
                MessageBox.Show("Command UnSucessfull!");
            }
        }
        public SqlDataReader getdata(String SQL)// get the data from sql databse
        {
            con = createConnection();
            SqlCommand comm = new SqlCommand();// create new sql command

            comm.CommandText = SQL;// create sql command and command text with sql
            comm.Connection = con;

            SqlDataReader sqlDReader;
            sqlDReader = comm.ExecuteReader();// exexute sql command

            return sqlDReader;// return data readar
        }



    }
}
