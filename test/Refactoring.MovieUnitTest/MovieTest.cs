using NUnit.Framework;
using Refactoring.Movies;

namespace Refactoring.MovieUnitTest
{
    public class MovieTest
    {

        [Test]
        public void getMovieTitle()
        {
            Movie movie = new Movie("ABC", 100);
            Assert.AreEqual("ABC", movie.GetTitle());
        }

        [Test]
        public void getMoviePrice()
        {
            Movie movie = new Movie("ABC", 100);
            Assert.AreEqual(100, movie.GetPriceCode());
        }

        [Test]
        public void setMoviePrice()
        {
            Movie movie = new Movie("ABC", 100);
            movie.SetPriceCode(200);
            Assert.AreEqual(200, movie.GetPriceCode());
        }


    }
}
