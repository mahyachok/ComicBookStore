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
        public frmComicEntry()
        {
            InitializeComponent();
        }

        private void frmComicEntry_Load(object sender, EventArgs e)
        {


        }

        private void cmbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string seriesTitle = txtTitle.Text;
            string upc = txtUPC.Text;
            int issueNumber = int.Parse(txtIssue.Text);
         
            string author = txtAuthor.Text;
            string illustrator = txtArtist.Text;
            double price = double.Parse(cmbPrice.Text);
            bool variantCover = chkVariant.Checked;
            bool reprint = chkReprint.Checked;

            string sql = "INSERT INTO ComicCollection (Title, UPC, IssueNo, Author, Illustrator, Price, VariantCover, Reprint) VALUES ('" + seriesTitle + "', '" + upc + "', " + issueNumber + ", '" + author + "', '" + illustrator + "', " + price + ", " + variantCover + ", " + reprint + ")";

            Database database = new Database();

            database.DatabaseInsert(sql);

            MessageBox.Show("Comicbook added to database");
          


        }
    }
}
