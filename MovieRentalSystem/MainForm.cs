using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMovieForm manageMovieForm = new ManageMovieForm
            {
                MdiParent = this
            };
            manageMovieForm.Show();
        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategoryForm manageCategoryForm = new ManageCategoryForm
            {
                MdiParent = this
            };
            manageCategoryForm.Show();
        }

        private void removeMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMovieForm manageMovieForm = new ManageMovieForm
            {
                MdiParent = this
            };
            manageMovieForm.Show();
        }

        private void removeCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategoryForm manageCategoryForm = new ManageCategoryForm
            {
                MdiParent = this
            };
            manageCategoryForm.Show();
        }

        private void issueRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchRentalForm searchRentalForm = new SearchRentalForm
            {
                MdiParent = this
            };
            searchRentalForm.Show();
        }

        private void returnRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnForm returnForm = new ReturnForm
            {
                MdiParent = this
            };
            returnForm.Show();
        }
    }
}
