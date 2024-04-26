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
            if (dgvComicbookSelection.SelectedRows.Count > 0)
            {
                Comicbook selectedComicbook = dgvComicbookSelection.SelectedRows[0].DataBoundItem as Comicbook;
                propGridComicCollection.SelectedObject = selectedComicbook;
            }

        }

        private void frmCustAddComicsToCollection_Load(object sender, EventArgs e)
        {

            DataTable comics = comicbookController.DisplayComics();

            foreach (DataRow row in comics.Rows)
            {
                string coverImageUrl = row["CoverImage"].ToString();
                imgComic.Load(coverImageUrl);
                row["CoverImage"] = imgComic.Image;
            }

            dgvComicbookSelection.DataSource = comics;
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            if (dgvComicbookSelection.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvComicbookSelection.SelectedRows[0];

                int upc = int.Parse(selectedRow.Cells["UPC"].Value.ToString());

                comicbookController.AddComicToCustomer(upc, loggedInCustomer);
            }
        }

        private void dgvComicbookSelection_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvComicbookSelection.SelectedRows.Count > 0)
            {
                Comicbook selectedComicbook = dgvComicbookSelection.SelectedRows[0].DataBoundItem as Comicbook;
                propGridComicCollection.SelectedObject = selectedComicbook;
            }

            //imgComic.ImageLocation = dgvComicbookSelection.SelectedRows[0].Cells["CoverImage"].Value.ToString();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
