namespace ShopsRUs.Services.Api.Models
{
    public interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }
        double DiscountAppliedPrice(double? multiply);
    }
}
