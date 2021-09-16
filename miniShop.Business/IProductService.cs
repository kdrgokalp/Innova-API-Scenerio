using miniShop.DataAccess.Repositories;
using miniShop.Models;
using miniShop.Models.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniShop.Business
{
   public interface IProductService
    {
        Task<IEnumerable<ProductListResponse>> GetProductListResponses();
        Task<IEnumerable<Product>> GetProducts();
      
    }
}
