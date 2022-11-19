using ShopsRUs.Services.Api.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.UnitTest.TestProject
{
    public class TestDatasCustomer : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //100+((60+40))=>200-10=190
            yield return new object[] { new CustomerDto { RegisteredDate=DateTime.Now.AddDays(-140) }, new List<ProductDto> {
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
            }, 190 };

            //50
            yield return new object[] { new CustomerDto { RegisteredDate=DateTime.Now.AddDays(-140) }, new List<ProductDto> {
                    new ProductDto
                    {
                        IsGrocery = true,
                        Name = "Grocery 2",
                        Price = 50
                    }
            }, 50 };

            // 50+(60)=>50+60=>110-5 =105
            yield return new object[] { new CustomerDto { RegisteredDate=DateTime.Now.AddDays(-140) }, new List<ProductDto> {
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
            }, 105 };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
