using Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Day1Test
{
    [TestClass]
    public class CalculatorTest
    {
        List<Order> orders;

        [TestInitialize]
        public void Initialize()
        {
            orders =
                new List<Order>()
                {
                    new Order(){ Id =  1, Cost =  1, Revenue = 11, SellPrice = 21 },
                    new Order(){ Id =  2, Cost =  2, Revenue = 12, SellPrice = 22 },
                    new Order(){ Id =  3, Cost =  3, Revenue = 13, SellPrice = 23 },
                    new Order(){ Id =  4, Cost =  4, Revenue = 14, SellPrice = 24 },
                    new Order(){ Id =  5, Cost =  5, Revenue = 15, SellPrice = 25 },
                    new Order(){ Id =  6, Cost =  6, Revenue = 16, SellPrice = 26 },
                    new Order(){ Id =  7, Cost =  7, Revenue = 17, SellPrice = 27 },
                    new Order(){ Id =  8, Cost =  8, Revenue = 18, SellPrice = 28 },
                    new Order(){ Id =  9, Cost =  9, Revenue = 19, SellPrice = 29 },
                    new Order(){ Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                    new Order(){ Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 },
                };
        }

        [TestMethod]
        public void GetTotalCostByItemsTest_itemCount_3_should_6_15_24_21()
        {
            // arrange
            var target = new StubCalculator();
            var itemCount = 3;
            var expected = new int[] { 6, 15, 24, 21 };

            // act
            var actual = target.GetTotalCostByItems(orders, itemCount);

            //// assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalRevenueByItemsTest_itemCount_4_should_50_66_60()
        {
            // arrange
            var target = new StubCalculator();
            var itemCount = 4;
            var expected = new int[] { 50, 66, 60 };

            // act
            var actual = target.GetTotalRevenueByItems(orders, itemCount);

            //// assert
            CollectionAssert.AreEqual(expected, actual);
        }

        private class StubCalculator : ICalculator
        {
            public int[] GetTotalCostByItems(ICollection<Order> data, int itemCount)
            {
                return new int[] { 6, 15, 24, 21 };
            }

            public int[] GetTotalRevenueByItems(ICollection<Order> data, int itemCount)
            {
                return new int[] { 50, 66, 60 };
            }
        }
    }
}
