using System.Collections.Generic;
using System.Linq;

namespace Day2
{
    public class ShoppingCart
    {
        public int CalculatePrice(ICollection<HarryPotter> books)
        {
            var result = 0.0;

            while (books.Count > 0)
            {
                result = result + this.GetSubPrice(books);
            }

            return (int)result;
        }

        private double GetSubPrice(ICollection<HarryPotter> books)
        {
            var _books = books.ToList();
            var distinct = _books.Select(x => x.Episode).Distinct().ToList();
            var disCount = this.getDiscount(distinct.Count);

            var result = 0.0;

            for (int i = books.Count - 1; i >= 0; i--)
            {
                if (distinct.Any(x => x == _books[i].Episode) == true)
                {
                    result = result + _books[i].Price;

                    distinct.Remove(_books[i].Episode);
                    books.Remove(_books[i]);
                }
            }

            return result * disCount;
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