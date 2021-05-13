using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.UnitTest
{
    public class RentalTest
    {
        [Test]
        public void getMovieName()
        {
            Movie movie = new Movie("ABC", 100);
            Rental rental = new Rental(movie, 10);
            Assert.AreEqual("ABC", rental.GetMovie());
        }

        [Test]
        public void getDaysRental()
        {
            Movie movie = new Movie("ABC", 100);
            Rental rental = new Rental(movie, 10);
            Assert.AreEqual(10, rental.GetDaysRented());
        }


    }
}
