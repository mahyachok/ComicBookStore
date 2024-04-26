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
            ((System.ComponentModel.ISupportInitialize)(this.dgvComics)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(670, 262);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(670, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point(467, 117);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(100, 20);
            this.txtUPC.TabIndex = 2;
            // 
            // txtIssueNo
            // 
            this.txtIssueNo.Location = new System.Drawing.Point(467, 206);
            this.txtIssueNo.Name = "txtIssueNo";
            this.txtIssueNo.Size = new System.Drawing.Size(100, 20);
            this.txtIssueNo.TabIndex = 3;
            // 
            // txtCoverImage
            // 
            this.txtCoverImage.Location = new System.Drawing.Point(467, 262);
            this.txtCoverImage.Name = "txtCoverImage";
            this.txtCoverImage.Size = new System.Drawing.Size(100, 20);
            this.txtCoverImage.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(467, 320);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtIllustrator
            // 
            this.txtIllustrator.Location = new System.Drawing.Point(467, 365);
            this.txtIllustrator.Name = "txtIllustrator";
            this.txtIllustrator.Size = new System.Drawing.Size(100, 20);
            this.txtIllustrator.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(467, 162);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // dgvComics
            // 
            this.dgvComics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComics.Location = new System.Drawing.Point(102, 52);
            this.dgvComics.Name = "dgvComics";
            this.dgvComics.Size = new System.Drawing.Size(240, 318);
            this.dgvComics.TabIndex = 8;
            this.dgvComics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComics_CellContentClick);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(467, 418);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // chkVariant
            // 
            this.chkVariant.AutoSize = true;
            this.chkVariant.Location = new System.Drawing.Point(602, 119);
            this.chkVariant.Name = "chkVariant";
            this.chkVariant.Size = new System.Drawing.Size(90, 17);
            this.chkVariant.TabIndex = 10;
            this.chkVariant.Text = "Variant Cover";
            this.chkVariant.UseVisualStyleBackColor = true;
            // 
            // chkReprint
            // 
            this.chkReprint.AutoSize = true;
            this.chkReprint.Location = new System.Drawing.Point(602, 151);
            this.chkReprint.Name = "chkReprint";
            this.chkReprint.Size = new System.Drawing.Size(60, 17);
            this.chkReprint.TabIndex = 11;
            this.chkReprint.Text = "Reprint";
            this.chkReprint.UseVisualStyleBackColor = true;
            // 
            // frmModifyComics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}