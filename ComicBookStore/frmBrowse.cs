using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicBookStore
{
    public partial class frmBrowse : Form
    {
        public frmBrowse()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string store = cmbStore.Text;



            Database database = new Database();


            //need to get upc from store

            // string query = "SELECT UPC FROM StoreCollection WHERE StoreID = @store";
            

            //then use upc to get comicbook info

            //string query = "SELECT * FROM ComicBook WHERE UPC = @upc";






        }

        private void frmBrowse_Load(object sender, EventArgs e)
        {

           

        }
    }
}
