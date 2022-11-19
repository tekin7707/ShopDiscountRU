using ShopsRUs.Services.Api.Models.Interfaces;

namespace ShopsRUs.Services.Api.Models.Customer
{
    public class Privilige : Customer, ICustomer
    {
        private const double MULTIPLY = .95;
        public override double Calculate(List<IProduct> products)
        {
            return products.Sum(x => x.DiscountAppliedPrice(MULTIPLY));
        }
    }
}
