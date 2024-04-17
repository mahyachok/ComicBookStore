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
        private string name;
        private double salary;

        public Employee(string username, string password, string name, double salary)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.salary = salary;
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
    }
}

