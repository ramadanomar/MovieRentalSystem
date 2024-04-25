namespace MovieRentalSystem
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieToolStripMenuItem,
            this.rentalDetailsToolStripMenuItem,
            this.clientDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movieToolStripMenuItem
            // 
            this.movieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMovieToolStripMenuItem,
            this.addNewCategoryToolStripMenuItem,
            this.removeMovieToolStripMenuItem,
            this.removeCategoryToolStripMenuItem});
            this.movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            this.movieToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.movieToolStripMenuItem.Text = "Movie";
            // 
            // rentalDetailsToolStripMenuItem
            // 
            this.rentalDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueRentalToolStripMenuItem,
            this.returnRentalToolStripMenuItem});
            this.rentalDetailsToolStripMenuItem.Name = "rentalDetailsToolStripMenuItem";
            this.rentalDetailsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.rentalDetailsToolStripMenuItem.Text = "Rental Details";
            // 
            // clientDetailsToolStripMenuItem
            // 
            this.clientDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientDetailsToolStripMenuItem1});
            this.clientDetailsToolStripMenuItem.Name = "clientDetailsToolStripMenuItem";
            this.clientDetailsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.clientDetailsToolStripMenuItem.Text = "Client Details";
            // 
            // addNewMovieToolStripMenuItem
            // 
            this.addNewMovieToolStripMenuItem.Name = "addNewMovieToolStripMenuItem";
            this.addNewMovieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewMovieToolStripMenuItem.Text = "Add New Movie";
            this.addNewMovieToolStripMenuItem.Click += new System.EventHandler(this.addNewMovieToolStripMenuItem_Click);
            // 
            // addNewCategoryToolStripMenuItem
            // 
            this.addNewCategoryToolStripMenuItem.Name = "addNewCategoryToolStripMenuItem";
            this.addNewCategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewCategoryToolStripMenuItem.Text = "Add New Category";
            this.addNewCategoryToolStripMenuItem.Click += new System.EventHandler(this.addNewCategoryToolStripMenuItem_Click);
            // 
            // removeMovieToolStripMenuItem
            // 
            this.removeMovieToolStripMenuItem.Name = "removeMovieToolStripMenuItem";
            this.removeMovieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeMovieToolStripMenuItem.Text = "Remove Movie";
            this.removeMovieToolStripMenuItem.Click += new System.EventHandler(this.removeMovieToolStripMenuItem_Click);
            // 
            // removeCategoryToolStripMenuItem
            // 
            this.removeCategoryToolStripMenuItem.Name = "removeCategoryToolStripMenuItem";
            this.removeCategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeCategoryToolStripMenuItem.Text = "Remove Category";
            this.removeCategoryToolStripMenuItem.Click += new System.EventHandler(this.removeCategoryToolStripMenuItem_Click);
            // 
            // issueRentalToolStripMenuItem
            // 
            this.issueRentalToolStripMenuItem.Name = "issueRentalToolStripMenuItem";
            this.issueRentalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.issueRentalToolStripMenuItem.Text = "Issue Rental";
            this.issueRentalToolStripMenuItem.Click += new System.EventHandler(this.issueRentalToolStripMenuItem_Click);
            // 
            // returnRentalToolStripMenuItem
            // 
            this.returnRentalToolStripMenuItem.Name = "returnRentalToolStripMenuItem";
            this.returnRentalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnRentalToolStripMenuItem.Text = "Return Rental";
            this.returnRentalToolStripMenuItem.Click += new System.EventHandler(this.returnRentalToolStripMenuItem_Click);
            // 
            // clientDetailsToolStripMenuItem1
            // 
            this.clientDetailsToolStripMenuItem1.Name = "clientDetailsToolStripMenuItem1";
            this.clientDetailsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientDetailsToolStripMenuItem1.Text = "Client Details";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1070, 548);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Movie Rental Managment System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientDetailsToolStripMenuItem1;
    }
}