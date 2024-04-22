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
    public partial class frmCustRegister : Form
    {

        private ComicbookController controller; 
        public frmCustRegister()
        {
            InitializeComponent();
            controller = new ComicbookController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //controller.MakeCustomer(txtUser.Text, txtPass.Text, txtName.Text);

            controller.AddCustomer(controller.MakeCustomer(txtUser.Text, txtPass.Text, txtName.Text));
        }

        private void frmCustRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
