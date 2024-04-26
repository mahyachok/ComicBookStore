using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
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
        private Database comicDatabase;


        public ComicbookController()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=ComicBookStore.accdb;");
            comicDatabase = new Database();
        }

        public DataTable DisplayComics(string strSQL = "SELECT * FROM ComicCollection")
        {
            
            return comicDatabase.GetDatabaseInfo(strSQL);
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

        public Comicbook MakeComicbook(int UPC, string seriesTitle, int issueNumber, string coverImage, string author, string illustrator, double price, bool variantCover, bool reprint)
        {
            Comicbook newComicbook = new Comicbook(seriesTitle, UPC, issueNumber, coverImage, author, illustrator, price, variantCover, reprint);
            return newComicbook;
        }

        public void AddComicToDatabase(Comicbook newComicbook)
        {
            strSQL = $"INSERT INTO ComicCollection (UPC, Title, IssueNo, CoverImage, Author, Illustrator, Price, VariantCover, Reprint) VALUES ('{newComicbook.UPC}', '{newComicbook.SeriesTitle}', {newComicbook.IssueNumber}, '{newComicbook.CoverImage}', '{newComicbook.Author}', '{newComicbook.Illustrator}', {newComicbook.Price}, {newComicbook.VariantCover}, {newComicbook.Reprint})";
            comicDatabase.DatabaseInsert(strSQL);
        }




        public void AddCustomerToDatabase(Customer newCustomer)
        {
            strSQL = $"INSERT INTO CustomersLogin (CustomerUsername, CustomerPassword, CustomerName) VALUES ('{newCustomer.Username}', '{newCustomer.Password}', '{newCustomer.Name}')";
            comicDatabase.DatabaseInsert(strSQL);
        }

        public void AddEmployeeToDatabase(Employee newEmployee)
        {
            strSQL = $"INSERT INTO EmployeeLogin (EmployeeUsername, EmployeePassword, EmployeeName, Salary, StoreName, Address) " +
                     $"VALUES ('{newEmployee.Username}', '{newEmployee.Password}', '{newEmployee.Name}', {newEmployee.Salary}, '{newEmployee.StoreName}', '{newEmployee.Address}')";
            comicDatabase.DatabaseInsert(strSQL);
        }

        public void DeleteEmployeeFromDatabase(Employee employee)
        {
            strSQL = $"DELETE FROM CustomerCollection "+ $"WHERE Username = '{employee.Username}'";
            comicDatabase.DatabaseInsert(strSQL);
        }

        public void DeleteComicFromDatabase(Comicbook comicbook)
        {
            strSQL = $"DELETE FROM ComicCollection " + $"WHERE UPC = '{comicbook.UPC}'";
            comicDatabase.DatabaseInsert(strSQL);
        }

        public void DeleteCustomer(Customer customer)
        {
            strSQL = $"DELETE FROM CustomerCollection " + $"WHERE Username = '{customer.Username}'";
            comicDatabase.DatabaseInsert(strSQL);
        }

        public void DeleteEmployee(Employee employee)
        {
            strSQL = $"DELETE FROM EmployeeLogin " + $"WHERE Username = '{employee.Username}'";
            comicDatabase.DatabaseInsert(strSQL);
        }

        public void ModifyComicBook(Comicbook comicbook)
        {
            string strSQL = $"UPDATE ComicCollection SET " +
                    $"Title = '{comicbook.SeriesTitle}', " +
                    $"IssueNo = {comicbook.IssueNumber}, " +
                    $"CoverImage = '{comicbook.CoverImage}', " +
                    $"Author = '{comicbook.Author}', " +
                    $"Illustrator = '{comicbook.Illustrator}', " +
                    $"Price = {comicbook.Price}, " +
                    $"VariantCover = {comicbook.VariantCover}, " +
                    $"Reprint = {comicbook.Reprint} " +
                    $"WHERE UPC = '{comicbook.UPC}'";

            comicDatabase.DatabaseInsert(strSQL);
        }

        public void ModifyCustomer(Customer customer)
        {
            string strSQL = $"UPDATE CustomersLogin SET " +
                            $"Password = '{customer.Password}', " +
                            $"Name = '{customer.Name}' " +
                            $"WHERE Username = '{customer.Username}'";

            comicDatabase.DatabaseInsert(strSQL);
        }

        public void ModifyEmployee(Employee employee)
        {
            string strSQL = $"UPDATE EmployeeLogin SET " +
                            $"Password = '{employee.Password}', " +
                            $"Name = '{employee.Name}', " +
                            $"WHERE Username = '{employee.Username}'";

            comicDatabase.DatabaseInsert(strSQL);
        }

        public bool ValidateCustomerLogin(string username, string password)
        {
            string strSQL = $"SELECT COUNT(*) FROM CustomersLogin WHERE CustomerUsername = '{username}' AND CustomerPassword = '{password}'";

            int count = (int)comicDatabase.ExecuteScalar(strSQL);

            return count > 0;
        }

        public bool ValidateEmployeeLogin(string username, string password)
        {
            string strSQL = $"SELECT COUNT(*) FROM EmployeeLogin WHERE EmployeeUsername = '{username}' AND EmployeePassword = '{password}'";

            int count = (int)comicDatabase.ExecuteScalar(strSQL);

            return count > 0;
        }

        public List<Comicbook> GetPurchasedComicsByCustomer(string customerUsername)
        {
            List<Comicbook> purchasedComics = new List<Comicbook>();

            strSQL = $"SELECT * FROM CustomerCollection WHERE CustomerUsername = '{customerUsername}'";
            Console.WriteLine($"SQL Query: {strSQL}");

            DataTable dataTable = comicDatabase.GetDatabaseInfo(strSQL);
            Console.WriteLine($"Number of rows in dataTable: {dataTable.Rows.Count}");

            foreach (DataRow row in dataTable.Rows)
            {
                int comicUPC = Convert.ToInt32(row["ComicUPC"]);
                int quantity = Convert.ToInt32(row["Quantity"]);

                Comicbook comicbook = GetComicByUPC(comicUPC);

                if (comicbook != null)
                {
                    purchasedComics.Add(comicbook);
                }
            }

            return purchasedComics;
        }

        public Comicbook GetComicByUPC(int upc)
        {
            string strSQL = $"SELECT * FROM ComicCollection WHERE UPC = '{upc}'";

            DataTable dataTable = comicDatabase.GetDatabaseInfo(strSQL);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                string title = row["Title"].ToString();
                int issueNumber = Convert.ToInt32(row["IssueNo"]);
                string coverImage = row["CoverImage"].ToString();
                string author = row["Author"].ToString();
                string illustrator = row["Illustrator"].ToString();
                double price = Convert.ToDouble(row["Price"]);
                bool variant = Convert.ToBoolean(row["VariantCover"]);
                bool reprint = Convert.ToBoolean(row["Reprint"]);

                return new Comicbook(title, upc, issueNumber, coverImage, author, illustrator, price, variant, reprint);
            }
            else
            {
                return null;
            }
        }

        public Customer GetCustomerByUsername(string username)
        {
            strSQL = $"SELECT * FROM CustomersLogin WHERE CustomerUsername = '{username}'";

            DataTable dataTable = comicDatabase.GetDatabaseInfo(strSQL);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                string password = row["CustomerPassword"].ToString();
                string name = row["CustomerName"].ToString();

                return new Customer(username, password, name);
            }
            else
            {
                return null;
            }
        }

        public Employee GetEmployeeByUsername(string username)
        {
            strSQL = $"SELECT * FROM EmployeeLogin WHERE EmployeeUsername = '{username}'";

            DataTable dataTable = comicDatabase.GetDatabaseInfo(strSQL);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                string password = row["EmployeePassword"].ToString();
                string storeName = row["StoreName"].ToString();
                string name = row["EmployeeName"].ToString();
                string address = row["Address"].ToString();
                double salary = double.Parse(row["Salary"].ToString());

                return new Employee(username, password, name, salary, storeName, address);
            }
            else
            {
                return null;
            }
        }

        public bool ComicExists(int upc)
        {
            string strSQL = $"SELECT COUNT(*) FROM ComicCollection WHERE UPC = {upc}";

            int count = (int)comicDatabase.ExecuteScalar(strSQL);

            return count > 0;
        }

        public List<int> GetStoreComicUPCs(string storeName)
        {
            List<int> storeComicUPCs = new List<int>();

            strSQL = $"SELECT ComicUPC FROM StoreCollection WHERE StoreName = '{storeName}'";
            DataTable dataTable = comicDatabase.GetDatabaseInfo(strSQL);

            foreach (DataRow row in dataTable.Rows)
            {
                int comicUPC = Convert.ToInt32(row["ComicUPC"]);
                storeComicUPCs.Add(comicUPC);
            }

            return storeComicUPCs;
        }

        public void AddComicToStore(Comicbook comicbook, Employee employee)
        {
            strSQL = $"SELECT COUNT(*) FROM StoreCollection WHERE ComicUPC = {comicbook.UPC} AND StoreName = '{employee.StoreName}'";
            int count = (int)comicDatabase.ExecuteScalar(strSQL);

            if (count == 0)
            {
                strSQL = $"INSERT INTO StoreCollection (ComicUPC, StoreName) VALUES ({comicbook.UPC}, '{employee.StoreName}')";
                comicDatabase.DatabaseInsert(strSQL);
            }
        }

        public void AddComicToCustomer(Comicbook comicbook, Customer customer)
        {
            strSQL = $"SELECT COUNT(*) FROM CustomerCollection WHERE ComicUPC = {comicbook.UPC} AND CustomerUsername = '{customer.Username}'";
            int count = (int)comicDatabase.ExecuteScalar(strSQL);

            if (count == 0)
            {
                strSQL = $"INSERT INTO CustomerCollection (ComicUPC, CustomerUsername) VALUES ({comicbook.UPC}, '{customer.Username}')";
                comicDatabase.DatabaseInsert(strSQL);
            }
        }

        public void AddComicToCustomer(int upc, Customer customer)
        {
            strSQL = $"SELECT COUNT(*) FROM CustomerCollection WHERE ComicUPC = {upc} AND CustomerUsername = '{customer.Username}'";
            int count = (int)comicDatabase.ExecuteScalar(strSQL);

            if (count == 0)
            {
                strSQL = $"INSERT INTO CustomerCollection (ComicUPC, CustomerUsername) VALUES ({upc}, '{customer.Username}')";
                comicDatabase.DatabaseInsert(strSQL);
            }
        }

    }
}
