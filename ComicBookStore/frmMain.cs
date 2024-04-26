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
    public partial class FrmMenu : Form
    {

        private ComicbookController controller;
        public FrmMenu()
        {
            InitializeComponent();
            controller = new ComicbookController();
        }



        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

           // frmComicEntry frm = new frmComicEntry();
           // frm.Show();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmModifyComics frm = new frmModifyComics();
            frm.Show();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            frmComicDisplay displayForm = new frmComicDisplay();
            displayForm.Show();
        }
        private void LoadComicCovers()
        {
            DataTable dataTable = controller.DisplayComics("SELECT CoverImage FROM ComicCollection");

            imgLstCovers.Images.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                string coverImagePath = row["CoverImage"].ToString();
                if (!string.IsNullOrEmpty(coverImagePath))
                {
                    // Load the image into the ImageList
                    imgLstCovers.Images.Add(Image.FromFile(coverImagePath));
                }
            }

            imgLstCovers.ImageSize = new System.Drawing.Size(100, 100);

            dgvCovers.AutoGenerateColumns = false;
            dgvCovers.Rows.Clear();

            dgvCovers.Columns.Add("Cover", "Cover");
            dgvCovers.Columns[0].DefaultCellStyle.NullValue = null;
            dgvCovers.Columns[0].Width = 100;
            dgvCovers.Columns[0].DefaultCellStyle.Padding = new Padding(10);

            // Add rows to the grid
            for (int i = 0; i < imgLstCovers.Images.Count; i++)
            {
                dgvCovers.Rows.Add();
                dgvCovers.Rows[i].Cells["Cover"].Value = i;
            }

            dgvCovers.Columns["Cover"].DefaultCellStyle.NullValue = null;
            dgvCovers.Columns["Cover"].Width = 100;
            dgvCovers.Columns["Cover"].DefaultCellStyle.Padding = new Padding(10);
            dgvCovers.Columns["Cover"].DefaultCellStyle.SelectionBackColor = dgvCovers.DefaultCellStyle.BackColor;
            dgvCovers.Columns["Cover"].DefaultCellStyle.SelectionForeColor = dgvCovers.DefaultCellStyle.ForeColor;

            dgvCovers.Refresh();
        }
    }
}
