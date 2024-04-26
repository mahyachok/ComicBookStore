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
            LoadComicDisplay();
        }

        private void LoadComicDisplay()
        {
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            this.Controls.Add(flowLayoutPanel);

            string storeName = loggedInEmployee.StoreName;

            List<int> storeComicUPCs = controller.GetStoreComicUPCs(storeName);

            DisplayComics(storeComicUPCs);
        }

        private void DisplayComics(List<int> comicUPCs)
        {
            foreach (int upc in comicUPCs)
            {
                Comicbook comicbook = controller.GetComicByUPC(upc);
                if (comicbook != null)
                {
                    UserControl comicItem = CreateComicItem(comicbook);

                    // Add the comic item to the FlowLayoutPanel
                    flowLayoutPanel.Controls.Add(comicItem);
                }
            }
        }

        private UserControl CreateComicItem(Comicbook comic)
        {
            UserControl comicItem = new UserControl();
            comicItem.Padding = new Padding(5);
            comicItem.Width = flowLayoutPanel.ClientSize.Width - 30;
            comicItem.BackColor = Color.White;
            comicItem.BorderStyle = BorderStyle.FixedSingle;

            Label titleLabel = CreateLabel("Title: " + comic.SeriesTitle);
            Label issueLabel = CreateLabel("Issue No: " + comic.IssueNumber);
            Label authorLabel = CreateLabel("Author: " + comic.Author);
            Label illustratorLabel = CreateLabel("Illustrator: " + comic.Illustrator);
            Label priceLabel = CreateLabel("Price: " + comic.Price);

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.Controls.Add(titleLabel);
            tableLayoutPanel.Controls.Add(issueLabel);
            tableLayoutPanel.Controls.Add(authorLabel);
            tableLayoutPanel.Controls.Add(illustratorLabel);
            tableLayoutPanel.Controls.Add(priceLabel);
            comicItem.Controls.Add(tableLayoutPanel);

            return comicItem;
        }

        private Label CreateLabel(string text)
        {
            Label label = new Label();
            label.Text = text;
            label.AutoSize = true;
            return label;
        }

        private void frmEmpComicDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
