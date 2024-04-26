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
            string custUsername = loggedInCustomer.Username;

            string str = $"SELECT * FROM Comicbook WHERE CustomerUsername = '{custUsername}'";
            DataTable dataTable = controller.DisplayComics(str);

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

                comicItem.Controls.Add(tableLayoutPanel);

                flowLayoutPanel.Controls.Add(comicItem);
            }

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

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
