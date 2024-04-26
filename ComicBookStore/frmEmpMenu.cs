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
        Employee loggedInEmployee;
        internal frmEmpMenu(Employee loggedInEmployee)
        {
            InitializeComponent();
            this.loggedInEmployee = loggedInEmployee;
        }

        private void btnModifyComics_Click(object sender, EventArgs e)
        {
           frmModifyComics modifyComics = new frmModifyComics();
            modifyComics.ShowDialog();

        }

        private void btnEnterComics_Click(object sender, EventArgs e)
        {
            frmComicEntry comicEntry = new frmComicEntry();
            comicEntry.ShowDialog();

        }

        private void btnEmpStock_Click(object sender, EventArgs e)
        {
            frmEmpComicDisplay comicDisplay = new frmEmpComicDisplay(loggedInEmployee);
        }
    }
}
