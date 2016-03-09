using System.Collections.Generic;

namespace Day1
{
    public interface ICalculator
    {
        int[] GetTotalCostByItems(ICollection<Order> orders, int itemCount);

        int[] GetTotalRevenueByItems(ICollection<Order> orders, int itemCount);
    }
}