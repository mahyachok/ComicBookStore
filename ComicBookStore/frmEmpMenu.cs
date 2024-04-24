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
    public partial class frmEmpMenu : Form
    {
        public frmEmpMenu()
        {
            InitializeComponent();
        }

        private void btnModifyComics_Click(object sender, EventArgs e)
        {
           // frmModifyComics modifyComics = new frmModifyComics();
          //  modifyComics.ShowDialog();

        }

        private void btnEnterComics_Click(object sender, EventArgs e)
        {
            frmComicEntry comicEntry = new frmComicEntry();
            comicEntry.ShowDialog();

        }
    }
}
