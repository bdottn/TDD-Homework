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

            if (books.Count == 2)
            {
                var cart = books.ToList();

                if (cart[0].Episode != cart[1].Episode)
                {
                    result = result * 0.95;
                }
            }

            return (int)result;
        }
    }
}