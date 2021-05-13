using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class Customer
    {
        private String name;

        private List<Rental> rentals = new List<Rental>();

        public Customer(String name)
        {
            this.name = name;
        }

        public String GetName()
        {
            return name;
        }

        public void AddRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public String Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;

            String result = "Rental record for " + GetName() + "\n";
            foreach (Rental rental in rentals)
            {
                double amount = 0;
                switch (rental.GetMovie().GetPriceCode())
                {
                    case Movie.REGULAR:
                        amount += 2;
                        if (rental.GetDaysRented() > 2)
                            amount += (rental.GetDaysRented() - 2) * 1.5;
                        break;
                    case Movie.NEW_RELEASE:
                        amount += rental.GetDaysRented() * 3;
                        break;
                    case Movie.CHILDREN:
                        amount += 1.5;
                        if (rental.GetDaysRented() > 3)
                            amount += (rental.GetDaysRented() - 3) * 1.5;
                        break;
                }

                // add frequent renter points
                frequentRenterPoints++;
                // add bonus for a two day new release rental
                if (rental.GetMovie().GetPriceCode() == Movie.NEW_RELEASE && rental.GetDaysRented() > 1)
                    frequentRenterPoints++;

                // show figures for this rental
                result += "\t" + rental.GetMovie().GetTitle() + "\t" + amount + "\n";

                totalAmount += amount;
            }

            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points";

            return result;
        }
    }
}
