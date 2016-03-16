using System.Collections.Generic;
using System.Linq;

namespace Day2
{
    public class ShoppingCart
    {
        public int CalculatePrice(ICollection<HarryPotter> books)
        {
            var result = 0.0;

            foreach (var book in books)
            {
                result = result + book.Price;
            }

            var distinctBook = books.Distinct().Count();

            return (int)(result * this.getDiscount(distinctBook));
        }
        private double getDiscount(int distinctBook)
        {
            switch (distinctBook)
            {
                case 0:
                    return 0;

                case 1:
                    return 1;

                case 2:
                    return 0.95;

                case 3:
                    return 0.9;

                case 4:
                    return 0.8;

                case 5:
                    return 0.75;

                default:
                    return 0;
            }
        }
    }
}