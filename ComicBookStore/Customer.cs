using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookStore
{
    internal class Customer
    {
        private string username;
        private string password;
        private string name;
        private List<Comicbook> comicBookCollection;


        public Customer(string username, string password, string name)
        {
            this.username = username;
            this.password = password;
            this.name = name;
        }

        public string Username
        { 
            get { return username; } 
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
