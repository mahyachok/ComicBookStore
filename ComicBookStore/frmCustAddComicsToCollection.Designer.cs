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
            ((System.ComponentModel.ISupportInitialize)(this.dgvComicbookSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // propGridComicCollection
            // 
            this.propGridComicCollection.Location = new System.Drawing.Point(699, 42);
            this.propGridComicCollection.Name = "propGridComicCollection";
            this.propGridComicCollection.Size = new System.Drawing.Size(336, 325);
            this.propGridComicCollection.TabIndex = 0;
            this.propGridComicCollection.Click += new System.EventHandler(this.propGridComicCollection_Click);
            // 
            // dgvComicbookSelection
            // 
            this.dgvComicbookSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComicbookSelection.Location = new System.Drawing.Point(103, 132);
            this.dgvComicbookSelection.Name = "dgvComicbookSelection";
            this.dgvComicbookSelection.RowHeadersWidth = 82;
            this.dgvComicbookSelection.RowTemplate.Height = 33;
            this.dgvComicbookSelection.Size = new System.Drawing.Size(487, 441);
            this.dgvComicbookSelection.TabIndex = 1;
            this.dgvComicbookSelection.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComicbookSelection_CellContentClick);
            // 
            // btnCollection
            // 
            this.btnCollection.Location = new System.Drawing.Point(757, 447);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(155, 73);
            this.btnCollection.TabIndex = 2;
            this.btnCollection.Text = "Add to collection";
            this.btnCollection.UseVisualStyleBackColor = true;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // frmCustAddComicsToCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 709);
            this.Controls.Add(this.btnCollection);
            this.Controls.Add(this.dgvComicbookSelection);
            this.Controls.Add(this.propGridComicCollection);
            this.Name = "frmCustAddComicsToCollection";
            this.Text = "frmCustAddComicsToCollection";
            this.Load += new System.EventHandler(this.frmCustAddComicsToCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComicbookSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propGridComicCollection;
        private System.Windows.Forms.DataGridView dgvComicbookSelection;
        private System.Windows.Forms.Button btnCollection;
    }
}