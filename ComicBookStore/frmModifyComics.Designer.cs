namespace ComicBookStore
{
    partial class frmModifyComics
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
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.txtIssueNo = new System.Windows.Forms.TextBox();
            this.txtCoverImage = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtIllustrator = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dgvComics = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.chkVariant = new System.Windows.Forms.CheckBox();
            this.chkReprint = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblCover = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblIllustrator = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInstruc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComics)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(684, 341);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 37);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(684, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point(568, 71);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(100, 20);
            this.txtUPC.TabIndex = 2;
            // 
            // txtIssueNo
            // 
            this.txtIssueNo.Location = new System.Drawing.Point(568, 152);
            this.txtIssueNo.Name = "txtIssueNo";
            this.txtIssueNo.Size = new System.Drawing.Size(100, 20);
            this.txtIssueNo.TabIndex = 3;
            // 
            // txtCoverImage
            // 
            this.txtCoverImage.Location = new System.Drawing.Point(568, 195);
            this.txtCoverImage.Name = "txtCoverImage";
            this.txtCoverImage.Size = new System.Drawing.Size(100, 20);
            this.txtCoverImage.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(568, 232);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtIllustrator
            // 
            this.txtIllustrator.Location = new System.Drawing.Point(568, 269);
            this.txtIllustrator.Name = "txtIllustrator";
            this.txtIllustrator.Size = new System.Drawing.Size(100, 20);
            this.txtIllustrator.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(568, 109);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // dgvComics
            // 
            this.dgvComics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComics.Location = new System.Drawing.Point(55, 67);
            this.dgvComics.Name = "dgvComics";
            this.dgvComics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComics.Size = new System.Drawing.Size(383, 318);
            this.dgvComics.TabIndex = 8;
            this.dgvComics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComics_CellContentClick);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(568, 309);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // chkVariant
            // 
            this.chkVariant.AutoSize = true;
            this.chkVariant.Location = new System.Drawing.Point(568, 356);
            this.chkVariant.Name = "chkVariant";
            this.chkVariant.Size = new System.Drawing.Size(90, 17);
            this.chkVariant.TabIndex = 10;
            this.chkVariant.Text = "Variant Cover";
            this.chkVariant.UseVisualStyleBackColor = true;
            // 
            // chkReprint
            // 
            this.chkReprint.AutoSize = true;
            this.chkReprint.Location = new System.Drawing.Point(568, 388);
            this.chkReprint.Name = "chkReprint";
            this.chkReprint.Size = new System.Drawing.Size(60, 17);
            this.chkReprint.TabIndex = 11;
            this.chkReprint.Text = "Reprint";
            this.chkReprint.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(489, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "UPC:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(489, 112);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title:";
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Location = new System.Drawing.Point(489, 152);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(75, 13);
            this.lblIssue.TabIndex = 12;
            this.lblIssue.Text = "Issue Number:";
            // 
            // lblCover
            // 
            this.lblCover.AutoSize = true;
            this.lblCover.Location = new System.Drawing.Point(489, 195);
            this.lblCover.Name = "lblCover";
            this.lblCover.Size = new System.Drawing.Size(70, 13);
            this.lblCover.TabIndex = 12;
            this.lblCover.Text = "Cover Image:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(489, 232);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "Author:";
            // 
            // lblIllustrator
            // 
            this.lblIllustrator.AutoSize = true;
            this.lblIllustrator.Location = new System.Drawing.Point(489, 269);
            this.lblIllustrator.Name = "lblIllustrator";
            this.lblIllustrator.Size = new System.Drawing.Size(52, 13);
            this.lblIllustrator.TabIndex = 12;
            this.lblIllustrator.Text = "Illustrator:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(489, 312);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price:";
            // 
            // lblInstruc
            // 
            this.lblInstruc.AutoSize = true;
            this.lblInstruc.Location = new System.Drawing.Point(55, 48);
            this.lblInstruc.Name = "lblInstruc";
            this.lblInstruc.Size = new System.Drawing.Size(225, 13);
            this.lblInstruc.TabIndex = 13;
            this.lblInstruc.Text = "Select a comic from the list to delete or modify.";
            // 
            // frmModifyComics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInstruc);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblIllustrator);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblCover);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.chkReprint);
            this.Controls.Add(this.chkVariant);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.dgvComics);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtIllustrator);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtCoverImage);
            this.Controls.Add(this.txtIssueNo);
            this.Controls.Add(this.txtUPC);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Name = "frmModifyComics";
            this.Text = "frmModifyComics";
            this.Load += new System.EventHandler(this.frmModifyComics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUPC;
        private System.Windows.Forms.TextBox txtIssueNo;
        private System.Windows.Forms.TextBox txtCoverImage;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtIllustrator;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DataGridView dgvComics;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox chkVariant;
        private System.Windows.Forms.CheckBox chkReprint;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblIllustrator;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInstruc;
    }
}