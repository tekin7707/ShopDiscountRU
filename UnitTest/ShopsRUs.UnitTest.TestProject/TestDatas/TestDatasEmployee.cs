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
            //100+((60+40)*%25)=>175-5=170
            yield return new object[] { new CustomerDto { IsEmployee = true }, new List<ProductDto> {
                    new ProductDto
                    {
                        IsGrocery = true,
                        Name = "Grocery 1",
                        Price = 100
                    },
                    new ProductDto
                    {
                        IsGrocery = false,
                        Name = "Meta 1",
                        Price = 60
                    },
                    new ProductDto
                    {
                        IsGrocery = false,
                        Name = "Meta 2",
                        Price = 40
                    }
            }, 170 };

            //50
            yield return new object[] { new CustomerDto { IsEmployee = true }, new List<ProductDto> {
                    new ProductDto
                    {
                        IsGrocery = true,
                        Name = "Grocery 2",
                        Price = 50
                    }
            }, 50 };

            // 50+(60*%25)=>50+45=>95
            yield return new object[] { new CustomerDto { IsEmployee = true }, new List<ProductDto> {
                    new ProductDto
                    {
                        IsGrocery = true,
                        Name = "Grocery 2",
                        Price = 50
                    },
                    new ProductDto
                    {
                        IsGrocery = false,
                        Name = "Meta 1",
                        Price = 60
                    }
            }, 95 };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
