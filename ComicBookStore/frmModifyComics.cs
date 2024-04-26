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
        }

        private void frmModifyComics_Load(object sender, EventArgs e)
        {

            //dgvComics.DataSource = controller.DisplayComics();




        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            //controller.ModifyComic(txtUPC.Text, txtTitle.Text, txtIssueNo.Text, txtAuthor.Text, txtIllustrator.Text, txtPrice.Text);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           // controller.DeleteComicFromDatabase(selectedComicbook); 
           // need to make logic to retrieve selected row as comicbook object

        }

        private void dgvComics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
