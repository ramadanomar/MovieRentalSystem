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
    public partial class ManageCategoryForm : Form
    {
        public ManageCategoryForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MMSEntities context = new MMSEntities();

            Category category = new Category
            {
                Title = newCategoryTextBox.Text
            };
            context.Categories.Add(category);
            context.SaveChanges();

            MessageBox.Show("Categories Updated!");
        }
    }
}
