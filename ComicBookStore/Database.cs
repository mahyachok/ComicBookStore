using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
 Database contant 

database name : ComicBookStore.accdb


first
table name : ComicCollection

fields : UPC, Title, IssueNo, Author, Illustrator, Price, VariantCover, Reprint



//maybe ill add these one later Publisher, Genre, ReleaseDate, Stock


second table


CustomerCollection

fields: CustomerID, ComicUPC,Quantity


Third table 

CustomerLogin

fields: CustomerUsername, CustomerPassword


fourth table

EmployeeLogin

fields: EmployeeUsername, EmployeePassword








Fifth Table
StorCollection

StoreCollection

fields: StoreID, ComicUPC, Quantity

 
 
 */
















namespace ComicBookStore
{

    internal class Database
    {

        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet comicDataSet;
        DataTable comicTable;
        BindingSource myBindingSource;
        string strSQL;

        OleDbCommand myCommand;
        OleDbDataReader myDataReader;



        string queryString;
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../ComicBookStore.accdb;";




        public   DataTable GetDatabaseInfo(string strSQL = "SELECT * FROM ComicCollection")
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=ComicBookStore.accdb;");
            

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            comicDataSet = new DataSet("Comic");
            myDataAdapter.Fill(comicDataSet, "Comic");

            comicTable = comicDataSet.Tables["Comic"];
            

           

            return comicTable;




        }


        public void DatabaseInsert(string queryString)
        {
            myConnection = new OleDbConnection(connectString);

            myCommand = new OleDbCommand(queryString,myConnection);
            myDataAdapter = new OleDbDataAdapter(myCommand);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Comic added to collection!");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("An error occurred while purchasing the comic: " + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
        }


        public object ExecuteScalar(string queryString)
        {
            using (OleDbConnection connection = new OleDbConnection(connectString))
            {
                using (OleDbCommand command = new OleDbCommand(queryString, connection))
                {
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }





    }
}
