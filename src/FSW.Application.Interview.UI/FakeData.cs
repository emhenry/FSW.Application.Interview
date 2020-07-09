using FSW.Application.Interview.Model;
using System.Collections.Generic;

namespace FSW.Application.Interview.ViewModel
{
    public static class FakeData
    {
        // Fake data
        public static IList<Product> GetFakeProductData()
        {
            // Normaly it is calling JSON converter to get JSON data
            return new List<Product>()
            {
                new Product(){Id = 1, ProductFamily ="Product Family 1", ProductName = "Product Name 1" , ProductCode = "Product Code 1" },
                new Product(){Id = 2, ProductFamily ="Product Family 2", ProductName = "Product Name 2" , ProductCode = "Product Code 2" },
                new Product(){Id = 3, ProductFamily ="Product Family 2", ProductName = "Product Name 3" , ProductCode = "Product Code 3" }
            };
        }
    }
}
