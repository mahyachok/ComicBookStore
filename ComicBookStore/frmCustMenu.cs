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
    public partial class frmCustMenu : Form
    {
        private Customer loggedInCustomer;

        internal frmCustMenu(Customer customer)
        {
            loggedInCustomer = customer;
            InitializeComponent();
        }

        private void btnViewCollection_Click(object sender, EventArgs e)
        {



           frmCustComicDisplay displayForm = new frmCustComicDisplay(loggedInCustomer);
            displayForm.Show();




        }

        private void btnSellComics_Click(object sender, EventArgs e)
        {

        }

        private void btnAddComics_Click(object sender, EventArgs e)
        {
            frmCustAddComicsToCollection addComicsForm = new frmCustAddComicsToCollection(loggedInCustomer);
            addComicsForm.Owner = this;
            addComicsForm.Show();
        }
    }
}
