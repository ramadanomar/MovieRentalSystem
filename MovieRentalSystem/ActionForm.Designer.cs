namespace MovieRentalSystem
{
    partial class ActionForm
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
            this.searchRadio = new System.Windows.Forms.RadioButton();
            this.returnRadio = new System.Windows.Forms.RadioButton();
            this.manageRadio = new System.Windows.Forms.RadioButton();
            this.addRadio = new System.Windows.Forms.RadioButton();
            this.changePasswordRadio = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changePasswordRadio);
            this.groupBox1.Controls.Add(this.addRadio);
            this.groupBox1.Controls.Add(this.manageRadio);
            this.groupBox1.Controls.Add(this.returnRadio);
            this.groupBox1.Controls.Add(this.searchRadio);
            this.groupBox1.Location = new System.Drawing.Point(55, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // searchRadio
            // 
            this.searchRadio.AutoSize = true;
            this.searchRadio.Location = new System.Drawing.Point(22, 48);
            this.searchRadio.Name = "searchRadio";
            this.searchRadio.Size = new System.Drawing.Size(127, 17);
            this.searchRadio.TabIndex = 0;
            this.searchRadio.TabStop = true;
            this.searchRadio.Text = "Search / Issue Movie";
            this.searchRadio.UseVisualStyleBackColor = true;
            // 
            // returnRadio
            // 
            this.returnRadio.AutoSize = true;
            this.returnRadio.Location = new System.Drawing.Point(22, 94);
            this.returnRadio.Name = "returnRadio";
            this.returnRadio.Size = new System.Drawing.Size(89, 17);
            this.returnRadio.TabIndex = 1;
            this.returnRadio.TabStop = true;
            this.returnRadio.Text = "Return Movie";
            this.returnRadio.UseVisualStyleBackColor = true;
            // 
            // manageRadio
            // 
            this.manageRadio.AutoSize = true;
            this.manageRadio.Location = new System.Drawing.Point(22, 143);
            this.manageRadio.Name = "manageRadio";
            this.manageRadio.Size = new System.Drawing.Size(117, 17);
            this.manageRadio.TabIndex = 2;
            this.manageRadio.TabStop = true;
            this.manageRadio.Text = "Manage Categories";
            this.manageRadio.UseVisualStyleBackColor = true;
            // 
            // addRadio
            // 
            this.addRadio.AutoSize = true;
            this.addRadio.Location = new System.Drawing.Point(22, 199);
            this.addRadio.Name = "addRadio";
            this.addRadio.Size = new System.Drawing.Size(127, 17);
            this.addRadio.TabIndex = 3;
            this.addRadio.TabStop = true;
            this.addRadio.Text = "Add / Remove Movie";
            this.addRadio.UseVisualStyleBackColor = true;
            // 
            // changePasswordRadio
            // 
            this.changePasswordRadio.AutoSize = true;
            this.changePasswordRadio.Location = new System.Drawing.Point(22, 256);
            this.changePasswordRadio.Name = "changePasswordRadio";
            this.changePasswordRadio.Size = new System.Drawing.Size(111, 17);
            this.changePasswordRadio.TabIndex = 4;
            this.changePasswordRadio.TabStop = true;
            this.changePasswordRadio.Text = "Change Password";
            this.changePasswordRadio.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(55, 364);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(284, 45);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ActionForm";
            this.Text = "ActionForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton changePasswordRadio;
        private System.Windows.Forms.RadioButton addRadio;
        private System.Windows.Forms.RadioButton manageRadio;
        private System.Windows.Forms.RadioButton returnRadio;
        private System.Windows.Forms.RadioButton searchRadio;
        private System.Windows.Forms.Button submitButton;
    }
}