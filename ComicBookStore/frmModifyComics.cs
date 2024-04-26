using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicBookStore
{
    public partial class frmModifyComics : Form
    {
        private ComicbookController controller;
        private Comicbook selectedComicbook;


        public frmModifyComics()
        {
            InitializeComponent();
            controller = new ComicbookController();
        }

        private void frmModifyComics_Load(object sender, EventArgs e)
        {

            dgvComics.DataSource = controller.DisplayComics();

            this.dgvComics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            bool variant = false;
            bool reprint = false;

            int upc;
            int issue;
            double price;

            if (!int.TryParse(txtUPC.Text, out upc))
            {
                MessageBox.Show("Invalid UPC format. Please enter a valid integer UPC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtIssueNo.Text, out issue))
            {
                MessageBox.Show("Invalid issue number format. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid price format. Please enter a valid decimal price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            

            Comicbook modifiedComic = new Comicbook(txtTitle.Text, upc, issue, txtCoverImage.Text, txtAuthor.Text, txtIllustrator.Text, double.Parse(txtPrice.Text), variant, reprint);
            controller.ModifyComicBook(modifiedComic);

            






        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          

            if(dgvComics.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvComics.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dgvComics.Rows[selectedRowIndex];

                int upc = int.Parse(selectedRow.Cells["UPC"].Value.ToString());

                selectedComicbook =controller.GetComicByUPC(upc);

                controller.DeleteComicFromDatabase(selectedComicbook);
                dgvComics.DataSource = controller.DisplayComics();
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }



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


                
                selectedComicbook.UPC = int.Parse(upc);
                selectedComicbook.SeriesTitle = title;
                selectedComicbook.IssueNumber = int.Parse(issueNo);
                selectedComicbook.CoverImage = coverImage;
                selectedComicbook.Author = author;
                selectedComicbook.Illustrator = illustrator;
                selectedComicbook.Price = double.Parse(price);


                txtUPC.Text = selectedComicbook.UPC.ToString();
                txtTitle.Text = selectedComicbook.SeriesTitle;
                txtIssueNo.Text = selectedComicbook.IssueNumber.ToString();
                txtCoverImage.Text = selectedComicbook.CoverImage;
                txtAuthor.Text = selectedComicbook.Author;
                txtIllustrator.Text = selectedComicbook.Illustrator;
                txtPrice.Text = selectedComicbook.Price.ToString();

            }
        }

        private void btnAddToText_Click(object sender, EventArgs e)
        {

            
            txtUPC.Text = selectedComicbook.UPC.ToString();
            txtTitle.Text = selectedComicbook.SeriesTitle;
            txtIssueNo.Text = selectedComicbook.IssueNumber.ToString();
            txtCoverImage.Text = selectedComicbook.CoverImage;
            txtAuthor.Text = selectedComicbook.Author;
            txtIllustrator.Text = selectedComicbook.Illustrator;
            txtPrice.Text = selectedComicbook.Price.ToString();
            



        }
    }
}
