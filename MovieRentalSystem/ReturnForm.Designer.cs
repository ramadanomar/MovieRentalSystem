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
            this.imdbNumberLabel = new System.Windows.Forms.Label();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.returnMovieButton = new System.Windows.Forms.Button();
            this.imdbNumberTextBox = new System.Windows.Forms.TextBox();
            this.clientIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imdbNumberLabel
            // 
            this.imdbNumberLabel.AutoSize = true;
            this.imdbNumberLabel.Location = new System.Drawing.Point(24, 44);
            this.imdbNumberLabel.Name = "imdbNumberLabel";
            this.imdbNumberLabel.Size = new System.Drawing.Size(101, 13);
            this.imdbNumberLabel.TabIndex = 0;
            this.imdbNumberLabel.Text = "Enter IMDb Number";
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.Location = new System.Drawing.Point(24, 110);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(47, 13);
            this.clientIdLabel.TabIndex = 1;
            this.clientIdLabel.Text = "Client ID";
            // 
            // returnMovieButton
            // 
            this.returnMovieButton.Location = new System.Drawing.Point(418, 186);
            this.returnMovieButton.Name = "returnMovieButton";
            this.returnMovieButton.Size = new System.Drawing.Size(151, 53);
            this.returnMovieButton.TabIndex = 2;
            this.returnMovieButton.Text = "Movie Return";
            this.returnMovieButton.UseVisualStyleBackColor = true;
            // 
            // imdbNumberTextBox
            // 
            this.imdbNumberTextBox.Location = new System.Drawing.Point(179, 44);
            this.imdbNumberTextBox.Name = "imdbNumberTextBox";
            this.imdbNumberTextBox.Size = new System.Drawing.Size(307, 20);
            this.imdbNumberTextBox.TabIndex = 3;
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Location = new System.Drawing.Point(179, 110);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.Size = new System.Drawing.Size(307, 20);
            this.clientIdTextBox.TabIndex = 4;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.clientIdTextBox);
            this.Controls.Add(this.imdbNumberTextBox);
            this.Controls.Add(this.returnMovieButton);
            this.Controls.Add(this.clientIdLabel);
            this.Controls.Add(this.imdbNumberLabel);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imdbNumberLabel;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.Button returnMovieButton;
        private System.Windows.Forms.TextBox imdbNumberTextBox;
        private System.Windows.Forms.TextBox clientIdTextBox;
    }
}