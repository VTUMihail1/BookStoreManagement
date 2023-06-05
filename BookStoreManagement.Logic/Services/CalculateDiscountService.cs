using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.StaticData.StaticData;

namespace BookStoreManagement.Logic.Services
{
    public class CalculateDiscountService : ICalculateDiscountService
    {
        public decimal Calculate(decimal value)
        {
            decimal discount;

            bool valueIsBelowFiftheen = value < BookStoreStaticData.LowestPriceDiscount;
            bool valueIsBelowTwentySix = value <= BookStoreStaticData.MiddlePriceDiscount;

            if (valueIsBelowFiftheen)
            {
                discount = BookStoreStaticData.LowestPercentageDiscount;
            }
            else if (valueIsBelowTwentySix)
            {
                discount = BookStoreStaticData.MiddlePercentageDiscount;
            }
            else
            {
                discount = BookStoreStaticData.HighestPercentageDiscount;
            }

            value *= discount;
            return value;
        }
    }
}
