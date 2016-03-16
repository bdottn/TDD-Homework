using System.Collections.Generic;

namespace Day2
{
    public class ShoppingCart
    {
        public int CalculatePrice(ICollection<HarryPotter> books)
        {
            var result = 0;

            foreach (var book in books)
            {
                result = result + book.Price;
            }

            return result;
        }
    }
}