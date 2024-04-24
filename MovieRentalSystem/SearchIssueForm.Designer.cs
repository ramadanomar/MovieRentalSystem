namespace MovieRentalSystem
{
    partial class SearchIssueForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.bookCategoryTextBook = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.publicationLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.movieCategoryLabel = new System.Windows.Forms.Label();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.newMovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.newPublicationTitle = new System.Windows.Forms.TextBox();
            this.newAvailableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.newMovieCategoryTextBox = new System.Windows.Forms.TextBox();
            this.newClientId = new System.Windows.Forms.TextBox();
            this.issueMovieButton = new System.Windows.Forms.Button();
            this.imdbLabel = new System.Windows.Forms.Label();
            this.newIMDbNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.bookCategoryTextBook);
            this.groupBox1.Controls.Add(this.movieTitleTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria - Atleast One";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Category";
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.Location = new System.Drawing.Point(97, 42);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(240, 20);
            this.movieTitleTextBox.TabIndex = 2;
            // 
            // bookCategoryTextBook
            // 
            this.bookCategoryTextBook.Location = new System.Drawing.Point(97, 93);
            this.bookCategoryTextBook.Name = "bookCategoryTextBook";
            this.bookCategoryTextBook.Size = new System.Drawing.Size(240, 20);
            this.bookCategoryTextBook.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(187, 139);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 40);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(423, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Results";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.newIMDbNumber);
            this.groupBox3.Controls.Add(this.imdbLabel);
            this.groupBox3.Controls.Add(this.issueMovieButton);
            this.groupBox3.Controls.Add(this.newClientId);
            this.groupBox3.Controls.Add(this.newMovieCategoryTextBox);
            this.groupBox3.Controls.Add(this.newAvailableQuantityTextBox);
            this.groupBox3.Controls.Add(this.newPublicationTitle);
            this.groupBox3.Controls.Add(this.newMovieTitleTextBox);
            this.groupBox3.Controls.Add(this.clientIdLabel);
            this.groupBox3.Controls.Add(this.movieCategoryLabel);
            this.groupBox3.Controls.Add(this.quantityLabel);
            this.groupBox3.Controls.Add(this.publicationLabel);
            this.groupBox3.Controls.Add(this.movieTitleLabel);
            this.groupBox3.Location = new System.Drawing.Point(25, 441);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1110, 377);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Issue Movie";
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.Location = new System.Drawing.Point(6, 57);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(59, 13);
            this.movieTitleLabel.TabIndex = 0;
            this.movieTitleLabel.Text = "Movie Title";
            // 
            // publicationLabel
            // 
            this.publicationLabel.AutoSize = true;
            this.publicationLabel.Location = new System.Drawing.Point(6, 103);
            this.publicationLabel.Name = "publicationLabel";
            this.publicationLabel.Size = new System.Drawing.Size(59, 13);
            this.publicationLabel.TabIndex = 1;
            this.publicationLabel.Text = "Publication";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(6, 163);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(92, 13);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Available Quantity";
            // 
            // movieCategoryLabel
            // 
            this.movieCategoryLabel.AutoSize = true;
            this.movieCategoryLabel.Location = new System.Drawing.Point(6, 238);
            this.movieCategoryLabel.Name = "movieCategoryLabel";
            this.movieCategoryLabel.Size = new System.Drawing.Size(81, 13);
            this.movieCategoryLabel.TabIndex = 3;
            this.movieCategoryLabel.Text = "Movie Category";
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.Location = new System.Drawing.Point(445, 57);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(47, 13);
            this.clientIdLabel.TabIndex = 4;
            this.clientIdLabel.Text = "Client ID";
            // 
            // newMovieTitleTextBox
            // 
            this.newMovieTitleTextBox.Location = new System.Drawing.Point(141, 54);
            this.newMovieTitleTextBox.Name = "newMovieTitleTextBox";
            this.newMovieTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.newMovieTitleTextBox.TabIndex = 5;
            // 
            // newPublicationTitle
            // 
            this.newPublicationTitle.Location = new System.Drawing.Point(141, 100);
            this.newPublicationTitle.Name = "newPublicationTitle";
            this.newPublicationTitle.Size = new System.Drawing.Size(100, 20);
            this.newPublicationTitle.TabIndex = 6;
            // 
            // newAvailableQuantityTextBox
            // 
            this.newAvailableQuantityTextBox.Location = new System.Drawing.Point(141, 160);
            this.newAvailableQuantityTextBox.Name = "newAvailableQuantityTextBox";
            this.newAvailableQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.newAvailableQuantityTextBox.TabIndex = 7;
            // 
            // newMovieCategoryTextBox
            // 
            this.newMovieCategoryTextBox.Location = new System.Drawing.Point(141, 235);
            this.newMovieCategoryTextBox.Name = "newMovieCategoryTextBox";
            this.newMovieCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.newMovieCategoryTextBox.TabIndex = 8;
            // 
            // newClientId
            // 
            this.newClientId.Location = new System.Drawing.Point(527, 54);
            this.newClientId.Name = "newClientId";
            this.newClientId.Size = new System.Drawing.Size(100, 20);
            this.newClientId.TabIndex = 9;
            // 
            // issueMovieButton
            // 
            this.issueMovieButton.Location = new System.Drawing.Point(422, 302);
            this.issueMovieButton.Name = "issueMovieButton";
            this.issueMovieButton.Size = new System.Drawing.Size(157, 48);
            this.issueMovieButton.TabIndex = 10;
            this.issueMovieButton.Text = "Issue Movie";
            this.issueMovieButton.UseVisualStyleBackColor = true;
            // 
            // imdbLabel
            // 
            this.imdbLabel.AutoSize = true;
            this.imdbLabel.Location = new System.Drawing.Point(445, 107);
            this.imdbLabel.Name = "imdbLabel";
            this.imdbLabel.Size = new System.Drawing.Size(73, 13);
            this.imdbLabel.TabIndex = 11;
            this.imdbLabel.Text = "IMDb Number";
            // 
            // newIMDbNumber
            // 
            this.newIMDbNumber.Location = new System.Drawing.Point(527, 107);
            this.newIMDbNumber.Name = "newIMDbNumber";
            this.newIMDbNumber.Size = new System.Drawing.Size(100, 20);
            this.newIMDbNumber.TabIndex = 12;
            // 
            // SearchIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 830);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchIssueForm";
            this.Text = "Search Issue Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bookCategoryTextBook;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label publicationLabel;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.Label movieCategoryLabel;
        private System.Windows.Forms.TextBox newMovieCategoryTextBox;
        private System.Windows.Forms.TextBox newAvailableQuantityTextBox;
        private System.Windows.Forms.TextBox newPublicationTitle;
        private System.Windows.Forms.TextBox newMovieTitleTextBox;
        private System.Windows.Forms.TextBox newClientId;
        private System.Windows.Forms.Button issueMovieButton;
        private System.Windows.Forms.TextBox newIMDbNumber;
        private System.Windows.Forms.Label imdbLabel;
    }
}