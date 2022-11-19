using ShopsRUs.Services.Api.Models;
using ShopsRUs.Services.Api.Models.Interfaces;

namespace ShopsRUs.Services.Api.Dtos
{
    public class InvoiceDto
    {
        public CustomerDto customer { get; set; }
        public List<ProductDto> products { get; set; }
    }
}
