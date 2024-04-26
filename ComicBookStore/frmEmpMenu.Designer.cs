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
            this.SuspendLayout();
            // 
            // btnModifyComics
            // 
            this.btnModifyComics.Location = new System.Drawing.Point(739, 231);
            this.btnModifyComics.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModifyComics.Name = "btnModifyComics";
            this.btnModifyComics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModifyComics.Size = new System.Drawing.Size(188, 102);
            this.btnModifyComics.TabIndex = 2;
            this.btnModifyComics.Text = "Modify / Delete Comics";
            this.btnModifyComics.UseVisualStyleBackColor = true;
            this.btnModifyComics.Click += new System.EventHandler(this.btnModifyComics_Click);
            // 
            // btnEnterComics
            // 
            this.btnEnterComics.Location = new System.Drawing.Point(380, 231);
            this.btnEnterComics.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEnterComics.Name = "btnEnterComics";
            this.btnEnterComics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEnterComics.Size = new System.Drawing.Size(188, 102);
            this.btnEnterComics.TabIndex = 3;
            this.btnEnterComics.Text = "Enter new Comics";
            this.btnEnterComics.UseVisualStyleBackColor = true;
            this.btnEnterComics.Click += new System.EventHandler(this.btnEnterComics_Click);
            // 
            // frmEmpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnEnterComics);
            this.Controls.Add(this.btnModifyComics);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmEmpMenu";
            this.Text = "frmEmpMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifyComics;
        private System.Windows.Forms.Button btnEnterComics;
    }
}