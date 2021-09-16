using AutoMapper;
using miniShop.Models;
using miniShop.Models.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniShop.Business.Extensions
{
   public static class ConverterExtensions
    {
        public static IEnumerable<ProductListResponse> ConvertToDto(this IEnumerable<Product> products)
        {
            List<ProductListResponse> responses = new List<ProductListResponse>();
            products.ToList().ForEach(p =>
            responses.Add(new ProductListResponse
            {
                CategoryId = p.CategoryId,
                Description = p.Description,
                Discount = p.Discount,
                Id = p.Id,
                ImageUrl = p.ImageUrl,
                Name = p.Name,
                Price = p.Price
            }));

            return responses;
        }

        public static IEnumerable<ProductListResponse> ConvertToDto(this IEnumerable<Product> products, IMapper mapper)
        {

            return mapper.Map<IEnumerable<ProductListResponse>>(products); 
        }
    }
}
