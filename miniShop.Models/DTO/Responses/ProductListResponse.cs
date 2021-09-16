using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniShop.Models.DTO.Responses
{
   
    [Serializable]
    public class ProductListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public double? Discount { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}
