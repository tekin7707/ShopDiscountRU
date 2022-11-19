using ShopsRUs.Services.Api.Models.Enums;

namespace ShopsRUs.Services.Api.Models.Interfaces
{
    public interface ICustomer
    {
        DateTime? RegisteredDate { get; set; }
        double Calculate(List<IProduct> products);

    }
}
