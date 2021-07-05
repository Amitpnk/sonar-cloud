using System;

namespace Refactoring.Movies
{
    public class Movie
    {
        public const int CHILDREN = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        private String title;
        private int priceCode;

        public Movie(String title, int priceCode)
        {
            this.title = title;
            this.priceCode = priceCode;
        }

        public String GetTitle()
        {
            return title;
        }

        public int GetPriceCode()
        {
            return priceCode;
        }

        public void SetPriceCode(int priceCode)
        {
            this.priceCode = priceCode;
        }
    }
}
