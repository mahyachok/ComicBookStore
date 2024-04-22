using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookStore
{
    internal class ComicbookController
    {

        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet myDataSet;
        string strSQL;


        public ComicbookController()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=ComicBookStore.accdb;");

            strSQL = "SELECT * FROM ComicCollection";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            myDataSet = new DataSet("ComicTable");
            myDataAdapter.Fill(myDataSet, "ComicCollection");
        }

        public Customer MakeCustomer(string username, string password, string name)
        {
            Customer newCustomer = new Customer(username, password, name);
            return newCustomer;
        }

        public Employee MakeEmployee(string username, string password, string name, double salary, string storeName, string address)
        {
            Employee newEmployee = new Employee(username, password, name, salary, storeName, address);
            return newEmployee;
        }



       public Comicbook MakeComicBook(string seriesTitle, string upc, int issueNumber, string coverImage, string author, string illustrator, double price, bool variantCover, bool reprint)
        {
            Comicbook newComicBook = new Comicbook(seriesTitle, upc, issueNumber, coverImage, author, illustrator, price, variantCover, reprint);
            return newComicBook;
        }


        //the sql string doesnt match the database need to add CoverImage cell to the database
        public void AddComicBook(Comicbook newComicBook)
        {
          string sql = "INSERT INTO ComicCollection (Title, UPC, IssueNo,CoverImage, Author, Illustrator, Price, VariantCover, Reprint) VALUES ('" + newComicBook.SeriesTitle + "', '" + newComicBook.UPC + "', " + newComicBook.IssueNumber + ", '" + newComicBook.CoverImage +", '" + newComicBook.Author + "', '" + newComicBook.Illustrator + "', " + newComicBook.Price + ", " + newComicBook.VariantCover + ", " + newComicBook.Reprint + ")";

            Database database = new Database();

            database.DatabaseInsert(sql);
        }



        //the sql string doesnt match the database
        
        public void AddCustomer(Customer newCustomer)
        {
            string sql = "INSERT INTO Customer (Username, Password, Name) VALUES ('" + newCustomer.Username + "', '" + newCustomer.Password + "', '" + newCustomer.Name + "')";

            Database database = new Database();

            database.DatabaseInsert(sql);
        }


        //might delete this also the sql string doesnt match the database
        public void AddEmployee(Employee newEmployee)
        {
            //string sql = "INSERT INTO Employee (Username, Password, Name, Salary, StoreName, Address) VALUES ('" + newEmployee.Username + "', '" + newEmployee.Password + "', '" + newEmployee.Name + "', " + newEmployee.Salary + ", '" + newEmployee.StoreName + "', '" + newEmployee.Address + "')";

            //Database database = new Database();

            //database.DatabaseInsert(sql);
        }

      




    }
}
