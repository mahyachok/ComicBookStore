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
    public partial class frmSellComics : Form
    {
        private ComicbookController controller;
        private FlowLayoutPanel flowLayoutPanel;
        private Customer loggedInCustomer;
        internal frmSellComics(Customer customer)
        {
            InitializeComponent();
            controller = new ComicbookController();
            loggedInCustomer = customer;
            dgvComics.DataSource = controller.GetPurchasedComicsByCustomer(loggedInCustomer.Username);
        }

        private void frmSellComics_Load(object sender, EventArgs e)
        {
            InitializeComponent();




        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (dgvComics.SelectedRows.Count > 0)
            {
                int upc = Convert.ToInt32(dgvComics.SelectedRows[0].Cells["UPC"].Value);
                Comicbook comicbook = controller.GetComicByUPC(upc);
                controller.RemoveComicFromCustomer(comicbook, loggedInCustomer);
                dgvComics.Rows.Remove(dgvComics.SelectedRows[0]);
            }
        }
    }
}
