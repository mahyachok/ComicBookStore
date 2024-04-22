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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCustLogin_Click(object sender, EventArgs e)
        {

            string username = txtCustUser.Text;
            string password = txtCustPass.Text;





        }

        private void btnEmpLogin_Click(object sender, EventArgs e)
        {

            string username = txtEmpUser.Text;
            string password = txtEmpPass.Text;




        }
    }
}
