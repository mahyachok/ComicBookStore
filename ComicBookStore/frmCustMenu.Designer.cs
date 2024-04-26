namespace ComicBookStore
{
    partial class frmCustMenu
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
            this.btnAddComics = new System.Windows.Forms.Button();
            this.btnSellComics = new System.Windows.Forms.Button();
            this.btnViewCollection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddComics
            // 
            this.btnAddComics.Location = new System.Drawing.Point(71, 161);
            this.btnAddComics.Name = "btnAddComics";
            this.btnAddComics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddComics.Size = new System.Drawing.Size(207, 76);
            this.btnAddComics.TabIndex = 0;
            this.btnAddComics.Text = "Add Comics";
            this.btnAddComics.UseVisualStyleBackColor = true;
            this.btnAddComics.Click += new System.EventHandler(this.btnAddComics_Click);
            // 
            // btnSellComics
            // 
            this.btnSellComics.Location = new System.Drawing.Point(538, 161);
            this.btnSellComics.Name = "btnSellComics";
            this.btnSellComics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSellComics.Size = new System.Drawing.Size(177, 76);
            this.btnSellComics.TabIndex = 1;
            this.btnSellComics.Text = "Sell Comics";
            this.btnSellComics.UseVisualStyleBackColor = true;
            this.btnSellComics.Click += new System.EventHandler(this.btnSellComics_Click);
            // 
            // btnViewCollection
            // 
            this.btnViewCollection.Location = new System.Drawing.Point(311, 161);
            this.btnViewCollection.Name = "btnViewCollection";
            this.btnViewCollection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnViewCollection.Size = new System.Drawing.Size(189, 76);
            this.btnViewCollection.TabIndex = 2;
            this.btnViewCollection.Text = "View Comic Collection";
            this.btnViewCollection.UseVisualStyleBackColor = true;
            this.btnViewCollection.Click += new System.EventHandler(this.btnViewCollection_Click);
            // 
            // frmCustMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewCollection);
            this.Controls.Add(this.btnSellComics);
            this.Controls.Add(this.btnAddComics);
            this.Name = "frmCustMenu";
            this.Text = "frmCustMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddComics;
        private System.Windows.Forms.Button btnSellComics;
        private System.Windows.Forms.Button btnViewCollection;
    }
}