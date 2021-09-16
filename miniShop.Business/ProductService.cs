using AutoMapper;
using miniShop.Business.Extensions;
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
    public class ProductService : IProductService
    {
        private IRepository<Product> repository;
        private IMapper mapper;

        public ProductService(IRepository<Product> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<ProductListResponse>> GetProductListResponses()
        {
           
            var products = await repository.GetAll();          
            return products.ConvertToDto(mapper);

        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            return repository.GetWithLazy();
        }
    }
}
