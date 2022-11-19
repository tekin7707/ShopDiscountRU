namespace ShopsRUs.Services.Api.Models.Product
{
    public class GroceryProduct : Product
    {
        public override double DiscountAppliedPrice(double? multiply) => Price;
    }

}
