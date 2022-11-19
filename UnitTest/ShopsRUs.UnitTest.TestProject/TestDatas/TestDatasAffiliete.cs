using ShopsRUs.Services.Api.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.UnitTest.TestProject
{
    public class TestDatasAffiliete : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //100+((60+40)*%10)=>190-5=185
            yield return new object[] { new CustomerDto { IsAffiliete=true }, new List<ProductDto> {
                    new ProductDto
                    {
                        IsGrocery = true,
                        Price = 100
                    },
                    new ProductDto
                    {
                        IsGrocery = false,
                        Price = 60
                    },
                    new ProductDto
                    {
                        IsGrocery = false,
                        Price = 40
                    }
            }, 185 };

            //50
            yield return new object[] { new CustomerDto { IsAffiliete=true }, new List<ProductDto> {
                    new ProductDto
                    {
                        IsGrocery = true,
                        Price = 50
                    }
            }, 50 };

            // 50+(60*%10)=>50+54=>104-5 =99
            yield return new object[] { new CustomerDto { IsAffiliete=true }, new List<ProductDto> {
                    new ProductDto
                    {
                        IsGrocery = true,
                        Price = 50
                    },
                    new ProductDto
                    {
                        IsGrocery = false,
                        Price = 60
                    }
            }, 99 };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
