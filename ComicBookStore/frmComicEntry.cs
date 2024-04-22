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
            bool variant = false;
            bool reprint = false;
          
            if (chkVariant.Checked) { variant = true;  }
            if (chkReprint.Checked) { reprint = true;}



           // controller.MakeComicBook(txtTitle.Text, txtUPC.Text, int.Parse(txtIssue.Text), txtAuthor.Text, txtArtist.Text, double.Parse(cmbPrice.Text), variant, reprint);

            controller.AddComicBook(controller.MakeComicBook(txtTitle.Text, txtUPC.Text, int.Parse(txtIssue.Text),txtCoverImage.Text, txtAuthor.Text, txtArtist.Text, double.Parse(cmbPrice.Text), variant, reprint));

            MessageBox.Show("Comicbook added to database");
          


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
