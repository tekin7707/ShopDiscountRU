using ShopsRUs.Services.Api.Models.Interfaces;

namespace ShopsRUs.Services.Api.Models
{
    public class Invoice
    {
        ICustomer _customer;
        List<IProduct> _products;
        public Invoice(ICustomer customer, List<IProduct> products)
        {
            _customer = customer;
            _products = products;
        }

        public List<IProduct> Products => _products;
        public ICustomer Customer { get; set; }

        public double Price => _products.Sum(x => x.Price);
        public double Calculate()
        {
            var PriceWithPercentDisconts = _customer.Calculate(_products);
            return PriceWithPercentDisconts-(Math.Floor((double)(PriceWithPercentDisconts / 100)) * 5);
        }
    }
}
