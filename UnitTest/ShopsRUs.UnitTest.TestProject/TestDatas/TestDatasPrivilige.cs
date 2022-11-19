using ShopsRUs.Services.Api.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.UnitTest.TestProject
{
    public class TestDatasPrivilige : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //100+((60+40)*%5)=>195-5=190
            yield return new object[] { new CustomerDto { RegisteredDate=new DateTime(2018,1,1) }, new List<ProductDto> {
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
            yield return new object[] { new CustomerDto { RegisteredDate=new DateTime(2018,1,1) }, new List<ProductDto> {
                    new ProductDto
                    {
                        IsGrocery = true,
                        Name = "Grocery 2",
                        Price = 50
                    }
            }, 50 };

            // 50+(60*%5)=>50+57=>107-5 =102
            yield return new object[] { new CustomerDto { RegisteredDate=new DateTime(2018,1,1) }, new List<ProductDto> {
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
            }, 102 }; 

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
