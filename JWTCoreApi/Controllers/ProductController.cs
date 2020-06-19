using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTCoreApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        List<Product> list;
       public ProductController()
        {
            list = new List<Product>()
            {
               new Product(){ Id=1, CategoryId=1, ProductName="Asus Notebook" , UnitPrice=5600 },
               new Product(){ Id=2, CategoryId=2, ProductName="Monitör Asus 144 Hz" , UnitPrice=980  },
               new Product(){ Id=3, CategoryId=2, ProductName="Monitör Lg 60 Hz Wide screen" , UnitPrice=980.45  },
               new Product(){ Id=4, CategoryId=3, ProductName="Klavye" , UnitPrice=119.9  },
               new Product(){ Id=5, CategoryId=4, ProductName="Mause Microsoft" , UnitPrice=25  },
               new Product(){ Id=6, CategoryId=4, ProductName="Mouse Lg" , UnitPrice=850  },
            };
        }

        public IEnumerable<Product> Get()
        {
            return list;
        }

        [HttpGet("{productId}")]
        public IEnumerable<Product> Get(int productId)
        {

            return list.Where(k => k.Id == productId);
        }

        [HttpGet("GetByCategory/{categoryId}")]
        public IEnumerable<Product> GetByCategory(int categoryId)
        {

            return list.Where(k=>k.CategoryId==categoryId);
        }

    }
}