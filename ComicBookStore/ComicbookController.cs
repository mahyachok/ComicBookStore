﻿using System;
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

        public DataTable DisplayComics()
        {
            strSQL = "SELECT * FROM ComicCollection";
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


        public void AddCustomerToDatabase(Customer newCustomer)
        {
            strSQL = $"INSERT INTO CustomersLogin (CustomerUsername, CustomerPassword) VALUES ('{newCustomer.Username}', {newCustomer.Password})";
            comicDatabase.DatabaseInsert(strSQL);
        }

        public void AddEmployeeToDatabase(Employee newEmployee)
        {
            strSQL = $"INSERT INTO EmployeeLogin (EmployeeUsername, EmployeePassword) VALUES ('{newEmployee.Username}', {newEmployee.Password})";
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
            string strSQL = $"UPDATE CustomerCollection SET " +
                            $"Password = '{customer.Password}', " +
                            $"Name = '{customer.Name}' " +
                            $"WHERE Username = '{customer.Username}'";

            comicDatabase.DatabaseInsert(strSQL);
        }

    }
}
