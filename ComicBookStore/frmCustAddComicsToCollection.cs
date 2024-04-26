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
    public partial class frmCustAddComicsToCollection : Form
    {
        Customer loggedInCustomer;
        ComicbookController comicbookController;
        internal frmCustAddComicsToCollection(Customer customer)
        {
            InitializeComponent();
            comicbookController = new ComicbookController();
            loggedInCustomer = customer;
        }

        private void propGridComicCollection_Click(object sender, EventArgs e)
        {

        }

        private void dgvComicbookSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCustAddComicsToCollection_Load(object sender, EventArgs e)
        {
            dgvComicbookSelection.DataSource = comicbookController.DisplayComics(); 
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            if (dgvComicbookSelection.SelectedRows.Count > 0)
            {
                Comicbook selectedComicbook = dgvComicbookSelection.SelectedRows[0].DataBoundItem as Comicbook;
                comicbookController.AddComicToDatabase(selectedComicbook);
                comicbookController.AddComicToCustomer(selectedComicbook, loggedInCustomer);
            }
        }

        private void dgvComicbookSelection_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvComicbookSelection.SelectedRows.Count > 0)
            {
                Comicbook selectedComicbook = dgvComicbookSelection.SelectedRows[0].DataBoundItem as Comicbook;
                propGridComicCollection.SelectedObject = selectedComicbook;
            }
        }
    }
}
