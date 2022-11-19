namespace ShopsRUs.Services.Api.Models.Interfaces
{
    public interface IProduct
    {
        double Price { get; set; }
        double DiscountAppliedPrice(double? multiply);
    }
}
