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

            if (txtUser.Text == "" || txtPass.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            else 
            {
                Customer newCustomer = controller.MakeCustomer(txtUser.Text, txtPass.Text, txtName.Text);
                controller.AddCustomerToDatabase(newCustomer);
                MessageBox.Show("Account succesfully created.");
            }


            
        }

        private void frmCustRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
