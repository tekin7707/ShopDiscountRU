using ShopsRUs.Services.Api.Models.Interfaces;

namespace ShopsRUs.Services.Api.Models.Product
{
    public class Product : IProduct
    {
        public double Price { get; set; }
        public virtual double DiscountAppliedPrice(double? multiply) => Price * multiply.Value;
    }

}
