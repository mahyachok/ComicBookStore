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
        public FrmMenu()
        {
            InitializeComponent();
        }



        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmComicEntry frm = new frmComicEntry();
            frm.Show();


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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteComics frm = new frmDeleteComics();
            frm.Show();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            frmComicDisplay displayForm = new frmComicDisplay();
            displayForm.Show();
        }
    }
}
