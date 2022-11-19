using ShopsRUs.Services.Api.Dtos;
using ShopsRUs.Services.Api.Models;
using ShopsRUs.Services.Api.Models.Interfaces;
using ShopsRUs.Services.Api.Services;
namespace ShopsRUs.UnitTest.TestProject
{
    public class CalculatorTest
    {
        private readonly IDiscountService _discountService;
        public CalculatorTest()
        {
            _discountService = new DiscountService();
        }


        [Theory]
        [ClassData(typeof(TestDatasCustomer))]
        [ClassData(typeof(TestDatasPrivilige))]
        [ClassData(typeof(TestDatasAffiliete))]
        [ClassData(typeof(TestDatasEmployee))]
        public void Calculate(CustomerDto customer, List<ProductDto> products, double expected)
        {
            var result = _discountService.Calculate(new InvoiceDto { customer = customer, products = products });
            Assert.Equal(expected, result);
        }
    }
}