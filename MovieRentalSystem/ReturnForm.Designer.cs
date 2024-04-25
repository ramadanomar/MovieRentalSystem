namespace MovieRentalSystem
{
    partial class ReturnForm
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
            this.imdbNumberLabel = new System.Windows.Forms.Label();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.returnMovieButton = new System.Windows.Forms.Button();
            this.imdbNumberTextBox = new System.Windows.Forms.TextBox();
            this.clientIdTextBox = new System.Windows.Forms.TextBox();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMDbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReturnedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new MovieRentalSystem.MMSDataSet();
            this.rentalTableAdapter = new MovieRentalSystem.MMSDataSetTableAdapters.RentalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // imdbNumberLabel
            // 
            this.imdbNumberLabel.AutoSize = true;
            this.imdbNumberLabel.Location = new System.Drawing.Point(24, 18);
            this.imdbNumberLabel.Name = "imdbNumberLabel";
            this.imdbNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.imdbNumberLabel.TabIndex = 0;
            this.imdbNumberLabel.Text = "IMDb Number";
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.Location = new System.Drawing.Point(419, 18);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(47, 13);
            this.clientIdLabel.TabIndex = 1;
            this.clientIdLabel.Text = "Client ID";
            // 
            // returnMovieButton
            // 
            this.returnMovieButton.Enabled = false;
            this.returnMovieButton.Location = new System.Drawing.Point(336, 86);
            this.returnMovieButton.Name = "returnMovieButton";
            this.returnMovieButton.Size = new System.Drawing.Size(151, 53);
            this.returnMovieButton.TabIndex = 2;
            this.returnMovieButton.Text = "Movie Return";
            this.returnMovieButton.UseVisualStyleBackColor = true;
            this.returnMovieButton.Click += new System.EventHandler(this.returnMovieButton_Click);
            // 
            // imdbNumberTextBox
            // 
            this.imdbNumberTextBox.Enabled = false;
            this.imdbNumberTextBox.Location = new System.Drawing.Point(27, 47);
            this.imdbNumberTextBox.Name = "imdbNumberTextBox";
            this.imdbNumberTextBox.Size = new System.Drawing.Size(366, 20);
            this.imdbNumberTextBox.TabIndex = 3;
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Enabled = false;
            this.clientIdTextBox.Location = new System.Drawing.Point(422, 47);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.Size = new System.Drawing.Size(366, 20);
            this.clientIdTextBox.TabIndex = 4;
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToAddRows = false;
            this.resultGrid.AllowUserToDeleteRows = false;
            this.resultGrid.AutoGenerateColumns = false;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iMDbDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.isReturnedDataGridViewCheckBoxColumn});
            this.resultGrid.DataSource = this.rentalBindingSource;
            this.resultGrid.Location = new System.Drawing.Point(12, 171);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.Size = new System.Drawing.Size(776, 532);
            this.resultGrid.TabIndex = 5;
            this.resultGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultGrid_CellContentClick);
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
            this.iMDbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isReturnedDataGridViewCheckBoxColumn
            // 
            this.isReturnedDataGridViewCheckBoxColumn.DataPropertyName = "isReturned";
            this.isReturnedDataGridViewCheckBoxColumn.HeaderText = "isReturned";
            this.isReturnedDataGridViewCheckBoxColumn.Name = "isReturnedDataGridViewCheckBoxColumn";
            this.isReturnedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rentalBindingSource
            // 
            this.rentalBindingSource.DataMember = "Rental";
            this.rentalBindingSource.DataSource = this.mMSDataSetBindingSource;
            // 
            // mMSDataSetBindingSource
            // 
            this.mMSDataSetBindingSource.DataSource = this.mMSDataSet;
            this.mMSDataSetBindingSource.Position = 0;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentalTableAdapter
            // 
            this.rentalTableAdapter.ClearBeforeFill = true;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.resultGrid);
            this.Controls.Add(this.clientIdTextBox);
            this.Controls.Add(this.imdbNumberTextBox);
            this.Controls.Add(this.returnMovieButton);
            this.Controls.Add(this.clientIdLabel);
            this.Controls.Add(this.imdbNumberLabel);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imdbNumberLabel;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.Button returnMovieButton;
        private System.Windows.Forms.TextBox imdbNumberTextBox;
        private System.Windows.Forms.TextBox clientIdTextBox;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.BindingSource mMSDataSetBindingSource;
        private MMSDataSet mMSDataSet;
        private System.Windows.Forms.BindingSource rentalBindingSource;
        private MMSDataSetTableAdapters.RentalTableAdapter rentalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMDbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReturnedDataGridViewCheckBoxColumn;
    }
}