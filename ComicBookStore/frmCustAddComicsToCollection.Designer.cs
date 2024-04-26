namespace ComicBookStore
{
    partial class frmCustAddComicsToCollection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propGridComicCollection = new System.Windows.Forms.PropertyGrid();
            this.dgvComicbookSelection = new System.Windows.Forms.DataGridView();
            this.btnCollection = new System.Windows.Forms.Button();
            this.imgComic = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComicbookSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComic)).BeginInit();
            this.SuspendLayout();
            // 
            // propGridComicCollection
            // 
            this.propGridComicCollection.Location = new System.Drawing.Point(512, 54);
            this.propGridComicCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.propGridComicCollection.Name = "propGridComicCollection";
            this.propGridComicCollection.Size = new System.Drawing.Size(255, 212);
            this.propGridComicCollection.TabIndex = 0;
            this.propGridComicCollection.Click += new System.EventHandler(this.propGridComicCollection_Click);
            // 
            // dgvComicbookSelection
            // 
            this.dgvComicbookSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComicbookSelection.Location = new System.Drawing.Point(23, 69);
            this.dgvComicbookSelection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvComicbookSelection.Name = "dgvComicbookSelection";
            this.dgvComicbookSelection.RowHeadersWidth = 82;
            this.dgvComicbookSelection.RowTemplate.Height = 33;
            this.dgvComicbookSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComicbookSelection.Size = new System.Drawing.Size(463, 197);
            this.dgvComicbookSelection.TabIndex = 1;
            this.dgvComicbookSelection.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComicbookSelection_CellContentClick);
            this.dgvComicbookSelection.SelectionChanged += new System.EventHandler(this.dgvComicbookSelection_SelectionChanged);
            // 
            // btnCollection
            // 
            this.btnCollection.Location = new System.Drawing.Point(447, 480);
            this.btnCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(144, 49);
            this.btnCollection.TabIndex = 2;
            this.btnCollection.Text = "Add to collection";
            this.btnCollection.UseVisualStyleBackColor = true;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // imgComic
            // 
            this.imgComic.Location = new System.Drawing.Point(36, 293);
            this.imgComic.Name = "imgComic";
            this.imgComic.Size = new System.Drawing.Size(166, 236);
            this.imgComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgComic.TabIndex = 3;
            this.imgComic.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(612, 480);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(119, 49);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return to Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmCustAddComicsToCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(773, 579);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.imgComic);
            this.Controls.Add(this.btnCollection);
            this.Controls.Add(this.dgvComicbookSelection);
            this.Controls.Add(this.propGridComicCollection);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCustAddComicsToCollection";
            this.Text = "frmCustAddComicsToCollection";
            this.Load += new System.EventHandler(this.frmCustAddComicsToCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComicbookSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propGridComicCollection;
        private System.Windows.Forms.DataGridView dgvComicbookSelection;
        private System.Windows.Forms.Button btnCollection;
        private System.Windows.Forms.PictureBox imgComic;
        private System.Windows.Forms.Button btnReturn;
    }
}