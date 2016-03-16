using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Day2.Tests
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void CalculateFeeTest_第一集買1本_第二集買0本_第三集買0本_第四集買0本_第五集買0本_售價為100元()
        {
            // arrange
            var target = new ShoppingCart();

            var books =
                new List<HarryPotter>()
                { 
                    new HarryPotter() { Episode = 1 }
                };

            var expected = 100;

            // act
            var actual = target.CalculatePrice(books);

            // atual
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFeeTest_第一集買1本_第二集買1本_第三集買0本_第四集買0本_第五集買0本_售價為190元()
        {
            // arrange
            var target = new ShoppingCart();

            var books =
                new List<HarryPotter>()
                { 
                    new HarryPotter() { Episode = 1 },
                    new HarryPotter() { Episode = 2 }
                };

            var expected = 190;

            // act
            var actual = target.CalculatePrice(books);

            // atual
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFeeTest_第一集買1本_第二集買1本_第三集買1本_第四集買0本_第五集買0本_售價為270元()
        {
            // arrange
            var target = new ShoppingCart();

            var books =
                new List<HarryPotter>()
                { 
                    new HarryPotter() { Episode = 1 },
                    new HarryPotter() { Episode = 2 },
                    new HarryPotter() { Episode = 3 }
                };

            var expected = 270;

            // act
            var actual = target.CalculatePrice(books);

            // atual
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFeeTest_第一集買1本_第二集買2本_第三集買0本_第四集買0本_第五集買0本_售價為290元()
        {
            // arrange
            var target = new ShoppingCart();

            var books =
                new List<HarryPotter>()
                { 
                    new HarryPotter() { Episode = 1 },
                    new HarryPotter() { Episode = 2 },
                    new HarryPotter() { Episode = 2 },
                };

            var expected = 290;

            // act
            var actual = target.CalculatePrice(books);

            // atual
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFeeTest_第一集買1本_第二集買1本_第三集買1本_第四集買1本_第五集買0本_售價為320元()
        {
            // arrange
            var target = new ShoppingCart();

            var books =
                new List<HarryPotter>()
                { 
                    new HarryPotter() { Episode = 1 },
                    new HarryPotter() { Episode = 2 },
                    new HarryPotter() { Episode = 3 },
                    new HarryPotter() { Episode = 4 },
                };

            var expected = 320;

            // act
            var actual = target.CalculatePrice(books);

            // atual
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFeeTest_第一集買1本_第二集買1本_第三集買1本_第四集買1本_第五集買1本_售價為375元()
        {
            // arrange
            var target = new ShoppingCart();

            var books =
                new List<HarryPotter>()
                { 
                    new HarryPotter() { Episode = 1 },
                    new HarryPotter() { Episode = 2 },
                    new HarryPotter() { Episode = 3 },
                    new HarryPotter() { Episode = 4 },
                    new HarryPotter() { Episode = 5 },
                };

            var expected = 375;

            // act
            var actual = target.CalculatePrice(books);

            // atual
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFeeTest_第一集買1本_第二集買1本_第三集買2本_第四集買0本_第五集買0本_售價為370元()
        {
            // arrange
            var target = new ShoppingCart();

            var books =
                new List<HarryPotter>()
                { 
                    new HarryPotter() { Episode = 1 },
                    new HarryPotter() { Episode = 2 },
                    new HarryPotter() { Episode = 3 },
                    new HarryPotter() { Episode = 3 },
                };

            var expected = 370;

            // act
            var actual = target.CalculatePrice(books);

            // atual
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFeeTest_第一集買1本_第二集買2本_第三集買2本_第四集買0本_第五集買0本_售價為460元()
        {
            // arrange
            var target = new ShoppingCart();

            var books =
                new List<HarryPotter>()
                { 
                    new HarryPotter() { Episode = 1 },
                    new HarryPotter() { Episode = 2 },
                    new HarryPotter() { Episode = 2 },
                    new HarryPotter() { Episode = 3 },
                    new HarryPotter() { Episode = 3 },
                };

            var expected = 460;

            // act
            var actual = target.CalculatePrice(books);

            // atual
            Assert.AreEqual(expected, actual);
        }
    }
}