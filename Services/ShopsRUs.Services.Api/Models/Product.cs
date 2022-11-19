namespace ShopsRUs.Services.Api.Models
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual double DiscountAppliedPrice(double? multiply) => Price * multiply.Value;
    }

    public class GroceryProduct : Product
    {
        public override double DiscountAppliedPrice(double? multiply) => Price;
    }

}
