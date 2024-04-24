namespace ComicBookStore
{
    partial class frmComicEntry
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.chkVariant = new System.Windows.Forms.CheckBox();
            this.chkReprint = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblIllustrator = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtCoverImage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(92, 44);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtIssue
            // 
            this.txtIssue.Location = new System.Drawing.Point(92, 70);
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(100, 20);
            this.txtIssue.TabIndex = 1;
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point(92, 96);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(100, 20);
            this.txtUPC.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(92, 122);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(92, 148);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(100, 20);
            this.txtArtist.TabIndex = 4;
            // 
            // cmbPrice
            // 
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Items.AddRange(new object[] {
            "1.50",
            "2.00",
            "3.50",
            "5.00",
            "10.00",
            "15.00",
            "30.00"});
            this.cmbPrice.Location = new System.Drawing.Point(92, 174);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Size = new System.Drawing.Size(100, 21);
            this.cmbPrice.TabIndex = 5;
            this.cmbPrice.SelectedIndexChanged += new System.EventHandler(this.cmbPrice_SelectedIndexChanged);
            // 
            // chkVariant
            // 
            this.chkVariant.AutoSize = true;
            this.chkVariant.Location = new System.Drawing.Point(92, 227);
            this.chkVariant.Name = "chkVariant";
            this.chkVariant.Size = new System.Drawing.Size(90, 17);
            this.chkVariant.TabIndex = 6;
            this.chkVariant.Text = "Variant Cover";
            this.chkVariant.UseVisualStyleBackColor = true;
            // 
            // chkReprint
            // 
            this.chkReprint.AutoSize = true;
            this.chkReprint.Location = new System.Drawing.Point(92, 250);
            this.chkReprint.Name = "chkReprint";
            this.chkReprint.Size = new System.Drawing.Size(60, 17);
            this.chkReprint.TabIndex = 7;
            this.chkReprint.Text = "Reprint";
            this.chkReprint.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Series Title:";
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Location = new System.Drawing.Point(11, 70);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(75, 13);
            this.lblIssue.TabIndex = 9;
            this.lblIssue.Text = "Issue Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "UPC:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 122);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 11;
            this.lblAuthor.Text = "Author:";
            // 
            // lblIllustrator
            // 
            this.lblIllustrator.AutoSize = true;
            this.lblIllustrator.Location = new System.Drawing.Point(12, 148);
            this.lblIllustrator.Name = "lblIllustrator";
            this.lblIllustrator.Size = new System.Drawing.Size(52, 13);
            this.lblIllustrator.TabIndex = 11;
            this.lblIllustrator.Text = "Illustrator:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 174);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add to Stock";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(13, 201);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(64, 13);
            this.lblUrl.TabIndex = 14;
            this.lblUrl.Text = "Image URL:";
            // 
            // txtCoverImage
            // 
            this.txtCoverImage.Location = new System.Drawing.Point(92, 201);
            this.txtCoverImage.Name = "txtCoverImage";
            this.txtCoverImage.Size = new System.Drawing.Size(100, 20);
            this.txtCoverImage.TabIndex = 15;
            // 
            // frmComicEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCoverImage);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblIllustrator);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chkReprint);
            this.Controls.Add(this.chkVariant);
            this.Controls.Add(this.cmbPrice);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtUPC);
            this.Controls.Add(this.txtIssue);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmComicEntry";
            this.Text = "frmComicEntry";
            this.Load += new System.EventHandler(this.frmComicEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.TextBox txtUPC;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.ComboBox cmbPrice;
        private System.Windows.Forms.CheckBox chkVariant;
        private System.Windows.Forms.CheckBox chkReprint;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblIllustrator;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtCoverImage;
    }
}