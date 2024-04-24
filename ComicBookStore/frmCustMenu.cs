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
        public frmCustMenu()
        {
            InitializeComponent();
        }

        private void btnViewCollection_Click(object sender, EventArgs e)
        {


            //maybe we could pass the customer username to the display form so that we can display the comics that the customer has purchased

           frmCustComicDisplay displayForm = new frmCustComicDisplay();
            displayForm.Show();




        }

        private void btnSellComics_Click(object sender, EventArgs e)
        {

        }

        private void btnAddComics_Click(object sender, EventArgs e)
        {

        }
    }
}
