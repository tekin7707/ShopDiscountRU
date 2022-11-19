using ShopsRUs.Services.Api.Models.Interfaces;
using ShopsRUs.Services.Api.Models;
using ShopsRUs.Services.Api.Dtos;

namespace ShopsRUs.Services.Api.Services
{
    public interface IDiscountService
    {
        double Calculate(InvoiceDto invoice);

    }
}
