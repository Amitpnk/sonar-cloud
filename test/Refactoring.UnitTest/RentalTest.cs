using NUnit.Framework;
using Refactoring.Movies;

namespace Refactoring.UnitTest
{
    public class RentalTest
    {
        //[Test]
        //public void getMovieName()
        //{
        //    Movie movie = new Movie("ABC", 100);
        //    Rental rental = new Rental(movie, 10);
        //    Assert.AreEqual("ABC", rental.GetMovie());
        //}

        [Test]
        public void getDaysRental()
        {
            Movie movie = new Movie("ABC", 100);
            Rental rental = new Rental(movie, 10);
            Assert.AreEqual(10, rental.GetDaysRented());
        }


    }
}
