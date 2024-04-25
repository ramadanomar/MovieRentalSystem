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
    public partial class SearchRentalForm : Form
    {
        MMSEntities context = new MMSEntities();

        public SearchRentalForm()
        {
            InitializeComponent();
            searchMovieCategoryComboBox.DataSource = context.Categories.ToList();
            searchMovieCategoryComboBox.DisplayMember = "Title";
        }

        private void SearchIssueForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.mMSDataSet.Movie);

        }

        private void refreshDataGrid()
        {
            var Movies = context.Movies.Where(x => x.Title == movieTitleTextBox.Text || x.Category == searchMovieCategoryComboBox.Text).ToList();
            resultGrid.DataSource = Movies;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var Movies = context.Movies.Where(x => x.Title == movieTitleTextBox.Text || x.Category == searchMovieCategoryComboBox.Text).ToList();
            resultGrid.DataSource = Movies;
        }

        private void resultGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var imdb = resultGrid.Rows[e.RowIndex].Cells[1].Value;
            var title = resultGrid.Rows[e.RowIndex].Cells[2].Value;
            var category = resultGrid.Rows[e.RowIndex].Cells[3].Value;
            var quantity = resultGrid.Rows[e.RowIndex].Cells[4].Value;
            var publication = resultGrid.Rows[e.RowIndex].Cells[5].Value;

            newMovieTitleTextBox.Text = title.ToString();
            newAvailableQuantityTextBox.Text = quantity.ToString();
            newMovieCategoryTextBox.Text = category.ToString();
            newIMDbNumberTextBox.Text = imdb.ToString();
            newPublicationTitleTextBox.Text = publication.ToString();
        }

        private void issueMovieButton_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental
            {
                IMDb = newIMDbNumberTextBox.Text,
                isReturned = false,
                ClientId = newClientId.Text
            };


            context.Rentals.Add(rental);
            context.SaveChanges();

            var movie = context.Movies.Where(x => x.IMDb.Equals(newIMDbNumberTextBox.Text)).FirstOrDefault();

            if (movie != null)
            {
                movie.Quantity--;
                context.Movies.AddOrUpdate(movie);
                context.SaveChanges();

                newAvailableQuantityTextBox.Text = movie.Quantity.ToString();

                refreshDataGrid();
            }
        }
    }
}
