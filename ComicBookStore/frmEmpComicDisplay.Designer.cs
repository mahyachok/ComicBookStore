namespace ComicBookStore
{
    partial class frmEmpComicDisplay
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmboStore = new System.Windows.Forms.ComboBox();
            this.dgvComics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComics)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cmboStore
            // 
            this.cmboStore.FormattingEnabled = true;
            this.cmboStore.Location = new System.Drawing.Point(635, 211);
            this.cmboStore.Name = "cmboStore";
            this.cmboStore.Size = new System.Drawing.Size(121, 21);
            this.cmboStore.TabIndex = 0;
            this.cmboStore.SelectedIndexChanged += new System.EventHandler(this.cmboStore_SelectedIndexChanged);
            // 
            // dgvComics
            // 
            this.dgvComics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComics.Location = new System.Drawing.Point(43, 64);
            this.dgvComics.Name = "dgvComics";
            this.dgvComics.Size = new System.Drawing.Size(562, 263);
            this.dgvComics.TabIndex = 1;
            // 
            // frmEmpComicDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvComics);
            this.Controls.Add(this.cmboStore);
            this.Name = "frmEmpComicDisplay";
            this.Text = "frmEmpComicDisplay";
            this.Load += new System.EventHandler(this.frmEmpComicDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmboStore;
        private System.Windows.Forms.DataGridView dgvComics;
    }
}