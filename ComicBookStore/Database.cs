using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicBookStore
{
    internal class Database
    {

        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet studentDataSet, courseDataSet;
        DataTable courseTable;
        BindingSource myBindingSource;
        string strSQL;

        OleDbCommand myCommand;
        OleDbDataReader myDataReader;



        string queryString;
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../ComicDatabase.accdb;";




        public   DataTable GetDatabaseInfo(string strSQL = "SELECT * FROM ComicDatabase")
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=ComicDatabase.accdb;");
            

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            courseDataSet = new DataSet("ComicTable");
            myDataAdapter.Fill(courseDataSet, "ComicTable");

            // Display the data from the query in the ComboBox control.

            courseTable = courseDataSet.Tables["ComicTable"];
            

           

            return courseTable;




        }


        public void DatabaseInsert(string queryString)
        {
            myConnection = new OleDbConnection(connectString);

            myCommand = new OleDbCommand(queryString,myConnection);
            myDataAdapter = new OleDbDataAdapter(myCommand);

            myConnection.Open();

            myCommand.ExecuteNonQuery();
        

            myConnection.Close();
        }


       



       

    }
}
