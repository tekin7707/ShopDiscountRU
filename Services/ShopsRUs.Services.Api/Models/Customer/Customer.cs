using ShopsRUs.Services.Api.Models.Interfaces;

namespace ShopsRUs.Services.Api.Models.Customer
{
    public class Customer : ICustomer
    {
        private const double MULTIPLY = 1;
        public DateTime? RegisteredDate { get; set; }
        public virtual double Calculate(List<IProduct> products)
        {
            return products.Sum(x => x.DiscountAppliedPrice(MULTIPLY));
        }
    }
}
