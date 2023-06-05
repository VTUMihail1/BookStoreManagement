namespace BookStoreManagement.Interfaces.Services
{
    /// <summary>
    /// Represents a service for calculating discounts.
    /// </summary>
    public interface ICalculateDiscountService
    {
        /// <summary>
        /// Calculates the discount for the specified value.
        /// </summary>
        /// <param name="value">The value to calculate the discount for.</param>
        /// <returns>The calculated discount as a decimal value.</returns>
        decimal Calculate(decimal value);
    }
}