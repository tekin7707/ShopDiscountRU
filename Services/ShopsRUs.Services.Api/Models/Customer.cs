using ShopsRUs.Services.Api.Models.Interfaces;

namespace ShopsRUs.Services.Api.Models
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

    public class Privilige : Customer,ICustomer
    {
        private const double MULTIPLY = .95;
        public override double Calculate(List<IProduct> products)
        {
            return products.Sum(x => x.DiscountAppliedPrice(MULTIPLY));
        }
    }
    public class Employee : Customer,ICustomer
    {
        private const double MULTIPLY = .75;
        public override double Calculate(List<IProduct> products)
        {
            return products.Sum(x => x.DiscountAppliedPrice(MULTIPLY));
        }
    }

    public class Affiliete : Customer, ICustomer
    {
        private const double MULTIPLY = .90;
        public override double Calculate(List<IProduct> products)
        {
            return products.Sum(x => x.DiscountAppliedPrice(MULTIPLY));
        }
    }

}
