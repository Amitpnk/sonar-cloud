using Refactoring.Movies;

namespace Refactoring
{
    public class Rental
    {
        private Movie movie;
        private int daysRented;

        public Rental(Movie movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        public Movie GetMovie()
        {
            return movie;
        }

        public int GetDaysRented()
        {
            return daysRented;
        }
    }
}
