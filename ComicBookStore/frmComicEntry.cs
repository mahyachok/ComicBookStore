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
    public partial class frmComicEntry : Form
    {

        private ComicbookController controller;
        public frmComicEntry()
        {
            InitializeComponent();

            controller = new ComicbookController();
           
        }

        private void frmComicEntry_Load(object sender, EventArgs e)
        {


        }

        private void cmbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            bool variant= false;
            bool reprint = false;


            if (chkVariant.Checked)
            {
                variant = true;
            }
            
            if (chkReprint.Checked)
            {
                reprint = true;
            }


            //validation

            if (txtUPC.Text == ""|| txtTitle.Text == "" || txtIssue.Text == "" || txtCoverImage.Text == "" || txtAuthor.Text == "" || txtArtist.Text == "" || cmbPrice.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (int.Parse(txtIssue.Text) < 1)
            {
                MessageBox.Show("Issue number must be greater than 0");
                return;
            }

            if(int.TryParse(txtIssue.Text, out int result) == false)
            {
                MessageBox.Show("Issue number must be a number");
                return;
            }








            controller.AddComicToDatabase(controller.MakeComicbook(Convert.ToInt32(txtUPC.Text), txtTitle.Text, Convert.ToInt32(txtIssue.Text), txtCoverImage.Text, txtAuthor.Text, txtArtist.Text, Convert.ToDouble(cmbPrice.Text), variant, reprint));



            MessageBox.Show("Comicbook added to database");
          


        }

        private void txtCoverImage_TextChanged(object sender, EventArgs e)
        {
            picboxCover.ImageLocation = txtCoverImage.Text; 

        }
    }
}
