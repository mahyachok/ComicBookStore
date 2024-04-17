using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
 Databasse contant 

database name : ComicBookDatabase


first
table name : ComicBook
fields : SeriesTitle, IssueNumber, CoverImage, Author, Illustrator, Price, VarientCover, Reprint, 



//maybe ill add these one later Publisher, Genre, ReleaseDate, Stock


second table

table: Store

fields: StoreName, StoreLocation, StoreInventory

 
 
 */
















namespace ComicBookStore
{

    internal class Database
    {

        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet courseDataSet;
        DataTable comicTable;
        BindingSource myBindingSource;
        string strSQL;

        OleDbCommand myCommand;
        OleDbDataReader myDataReader;



        string queryString;
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../ComicbookDatabase.accdb;";




        public   DataTable GetDatabaseInfo(string strSQL = "SELECT * FROM ComicBook")
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=ComicbookDatabase.accdb;");
            

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            courseDataSet = new DataSet("Comic");
            myDataAdapter.Fill(courseDataSet, "Comic");

            // Display the data from the query in the ComboBox control.

            comicTable = courseDataSet.Tables["Comic"];
            

           

            return comicTable;




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
