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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.newIMDbNumber = new System.Windows.Forms.TextBox();
            this.imdbLabel = new System.Windows.Forms.Label();
            this.issueMovieButton = new System.Windows.Forms.Button();
            this.newClientId = new System.Windows.Forms.TextBox();
            this.newMovieCategoryTextBox = new System.Windows.Forms.TextBox();
            this.newAvailableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.newPublicationTitle = new System.Windows.Forms.TextBox();
            this.newMovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.movieCategoryLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.publicationLabel = new System.Windows.Forms.Label();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.searchMovieCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.mMSDataSet = new MovieRentalSystem.MMSDataSet();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new MovieRentalSystem.MMSDataSetTableAdapters.MovieTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMDbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchMovieCategoryComboBox);
            this.groupBox1.Controls.Add(this.searchButton);
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
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(187, 139);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 40);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.Location = new System.Drawing.Point(97, 42);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(240, 20);
            this.movieTitleTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Category";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultGrid);
            this.groupBox2.Location = new System.Drawing.Point(423, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Results";
            // 
            // resultGrid
            // 
            this.resultGrid.AutoGenerateColumns = false;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iMDbDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.publicationDataGridViewTextBoxColumn});
            this.resultGrid.DataSource = this.movieBindingSource;
            this.resultGrid.Location = new System.Drawing.Point(6, 29);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.Size = new System.Drawing.Size(706, 339);
            this.resultGrid.TabIndex = 0;
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
            this.groupBox3.Size = new System.Drawing.Size(1110, 258);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Issue Movie";
            // 
            // newIMDbNumber
            // 
            this.newIMDbNumber.Location = new System.Drawing.Point(527, 103);
            this.newIMDbNumber.Name = "newIMDbNumber";
            this.newIMDbNumber.Size = new System.Drawing.Size(100, 20);
            this.newIMDbNumber.TabIndex = 12;
            // 
            // imdbLabel
            // 
            this.imdbLabel.AutoSize = true;
            this.imdbLabel.Location = new System.Drawing.Point(445, 103);
            this.imdbLabel.Name = "imdbLabel";
            this.imdbLabel.Size = new System.Drawing.Size(73, 13);
            this.imdbLabel.TabIndex = 11;
            this.imdbLabel.Text = "IMDb Number";
            // 
            // issueMovieButton
            // 
            this.issueMovieButton.Location = new System.Drawing.Point(902, 54);
            this.issueMovieButton.Name = "issueMovieButton";
            this.issueMovieButton.Size = new System.Drawing.Size(157, 48);
            this.issueMovieButton.TabIndex = 10;
            this.issueMovieButton.Text = "Issue Movie";
            this.issueMovieButton.UseVisualStyleBackColor = true;
            // 
            // newClientId
            // 
            this.newClientId.Location = new System.Drawing.Point(527, 54);
            this.newClientId.Name = "newClientId";
            this.newClientId.Size = new System.Drawing.Size(100, 20);
            this.newClientId.TabIndex = 9;
            // 
            // newMovieCategoryTextBox
            // 
            this.newMovieCategoryTextBox.Location = new System.Drawing.Point(141, 209);
            this.newMovieCategoryTextBox.Name = "newMovieCategoryTextBox";
            this.newMovieCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.newMovieCategoryTextBox.TabIndex = 8;
            // 
            // newAvailableQuantityTextBox
            // 
            this.newAvailableQuantityTextBox.Location = new System.Drawing.Point(141, 160);
            this.newAvailableQuantityTextBox.Name = "newAvailableQuantityTextBox";
            this.newAvailableQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.newAvailableQuantityTextBox.TabIndex = 7;
            // 
            // newPublicationTitle
            // 
            this.newPublicationTitle.Location = new System.Drawing.Point(141, 100);
            this.newPublicationTitle.Name = "newPublicationTitle";
            this.newPublicationTitle.Size = new System.Drawing.Size(100, 20);
            this.newPublicationTitle.TabIndex = 6;
            // 
            // newMovieTitleTextBox
            // 
            this.newMovieTitleTextBox.Location = new System.Drawing.Point(141, 54);
            this.newMovieTitleTextBox.Name = "newMovieTitleTextBox";
            this.newMovieTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.newMovieTitleTextBox.TabIndex = 5;
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
            // movieCategoryLabel
            // 
            this.movieCategoryLabel.AutoSize = true;
            this.movieCategoryLabel.Location = new System.Drawing.Point(6, 212);
            this.movieCategoryLabel.Name = "movieCategoryLabel";
            this.movieCategoryLabel.Size = new System.Drawing.Size(81, 13);
            this.movieCategoryLabel.TabIndex = 3;
            this.movieCategoryLabel.Text = "Movie Category";
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
            // publicationLabel
            // 
            this.publicationLabel.AutoSize = true;
            this.publicationLabel.Location = new System.Drawing.Point(6, 103);
            this.publicationLabel.Name = "publicationLabel";
            this.publicationLabel.Size = new System.Drawing.Size(59, 13);
            this.publicationLabel.TabIndex = 1;
            this.publicationLabel.Text = "Publication";
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
            // searchMovieCategoryComboBox
            // 
            this.searchMovieCategoryComboBox.FormattingEnabled = true;
            this.searchMovieCategoryComboBox.Location = new System.Drawing.Point(97, 90);
            this.searchMovieCategoryComboBox.Name = "searchMovieCategoryComboBox";
            this.searchMovieCategoryComboBox.Size = new System.Drawing.Size(240, 21);
            this.searchMovieCategoryComboBox.TabIndex = 5;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.mMSDataSet;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMDbDataGridViewTextBoxColumn
            // 
            this.iMDbDataGridViewTextBoxColumn.DataPropertyName = "IMDb";
            this.iMDbDataGridViewTextBoxColumn.HeaderText = "IMDb";
            this.iMDbDataGridViewTextBoxColumn.Name = "iMDbDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // publicationDataGridViewTextBoxColumn
            // 
            this.publicationDataGridViewTextBoxColumn.DataPropertyName = "Publication";
            this.publicationDataGridViewTextBoxColumn.HeaderText = "Publication";
            this.publicationDataGridViewTextBoxColumn.Name = "publicationDataGridViewTextBoxColumn";
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
            this.Load += new System.EventHandler(this.SearchIssueForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView resultGrid;
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
        private System.Windows.Forms.ComboBox searchMovieCategoryComboBox;
        private MMSDataSet mMSDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private MMSDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMDbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationDataGridViewTextBoxColumn;
    }
}