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
    public partial class frmEmpComicDisplay : Form
    {
        Employee loggedInEmployee;
        internal frmEmpComicDisplay(Employee loggedInEmployee)
        {
            InitializeComponent();
            this.loggedInEmployee = loggedInEmployee;
        }

        private void frmEmpComicDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
