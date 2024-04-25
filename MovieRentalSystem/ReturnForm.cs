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
    public partial class ReturnForm : Form
    {
        MMSEntities context = new MMSEntities();

        public ReturnForm()
        {
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.Rental' table. You can move, or remove it, as needed.
            this.rentalTableAdapter.Fill(this.mMSDataSet.Rental);

        }

        private void resultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var imdb = resultGrid.Rows[e.RowIndex].Cells[1].Value;
            var clientId = resultGrid.Rows[e.RowIndex].Cells[2].Value;
            var isReturned = resultGrid.Rows[e.RowIndex].Cells[3].Value;

            if (imdb.ToString() != String.Empty && clientId.ToString() != String.Empty)
            {
                imdbNumberTextBox.Text = imdb.ToString();
                clientIdTextBox.Text = clientId.ToString();

                if (!(bool)isReturned)
                {
                    returnMovieButton.Enabled = true;
                }
                
            }

            
        }

        private void resetFormState()
        {
            resultGrid.ClearSelection();
            imdbNumberTextBox.Clear();
            clientIdTextBox.Clear();
            returnMovieButton.Enabled = false;
        }

        private void refreshDataGrid()
        {
            var rentals = context.Rentals.ToList();
            resultGrid.DataSource = rentals;
        }

        private void returnMovieButton_Click(object sender, EventArgs e)
        {
            string imdbInput = imdbNumberTextBox.Text;
            string clientIdInput = clientIdTextBox.Text;
            var rental = context.Rentals.Where(x => x.IMDb.Equals(imdbInput) & x.ClientId.Equals(clientIdInput)).FirstOrDefault();

            if (rental != null)
            {
                rental.isReturned = true;
                context.Rentals.AddOrUpdate(rental);
                context.SaveChanges();
                
                // Reset Form State
                resetFormState();

                // Update Movie Quantity
                var movie = context.Movies.Where(x => x.IMDb.Equals(imdbInput)).FirstOrDefault();

                if (movie != null)
                {
                    movie.Quantity++;
                    context.Movies.AddOrUpdate(movie);
                    context.SaveChanges();

                    refreshDataGrid();
                }
            }
        }
    }
}
