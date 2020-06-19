using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTCoreApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
