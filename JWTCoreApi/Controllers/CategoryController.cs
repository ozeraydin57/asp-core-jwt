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
    public class CategoryController : ControllerBase
    {
        public IEnumerable<Category> List()
        {
            List<Category> list = new List<Category>()
            {
               new Category(){ Id=1, CategoryName="Bilgisayar" , SeoUrl="link"  },
               new Category(){ Id=2,  CategoryName="Monitör" , SeoUrl="link2"  },
               new Category(){ Id=3,  CategoryName="Klavye" , SeoUrl="link3"  },
               new Category(){ Id=4,  CategoryName="Mause" , SeoUrl="link4"  },
            };
            return list;
        }
    }
}
