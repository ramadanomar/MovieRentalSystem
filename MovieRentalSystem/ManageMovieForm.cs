using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class ManageMovieForm : Form
    {
        MMSEntities context = new MMSEntities();

        public ManageMovieForm()
        {
            InitializeComponent();
            movieCategoryComboBox.DataSource = context.Categories.ToList();
            movieCategoryComboBox.DisplayMember = "Title";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MMSEntities context = new MMSEntities();

            Movie movie = new Movie
            {
                IMDb = newIMDbNumber.Text,
                Publication = newPublicationTitleTextBox.Text,
                Quantity = Convert.ToInt32(newQuantityTextBox.Text),
                Title = newMovieTitleTextBox.Text
            };

            context.Movies.Add(movie);
            context.SaveChanges(); // save to db
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MMSEntities context = new MMSEntities();

            var movie = context.Movies.Where(x => x.IMDb.Equals(removeIMDbNumberTextBox.Text)).FirstOrDefault();

            if (movie != null)
            {
                removeMovieTitleTextBox.Text = movie.Title;
                removeMovieCategoryTextBox.Text = movie.Category;
                removePublicationTextBox.Text = movie.Publication;
                removeAvQuantityTextBox.Text = movie.Quantity.ToString();

                removeButton.Enabled = true;
            } else
            {
                MessageBox.Show("Movie not found in db!");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            MMSEntities context = new MMSEntities();

            var movie = context.Movies.Where(x => x.IMDb.Equals(removeIMDbNumberTextBox.Text)).FirstOrDefault();

            if (movie != null)
            {
                var removeQuantity = Convert.ToInt32(removeRvQuantityTextBox.Text);
                var movieQuantity = movie.Quantity;
                var newQuantity = 0;
                if (removeQuantity > movieQuantity)
                {
                    newQuantity = 0;
                } else
                {
                    newQuantity = movieQuantity - removeQuantity;
                }

                movie.Quantity = newQuantity;

                context.Movies.AddOrUpdate(movie); // upsert
                context.SaveChanges();

                removeAvQuantityTextBox.Text = newQuantity.ToString();
            }
        }

        private void ManageMovieForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.mMSDataSet.Category);

        }
    }
}
