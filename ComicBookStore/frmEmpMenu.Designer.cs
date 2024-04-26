namespace ComicBookStore
{
    partial class frmEmpMenu
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
            this.btnModifyComics = new System.Windows.Forms.Button();
            this.btnEnterComics = new System.Windows.Forms.Button();
            this.btnEmpStock = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifyComics
            // 
            this.btnModifyComics.Location = new System.Drawing.Point(301, 130);
            this.btnModifyComics.Name = "btnModifyComics";
            this.btnModifyComics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModifyComics.Size = new System.Drawing.Size(145, 72);
            this.btnModifyComics.TabIndex = 2;
            this.btnModifyComics.Text = "Modify / Delete Comics";
            this.btnModifyComics.UseVisualStyleBackColor = true;
            this.btnModifyComics.Click += new System.EventHandler(this.btnModifyComics_Click);
            // 
            // btnEnterComics
            // 
            this.btnEnterComics.Location = new System.Drawing.Point(110, 130);
            this.btnEnterComics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnterComics.Name = "btnEnterComics";
            this.btnEnterComics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEnterComics.Size = new System.Drawing.Size(173, 72);
            this.btnEnterComics.TabIndex = 3;
            this.btnEnterComics.Text = "Enter new Comics";
            this.btnEnterComics.UseVisualStyleBackColor = true;
            this.btnEnterComics.Click += new System.EventHandler(this.btnEnterComics_Click);
            // 
            // btnEmpStock
            // 
            this.btnEmpStock.Location = new System.Drawing.Point(301, 130);
            this.btnEmpStock.Name = "btnEmpStock";
            this.btnEmpStock.Size = new System.Drawing.Size(145, 72);
            this.btnEmpStock.TabIndex = 4;
            this.btnEmpStock.Text = "View Store\'s Comic Stock";
            this.btnEmpStock.UseVisualStyleBackColor = true;
            this.btnEmpStock.Click += new System.EventHandler(this.btnEmpStock_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(467, 130);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(150, 72);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View Store Comic Stock";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmEmpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 358);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnEnterComics);
            this.Controls.Add(this.btnModifyComics);
            this.Name = "frmEmpMenu";
            this.Text = "frmEmpMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifyComics;
        private System.Windows.Forms.Button btnEnterComics;
        private System.Windows.Forms.Button btnEmpStock;
        private System.Windows.Forms.Button btnView;
    }
}