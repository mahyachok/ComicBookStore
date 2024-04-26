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
    public partial class frmModifyComics : Form
    {
        private ComicbookController controller;

        public frmModifyComics()
        {
            InitializeComponent();
            controller = new ComicbookController();
        }

        private void frmModifyComics_Load(object sender, EventArgs e)
        {

            dgvComics.DataSource = controller.DisplayComics();




        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            bool variant = false;
            bool reprint = false;

            int upc;
            if (!int.TryParse(txtUPC.Text, out upc))
            {
                MessageBox.Show("Invalid UPC format. Please enter a valid integer UPC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!controller.ComicExists(upc))
            {
                MessageBox.Show("The provided UPC does not exist in the database. Please provide an existing UPC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkVariant.Checked)
            {
                variant = true;
            }

            if (chkReprint.Checked)
            {
                reprint = true;
            }

            Comicbook modifiedComic = new Comicbook(txtTitle.Text, upc, int.Parse(txtIssueNo.Text), txtCoverImage.Text, txtAuthor.Text, txtIllustrator.Text, double.Parse(txtPrice.Text), variant, reprint);
            controller.ModifyComicBook(modifiedComic);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           // controller.DeleteComicFromDatabase(selectedComicbook); 
           // need to make logic to retrieve selected row as comicbook object

        }

        private void dgvComics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvComics.Rows[e.RowIndex];

                string upc = row.Cells["UPC"].Value.ToString();
                string title = row.Cells["Title"].Value.ToString();
                string issueNo = row.Cells["IssueNo"].Value.ToString();
                string coverImage = row.Cells["CoverImage"].Value.ToString();
                string author = row.Cells["Author"].Value.ToString();
                string illustrator = row.Cells["Illustrator"].Value.ToString();
                string price = row.Cells["Price"].Value.ToString();

                txtUPC.Text = upc;
                txtTitle.Text = title;
                txtIssueNo.Text = issueNo;
                txtCoverImage.Text = coverImage;
                txtAuthor.Text = author;
                txtIllustrator.Text = illustrator;
                txtPrice.Text = price;
            }
        }
    }
}
