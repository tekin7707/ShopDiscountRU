using Microsoft.AspNetCore.Mvc;
using ShopsRUs.Services.Api.Dtos;
using ShopsRUs.Services.Api.Models.Interfaces;
using ShopsRUs.Services.Api.Services;

namespace ShopsRUs.Services.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly ILogger<DiscountController> _logger;

        public DiscountController(ILogger<DiscountController> logger, IDiscountService discountService)
        {
            _logger = logger;
            _discountService = discountService;
        }

        [HttpPost]
        public string GetAsync(InvoiceDto invoice)
        {

            _discountService.Calculate(invoice);
            return "";
        }
    }
}