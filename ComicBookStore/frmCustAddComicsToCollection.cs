﻿using System;
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
    public partial class frmCustAddComicsToCollection : Form
    {

        ComicbookController comicbookController = new ComicbookController();
        public frmCustAddComicsToCollection()
        {
            InitializeComponent();
        }

        private void propGridComicCollection_Click(object sender, EventArgs e)
        {

        }

        private void dgvComicbookSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCustAddComicsToCollection_Load(object sender, EventArgs e)
        {
            dgvComicbookSelection.DataSource = comicbookController.DisplayComics(); 


        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            Comicbook selectedComicbook = (Comicbook)dgvComicbookSelection.CurrentRow.DataBoundItem;

            comicbookController.AddComicToDatabase(selectedComicbook);


        }
    }
}