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
        private Employee loggedInEmployee;
        private ComicbookController controller;
        private FlowLayoutPanel flowLayoutPanel;

        internal frmEmpComicDisplay(Employee employee)
        {
            InitializeComponent();
            loggedInEmployee = employee;
            controller = new ComicbookController();
        }

        private void frmEmpComicDisplay_Load(object sender, EventArgs e)
        {
            List<int> ownedComicUPCs = controller.GetStoreComicUPCs(loggedInEmployee.Username);

            foreach (int upc in ownedComicUPCs)
            {
                Comicbook comicbook = controller.GetComicByUPC(upc);
                if (comicbook != null)
                {
                    int rowIndex = dgvComics.Rows.Add();

                    dgvComics.Rows[rowIndex].Cells["Title"].Value = comicbook.SeriesTitle;
                    dgvComics.Rows[rowIndex].Cells["IssueNo"].Value = comicbook.IssueNumber;
                    dgvComics.Rows[rowIndex].Cells["Author"].Value = comicbook.Author;
                    dgvComics.Rows[rowIndex].Cells["Illustrator"].Value = comicbook.Illustrator;
                    dgvComics.Rows[rowIndex].Cells["Price"].Value = comicbook.Price;
                }
            }
        }


        private void cmboStore_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
    }
}
