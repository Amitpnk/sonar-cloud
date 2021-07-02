using NUnit.Framework;

namespace Refactoring.UnitTest
{
    public class CustomerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void checkStatement()
        {
            Customer customer = new Customer("Shyam");
            Movie avengers = new Movie("Avengers", Movie.CHILDREN);
            Rental rental = new Rental(avengers, 2);
            customer.AddRental(rental);
            
            Assert.That(customer.Statement, Is.EqualTo("Rental record for Shyam\n\tAvengers\t1.5\nAmount owed is 1.5\nYou earned 1 frequent renter points"));

        }

        [Test]
        public void getName()
        {
            Customer customer = new Customer("Shyam");
            Assert.AreEqual("Shyam", customer.GetName());
        }
    }
}
