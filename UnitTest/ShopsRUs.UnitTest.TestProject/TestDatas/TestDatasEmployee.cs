using ShopsRUs.Services.Api.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.UnitTest.TestProject
{
    public class TestDatasEmployee : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //100+((60+40)*%30)=>170-5=165
            yield return new object[] { new CustomerDto { IsEmployee = true }, new List<ProductDto> {
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
            }, 165 };

            //50
            yield return new object[] { new CustomerDto { IsEmployee = true }, new List<ProductDto> {
                    new ProductDto
                    {
                        IsGrocery = true,
                        Price = 50
                    }
            }, 50 };

            // 50+(60*%30)=>50+42=>92
            yield return new object[] { new CustomerDto { IsEmployee = true }, new List<ProductDto> {
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
            }, 92 };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
