using ShopsRUs.Services.Api.Models.Interfaces;
using ShopsRUs.Services.Api.Models;
using ShopsRUs.Services.Api.Dtos;

namespace ShopsRUs.Services.Api.Services
{
    public class DiscountService : IDiscountService
    {
        private const int PRIVILIGE_DAYS = 730;
        public double Calculate(InvoiceDto invoiceDto)
        {
            ICustomer customer;
            if (invoiceDto.customer.IsEmployee)
                customer = new Employee();
            else if (invoiceDto.customer.IsAffiliete)
                customer = new Affiliete();
            else if (invoiceDto.customer.RegisteredDate.HasValue && DateTime.Now.Subtract(invoiceDto.customer.RegisteredDate.Value).TotalDays > PRIVILIGE_DAYS)
                customer = new Privilige();
            else customer = new Customer();

            List<IProduct> products = new List<IProduct>();
            //foreach (var item in invoice.products)
            //{
            //    products.Add(item.IsGrocery ? new GroceryProduct { Name = item.Name, Price = item.Price }:new Product { Name = item.Name, Price = item.Price });
            //}

            products.AddRange(invoiceDto.products.Select(x => x.IsGrocery ? new GroceryProduct
            {
                Name = x.Name,
                Price = x.Price
            }
            :
            new Product
            {
                Name = x.Name,
                Price = x.Price

            }));

            Invoice invoice = new Invoice(customer, products);
            return invoice.Calculate();
        }
    }
}
