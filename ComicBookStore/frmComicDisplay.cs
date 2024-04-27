using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ComicBookStore
{
    public partial class frmComicDisplay : Form
    {
        private ComicbookController controller;
        private FlowLayoutPanel flowLayoutPanel;
        private Panel panel; 

        public frmComicDisplay()
        {
            InitializeComponent();
            controller = new ComicbookController();

            panel = new Panel();
            panel.Dock = DockStyle.Fill;
            Controls.Add(panel); 

            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.AutoSize = true; 
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown; 
            flowLayoutPanel.AutoScroll = true; 
            panel.Controls.Add(flowLayoutPanel); 
        }

        private void frmComicDisplay_Load(object sender, EventArgs e)
        {
            DataTable dataTable = controller.DisplayComics();

            foreach (DataRow row in dataTable.Rows)
            {
                UserControl comicItem = new UserControl();
                comicItem.Padding = new Padding(5);
                comicItem.Width = flowLayoutPanel.ClientSize.Width - 30;

                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Fill;
                tableLayoutPanel.AutoSize = true;
                tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                tableLayoutPanel.Controls.Add(CreateLabel("UPC: " + row["UPC"].ToString()));
                tableLayoutPanel.Controls.Add(CreateLabel("Title: " + row["Title"].ToString()));
                tableLayoutPanel.Controls.Add(CreateLabel("Issue No: " + row["IssueNo"].ToString()));
                tableLayoutPanel.Controls.Add(CreateLabel("Author: " + row["Author"].ToString()));
                tableLayoutPanel.Controls.Add(CreateLabel("Illustrator: " + row["Illustrator"].ToString()));
                tableLayoutPanel.Controls.Add(CreateLabel("Price: " + row["Price"].ToString()));

                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox.ImageLocation = row["CoverImage"].ToString();
                tableLayoutPanel.Controls.Add(pictureBox);

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
