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
    public partial class frmComicDisplay : Form
    {
        private ComicbookController controller;
        private FlowLayoutPanel flowLayoutPanel;

        public frmComicDisplay()
        {
            InitializeComponent();
            controller = new ComicbookController();

            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            Controls.Add(flowLayoutPanel);
        }

        private void frmComicDisplay_Load(object sender, EventArgs e)
        {

            DataTable dataTable = controller.DisplayComics();

            foreach (DataRow row in dataTable.Rows)
            {
                UserControl comicItem = new UserControl();
                comicItem.Dock = DockStyle.Top;

                Label upcLabel = new Label();
                upcLabel.Text = "UPC: " + row["UPC"].ToString();
                upcLabel.AutoSize = true;

                Label titleLabel = new Label();
                titleLabel.Text = "Title: " + row["Title"].ToString();
                titleLabel.AutoSize = true;

                Label authorLabel = new Label();
                authorLabel.Text = "Author: " + row["Author"].ToString();
                authorLabel.AutoSize = true;

                Label issueLabel = new Label();
                issueLabel.Text = "Author: " + row["Author"].ToString();
                issueLabel.AutoSize = true;

                Label illustLabel = new Label();
                illustLabel.Text = "Illustrator: " + row["Illustrator"].ToString();
                illustLabel.AutoSize = true;

                Label priceLabel = new Label();
                priceLabel.Text = "Price: " + row["Price"].ToString();
                priceLabel.AutoSize = true;

                comicItem.Controls.Add(upcLabel);
                comicItem.Controls.Add(titleLabel);
                comicItem.Controls.Add(issueLabel);
                comicItem.Controls.Add(authorLabel);
                comicItem.Controls.Add(illustLabel);
                comicItem.Controls.Add(priceLabel);

                flowLayoutPanel.Controls.Add(comicItem);
            }
        }
    }
}