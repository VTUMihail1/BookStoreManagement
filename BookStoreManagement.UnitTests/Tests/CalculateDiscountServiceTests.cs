using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.Logic.Services;
using BookStoreManagement.StaticData.StaticData;
using NUnit.Framework;

namespace BookStoreManagement.UnitTests.Tests
{
    [TestFixture]
    public class CalculateDiscountServiceTests
    {
        private ICalculateDiscountService _calculateDiscountService;

        [SetUp]
        public void SetUp()
        {
            _calculateDiscountService = new CalculateDiscountService();
        }

        [Test]
        public void Calculate_PriceIsLowerThanFiftheen_ReturnsFivePercent()
        {
            int value = 10;

            decimal result = _calculateDiscountService.Calculate(value);

            decimal newDiscount = result / value;
            Assert.That(newDiscount, Is.EqualTo(BookStoreStaticData.LowestPercentageDiscount));
        }

        [Test]
        public void Calculate_PriceIsHigherThanFourteenLowerThanTwentySix_ReturnsTenPercent()
        {
            decimal value = 20;

            decimal result = _calculateDiscountService.Calculate(value);

            decimal newDiscount = result / value;
            Assert.That(newDiscount, Is.EqualTo(BookStoreStaticData.MiddlePercentageDiscount));
        }

        [Test]
        public void Calculate_PriceIsHigherThanTwentyFive_ReturnsFiftheenPercent()
        {
            int value = 50;

            decimal result = _calculateDiscountService.Calculate(value);

            decimal newDiscount = result / value;
            Assert.That(newDiscount, Is.EqualTo(BookStoreStaticData.HighestPercentageDiscount));
        }
    }
}
