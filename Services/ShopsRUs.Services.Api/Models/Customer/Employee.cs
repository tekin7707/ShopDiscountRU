using ShopsRUs.Services.Api.Models.Interfaces;

namespace ShopsRUs.Services.Api.Models.Customer
{
    public class Employee : Customer, ICustomer
    {
        private const double MULTIPLY = .70;
        public override double Calculate(List<IProduct> products)
        {
            return products.Sum(x => x.DiscountAppliedPrice(MULTIPLY));
        }
    }
}
