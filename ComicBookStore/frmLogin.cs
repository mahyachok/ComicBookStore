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

        ComicbookController controller;
        public frmLogin()
        {
            InitializeComponent();
            ComicbookController controller = new ComicbookController();
        }

        private void btnCreateCust_Click(object sender, EventArgs e)
        {
            frmCustRegister customerRegistration = new frmCustRegister();
            customerRegistration.ShowDialog();
        }

        private void btnCustLogin_Click(object sender, EventArgs e)
        {
            if(controller.ValidateCustomerLogin(txtCustUser.Text, txtCustPass.Text))
            {

            }
            else
            {
                MessageBox.Show("Invalid customer login.");
            }
            ;
        }
    }
}
