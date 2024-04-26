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
    internal partial class frmCustComicDisplay : Form
    {
        private ComicbookController controller;
        private FlowLayoutPanel flowLayoutPanel;
        private Customer loggedInCustomer;

        public frmCustComicDisplay(Customer customer)
        {
            InitializeComponent();

            controller = new ComicbookController();
            loggedInCustomer = customer;
            
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            Controls.Add(flowLayoutPanel);
        }

        private void frmCustComicDisplay_Load(object sender, EventArgs e)
        {
            // Get the purchased comics by the logged-in customer
            List<Comicbook> purchasedComics = controller.GetPurchasedComicsByCustomer(loggedInCustomer.Username);

            foreach (Comicbook comic in purchasedComics)
            {
                UserControl comicItem = new UserControl();
                comicItem.Padding = new Padding(5);
                comicItem.Width = flowLayoutPanel.ClientSize.Width - 30;

                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Fill;
                tableLayoutPanel.AutoSize = true;
                tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                // Display the comic details
                tableLayoutPanel.Controls.Add(CreateLabel("UPC: " + comic.UPC));
                tableLayoutPanel.Controls.Add(CreateLabel("Title: " + comic.SeriesTitle));
                tableLayoutPanel.Controls.Add(CreateLabel("Issue No: " + comic.IssueNumber));
                tableLayoutPanel.Controls.Add(CreateLabel("Author: " + comic.Author));
                tableLayoutPanel.Controls.Add(CreateLabel("Illustrator: " + comic.Illustrator));
                tableLayoutPanel.Controls.Add(CreateLabel("Price: " + comic.Price));

                comicItem.Controls.Add(tableLayoutPanel);

                flowLayoutPanel.Controls.Add(comicItem);
            }
        }


        private Label CreateLabel(string text)
        {
            Label label = new Label();
            label.Text = text;
            label.AutoSize = true;
            return label;
        }

    }
}
