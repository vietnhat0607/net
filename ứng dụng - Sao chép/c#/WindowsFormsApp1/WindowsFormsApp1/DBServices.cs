using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    internal class DBServices
    {

        private string conStr = @"Data Source=LAPTOP-21HGRUOS\HP001;Initial Catalog=manager;Integrated Security=True";
        private SqlConnection myConn;

        public DBServices()
        {
            myConn = new SqlConnection(conStr);
        }

        public DataTable getData(string sql)
        {
            try
            {
                SqlDataAdapter myDA = new SqlDataAdapter(sql, myConn);
                DataTable myDT = new DataTable();
                myDA.Fill(myDT);
                return myDT;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public void runQuery(string sql)
        {
            try
            {
                myConn.Open();
                SqlCommand myCommand = new SqlCommand(sql, myConn);
                myCommand.ExecuteNonQuery();
                myConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

        }

    }
}

