using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookStore
{
    internal class Employee
    {
        private string username;
        private string password;
        private string storeName;
        private string address;
        private string name;
        private double salary;

        public Employee(string username, string password, string name, double salary, string storeName, string address)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.salary = salary;
            this.storeName = storeName;
            this.address = address;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        { get { return password; } set { password = value; } }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}

